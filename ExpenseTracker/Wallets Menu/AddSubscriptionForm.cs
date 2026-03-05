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
    public partial class AddSubscriptionForm : Form
    {
        private int _walletID;
        public enum OperationMode
        {
            Add,
            Edit
        }
        private  OperationMode _mode;
        private int _subscriptionID;
        public AddSubscriptionForm(int walletID,OperationMode mode, int subscriptionID=-1)
        {
            InitializeComponent();
            _walletID = walletID;
            _mode = mode;
            _subscriptionID = subscriptionID;
            LoadCategories();
            ChangeCurrencyPlaceHolder();
            
        }
        private void ChangeCurrencyPlaceHolder()
        {
            clsWallet wallet = clsWallet.GetWalletByID(_walletID)!;
            string currencyCode = clsCurrency.GetCurrencyCodeByID(wallet.CurrencyID);
            txtAmount.PlaceholderText = "0.00 " + currencyCode;
        }
        private void LoadCategories()
        {
            List<clsCategory> categories = clsCategory.GetAllCategories();


            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.SelectedIndex=comboBox1.FindStringExact("Subscriptions");
            

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private bool IsEligibleForSave()
        {
            if (string.IsNullOrWhiteSpace(txtDescritption.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
                return false;
            return true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(!IsEligibleForSave())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (_mode == OperationMode.Add)
            {
                clsSubscription subscription = new clsSubscription
                {
                    Description = txtDescritption.Text,
                    Amount = decimal.Parse(txtAmount.Text.Split(" ")[0]),
                    CategoryID = (int)comboBox1.SelectedValue!,
                    WalletID = _walletID,

                };
                if (subscription.Save())
                {
                    MessageBox.Show("Subsription Added Successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add subscription. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                clsSubscription subscription = clsSubscription.GetByID(_subscriptionID);
                if (subscription == null)
                {
                    MessageBox.Show("Subscription not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                subscription.Description = txtDescritption.Text;
                subscription.Amount = decimal.Parse(txtAmount.Text.Split(" ")[0]);
                subscription.CategoryID = (int)comboBox1.SelectedValue!;
                subscription.WalletID = _walletID;
            }
           
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            if (e.KeyChar == '.' && (txtAmount.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
