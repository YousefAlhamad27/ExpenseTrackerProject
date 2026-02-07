using Microsoft.IdentityModel.Tokens;
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
    public partial class TransferControl : UserControl
    {
        private double _depositAmount;      // based on currency
        private double _withdrawAmount;     // based on currency
        private string firstCode;
        private string secondCode;


        public TransferControl()
        {
            InitializeComponent();
            LoadWallets();
        }

        private void LoadWallets()
        {
            List<clsWallet> wallets = clsWallet.GetAllWallets();

            cbSource.DataSource = wallets;
            cbSource.DisplayMember = "Name";
            cbSource.ValueMember = "WalletID";
            cbSource.SelectedIndex = 0;

            List<clsWallet> wallets2 = new List<clsWallet>(wallets);
            cbDest.DataSource = wallets2;
            cbDest.DisplayMember = "Name";
            cbDest.ValueMember = "WalletID";
            cbDest.SelectedIndex = 1;

            string code1 = clsCurrency.GetCurrencyCodeByID(wallets[0].CurrencyID);
            string code2 = clsCurrency.GetCurrencyCodeByID(wallets2[1].CurrencyID);
            firstCode = code1;
            secondCode = code2;
            txtFirstAmount.PlaceholderText = $"0.00 {code1}";
            txtSecondAmount.PlaceholderText = $"0.00 {code2}";

        }
        private bool isEligibleForSave()
        {
            if (cbSource.SelectedItem == cbDest.SelectedItem)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSecondAmount.Text) || string.IsNullOrWhiteSpace(txtFirstAmount.Text))
            {
                return false;
            }
            try
            {
                double amount = double.Parse(txtFirstAmount.Text.Split(" ")[0]);
                if (amount <= 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private double ComputeConversionFromUS(double amount, double exchangeRate)
        {
            return amount * exchangeRate;

        }

        private double ComputeConversionToUSD(double amount, double exchangeRate)
        {
            return amount / exchangeRate;
        }
        private void DetermineDepositAmount()
        {
            try
            {
                if ((int)cbSource.SelectedValue! == (int)cbDest.SelectedValue!)
                {
                    _depositAmount = double.Parse(txtFirstAmount.Text);
                }
            }
            catch
            {
                MessageBox.Show("Fix your number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsCurrency destCurrency = clsCurrency.GetCurrencyByID(((clsWallet)cbDest.SelectedItem!).CurrencyID);
            clsCurrency sourceCurrency = clsCurrency.GetCurrencyByID(((clsWallet)cbSource.SelectedItem!).CurrencyID);

            if (((clsWallet)cbSource.SelectedItem!).CurrencyID == 1)
            {
                _depositAmount = ComputeConversionToUSD(double.Parse(txtFirstAmount.Text.Split(" ")[0]), destCurrency.ExchangeRateToUSD);
            }
            else if (destCurrency.CurrencyID == 1)
            {
                _depositAmount = ComputeConversionFromUS(double.Parse(txtFirstAmount.Text.Split(" ")[0]), sourceCurrency.ExchangeRateToUSD);
            }
            else
            {
                _depositAmount = ComputeConversionToUSD(ComputeConversionFromUS(double.Parse(txtFirstAmount.Text.Split(" ")[0]), sourceCurrency.ExchangeRateToUSD), destCurrency.ExchangeRateToUSD);

            }

        }
        private void DetermineWithDrawAmount()
        {
            _withdrawAmount = double.Parse((txtFirstAmount.Text.Split(" ")[0]));




        }
        private bool AddTransactionAndTransfer()
        {
            clsTransaction transaction = new clsTransaction
            {
                Date = DateTime.Now,
                Amount = decimal.Parse(txtFirstAmount.Text.Split(" ")[0]),
                WalletID = (int)cbSource.SelectedValue!,
                CategoryID = 10,
                TransactionTypeID = (int)clsTransaction.TransactionType.Transfer,
                Description = string.IsNullOrWhiteSpace(txtBoxDescription.Text) ? null : txtBoxDescription.Text.Trim()
            };
            clsTransfer transfer = new clsTransfer
            {
                SourceWalletID = (int)cbSource.SelectedValue!,
                DestinationWalletID = (int)cbDest.SelectedValue!,
                FirstAmount = double.Parse(txtFirstAmount.Text.Split(" ")[0]),
                SecondAmount = double.Parse(txtFirstAmount.Text.Split(" ")[0]),
                
            };




            DetermineDepositAmount();
            DetermineWithDrawAmount();



            if (DepositToWallet(transfer.DestinationWalletID, _depositAmount) && WithDrawFromWallet(transfer.SourceWalletID, _withdrawAmount))
            {
                if( transaction.Save())
                    transfer.TransactionID = transaction.TransactionID;
                
                return transfer.Save(); 

            }

            return false;
        }

        private bool DepositToWallet(int walletID, double amount)
        {
            clsWallet wallet = clsWallet.GetWalletByID(walletID)!;
            if (wallet == null)
                return false;
            wallet.Balance += Convert.ToDecimal(amount);
            return wallet.Save();
        }
        private bool WithDrawFromWallet(int walletID, double amount)
        {
            clsWallet wallet = clsWallet.GetWalletByID(walletID)!;
            if (wallet == null)
                return false;
            wallet.Balance -= Convert.ToDecimal(amount);
            return wallet.Save();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (!isEligibleForSave())
                return;

            if (!AddTransactionAndTransfer()) { }
            MessageBox.Show("Transfer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void cbSource_SelectedIndexChanged(object sender, EventArgs e)
        {

            firstCode = clsCurrency.GetCurrencyCodeByID(((clsWallet)cbSource.SelectedItem!).CurrencyID);
            txtFirstAmount.PlaceholderText = $"0.00 {firstCode}";
            txtSecondAmount.PlaceholderText = $"0.00 {secondCode}";
            txtFirstAmount.Text = "";
            txtSecondAmount.Text = "";

        }

        private void cbDest_SelectedIndexChanged(object sender, EventArgs e)
        {

            secondCode = clsCurrency.GetCurrencyCodeByID(((clsWallet)cbDest.SelectedItem!).CurrencyID); ;
            txtSecondAmount.PlaceholderText = $"0.00 {secondCode}";
            if (!string.IsNullOrEmpty(txtFirstAmount.Text))
            {
                DetermineDepositAmount();
                txtSecondAmount.Text = $"{_depositAmount} {secondCode}";
            }
            txtSecondAmount.PlaceholderText = $"0.00 {secondCode}";
        }

        private void txtFirstAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstAmount.Text.IsNullOrEmpty())
                return;




            if ((txtFirstAmount.Text.Split()[0] == ""))
                return;
            DetermineDepositAmount();
            DetermineWithDrawAmount();
            txtFirstAmount.Text = _withdrawAmount.ToString() + $" {firstCode}";
            txtSecondAmount.Text = _depositAmount.ToString() + $" {secondCode}";


        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSecondAmount_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtSecondAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
