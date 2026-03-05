using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerBussinessLogic;

namespace ExpenseTracker.Wallets_Menu
{
    public partial class EditSubscriptionForm : Form
    {
        private int _subscriptionID;
        private clsSubscription _subscription;
        public event EventHandler<EventArgs> Edited;
        public event EventHandler<EventArgs> Deleted;

        public EditSubscriptionForm(int subscriptionID)
        {
            InitializeComponent();
            _subscriptionID = subscriptionID;
            LoadCategories();
            LoadWallets();
            LoadSubscriptionData();
           
        }
        private void LoadCategories()
        {
            List<clsCategory> categories = clsCategory.GetAllCategories();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";


        }
        private void LoadWallets()
        {
            List<clsWallet> wallets = clsWallet.GetAllWallets();
            cbWallets.DataSource = wallets;
            cbWallets.DisplayMember = "Name";
            cbWallets.ValueMember = "WalletID";


        }
        private void LoadSubscriptionData()
        {
            _subscription = clsSubscription.GetByID(_subscriptionID);
            clsWallet wallet = clsWallet.GetWalletByID(_subscription.WalletID);
            string currencyCode = clsCurrency.GetCurrencyCodeByID(wallet.CurrencyID);

            if (_subscription != null)
            {
                txtAmount.Text = _subscription.Amount.ToString() + $" {currencyCode}";
                txtDescritption.Text = _subscription.Description;
                comboBox1.SelectedValue = _subscription.CategoryID;
                cbWallets.SelectedValue = _subscription.WalletID;
               
                if (_subscription.LastPaymentDate != null )
                    radioUnpaid.Checked = true;
                else
                    radioPaid.Checked = true;
            }

            

            else
            {
                MessageBox.Show("Subscription not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsEligibleForSave()
        {
            if (string.IsNullOrWhiteSpace(txtDescritption.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                return false;
            }
            return true;
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private bool Save()
        {
            
            decimal originalAmount = _subscription.Amount;
            int originalWalletID = _subscription.WalletID;
            bool wasPreviouslyPaid = _subscription.LastPaymentDate != null;

         
            _subscription.Description = txtDescritption.Text;
          
            _subscription.Amount = decimal.Parse(txtAmount.Text.Split(' ')[0]);
            _subscription.CategoryID = (int)comboBox1.SelectedValue!;
            _subscription.WalletID = (int)cbWallets.SelectedValue!;

           
            clsWallet newWallet = clsWallet.GetWalletByID(_subscription.WalletID)!;
            clsWallet originalWallet = (originalWalletID == _subscription.WalletID)
                                        ? newWallet
                                        : clsWallet.GetWalletByID(originalWalletID)!;

            // If marking as paid and it was already paid this month, prevent saving
            if (radioPaid.Checked && (_subscription.LastPaymentDate != null &&
                          _subscription.LastPaymentDate >= clsUtil.GetLastSalaryDate(clsSettings.GetSalaryDay())))
            {
                 
                return false;

            }

            else if (radioPaid.Checked) { 

                if (!wasPreviouslyPaid)
            {

                _subscription.LastPaymentDate = DateTime.Now;

                clsTransaction transaction = new clsTransaction
                {
                    Amount = _subscription.Amount,
                    CategoryID = _subscription.CategoryID,
                    Date = DateTime.Now,
                    Description = _subscription.Description,
                    SubscriptionID = _subscription.SubscriptionID,
                    TransactionTypeID = (int)clsTransaction.TransactionType.Expense,
                    WalletID = _subscription.WalletID
                };

                if (transaction.Save())
                {
                    newWallet.Balance -= _subscription.Amount;
                    newWallet.Save();
                }
            }
            }
            else
            {
                
                if (wasPreviouslyPaid)
                {
                 

                    originalWallet.Balance += originalAmount;
                    originalWallet.Save();

                    _subscription.LastPaymentDate = null;

                     
                    clsTransaction.DeleteBySubscriptionID(_subscription.SubscriptionID);
                }
            }

             
            return _subscription.Save();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (!IsEligibleForSave())
                return;

            if (Save())
            {
                MessageBox.Show("Subscription updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Edited?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Failed to update subscription. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this subscription?","Confirm!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if(clsTransaction.NullifySubscriptionID(_subscription.SubscriptionID))
                if (_subscription.Delete())
                {
                    MessageBox.Show("Subscription deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Deleted?.Invoke(this, EventArgs.Empty);
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to delete subscription. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
