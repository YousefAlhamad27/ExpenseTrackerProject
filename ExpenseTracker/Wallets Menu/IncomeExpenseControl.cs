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
    public partial class IncomeExpenseControl : UserControl
    {
        public enum TransactionType
        {
            Income=2,
            Expense=1
        }
        public enum eMode
        {
            Add,
            Edit
        }
        private int sourceWalletID;
        TransactionType currentType;
        eMode currentMode;
        clsTransaction transaction;
        public IncomeExpenseControl(TransactionType currentType, int sourceWalletID,eMode mode=eMode.Add,int transactionID=-1)
        {
            InitializeComponent();
            DateTimePicker.Value = DateTime.Now;
            currentMode= mode;
            this.currentType = currentType;
            this.sourceWalletID = sourceWalletID;
            if(transactionID > 0 ) 
            transaction = clsTransaction.GetTransaction(transactionID);
            LoadCategories();
            setPlaceHolders();
            if(currentMode == eMode.Edit)
                SetValues();    
        }

        public void SetValues()
        {

           
            string currencyCode = clsCurrency.GetCurrencyByID(clsWallet.GetWalletByID(transaction.WalletID)!.CurrencyID).Code;
            txtAmount.Text = transaction.Amount.ToString()+$" {currencyCode}";
            txtDesc.Text = transaction.Description;
            cbCat.SelectedValue = transaction.CategoryID;
            DateTimePicker.Value = transaction.Date;

        }
        private void setPlaceHolders()
        {
            clsWallet wallet = clsWallet.GetWalletByID(sourceWalletID)!;
            clsCurrency currency = clsCurrency.GetCurrencyByID(wallet.CurrencyID);

            txtAmount.PlaceholderText = $"0.00 {currency.Code}";

        }
        private void LoadCategories()
        {
            List<clsCategory> categories = clsCategory.GetAllCategories();

            cbCat.DataSource = categories;
            cbCat.DisplayMember = "CategoryName";
            cbCat.ValueMember = "CategoryID";
            cbCat.SelectedIndex = 0;
        }

        private bool IsEligibleForSave()
        {
           
            if (string.IsNullOrWhiteSpace(txtAmount.Text)|| cbCat.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }
            if(currentType==TransactionType.Expense)
                if (clsUtil.DoesTransactionExceedLimit((int)cbCat.SelectedValue, double.Parse(txtAmount.Text.Split(" ")[0]), sourceWalletID))
                {
                DialogResult result = MessageBox.Show("This transaction exceeds the category limit. Do you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
                return true;
            }
           
            return true;
        }
        private bool AddTransaction()
        {
            clsTransaction transaction = new clsTransaction
            {
                Date = DateTime.Now,
                Amount = decimal.Parse(txtAmount.Text.Split(" ")[0]),
                WalletID = sourceWalletID,
                CategoryID = (int)cbCat.SelectedValue!,
                TransactionTypeID = (int)currentType,
                Description = string.IsNullOrWhiteSpace(txtDesc.Text) ? null : txtDesc.Text.Trim()
            };

            return transaction.Save();
        }
        private bool EditTransaction()
        {
            transaction.Date = DateTimePicker.Value;
            transaction.Amount = decimal.Parse(txtAmount.Text.Split(" ")[0]);
            transaction.WalletID = sourceWalletID;
            transaction.CategoryID = (int)cbCat.SelectedValue!;
            transaction.TransactionTypeID = (int)currentType;
            transaction.Description = string.IsNullOrWhiteSpace(txtDesc.Text) ? null : txtDesc.Text.Trim();
            return transaction.Save();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            if (!IsEligibleForSave())
            {
                
                return;
            }

            if (currentMode==eMode.Edit)
            {
                if (EditTransaction())
                {
                    MessageBox.Show("Transaction updated successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, clear the form or close it
                }
                else
                {
                    MessageBox.Show("Failed to update the transaction. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
                // Optionally, clear the form or close it
            }
            else
            {
                if (AddTransaction())
                {
                    MessageBox.Show("Transaction added successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, clear the form for a new entry
                     
                     currentMode= eMode.Edit;
                }
                else
                {
                    MessageBox.Show("Failed to save the transaction. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();

            LoadCategories();
        }
    }
}
