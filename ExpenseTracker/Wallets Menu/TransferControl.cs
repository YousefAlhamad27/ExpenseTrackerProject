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
        private int sourceWalletID;

        public enum eMode
        {
            Add = 0,
            Edit = 1
        }

        eMode _mode;
        private int _destinationWalletID;
        private int _transactionID;

        public TransferControl(int sourcewalleTID, int transactionID = -1, int destinationWalletID = -1, eMode mode = eMode.Add)
        {
            InitializeComponent();
            _mode = mode;
            _destinationWalletID = destinationWalletID;
            this.sourceWalletID = sourcewalleTID;
            _transactionID = transactionID;
            DateTimePicker.Value = DateTime.Now;
            LoadWallets();
                if (_mode == eMode.Edit)
                {
                   LoadTransactiondata();
            }
        }

        private void LoadTransactiondata()
        {
            clsTransfer transfer = clsTransfer.getTransferByTransID(_transactionID);
            txtFirstAmount.Text = transfer.FirstAmount.ToString() + $" {firstCode}";
            txtSecondAmount.Text = transfer.SecondAmount.ToString() + $" {secondCode}";
            clsTransaction transaction= clsTransaction.GetTransaction(_transactionID);

            if(transaction.Description != null)
                txtBoxDescription.Text = transaction.Description;

            cbSource.SelectedValue = transfer.SourceWalletID;
            cbDest.SelectedValue = transfer.DestinationWalletID;
            DateTimePicker.Value = transaction.Date;
        }

        private void LoadWallets()
        {
            List<clsWallet> wallets = clsWallet.GetAllWallets();

            cbSource.DataSource = wallets;
            cbSource.DisplayMember = "Name";
            cbSource.ValueMember = "WalletID";
            cbSource.SelectedIndex = wallets.IndexOf(wallets.FirstOrDefault(w => w.WalletID == sourceWalletID)!);

            List<clsWallet> wallets2 = new List<clsWallet>(wallets);
            cbDest.DataSource = wallets2;
            cbDest.DisplayMember = "Name";
            cbDest.ValueMember = "WalletID";
            cbDest.SelectedIndex = 1;

            string code1 = clsCurrency.GetCurrencyCodeByID(((clsWallet)cbSource.SelectedItem!).CurrencyID);
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

        private void DetermineDepositAmount()
        {
            try
            {
                if ((int)cbSource.SelectedValue! == (int)cbDest.SelectedValue!)
                {
                    _depositAmount = double.Parse(txtFirstAmount.Text.Split(" ")[0]);
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
                _depositAmount = clsUtil.ComputeConversionFromUSD(double.Parse(txtFirstAmount.Text.Split(" ")[0]), destCurrency.ExchangeRateToUSD);
            }
            else if (destCurrency.CurrencyID == 1)
            {
                _depositAmount = clsUtil.ComputeConversionToUSD(double.Parse(txtFirstAmount.Text.Split(" ")[0]), sourceCurrency.ExchangeRateToUSD);
            }
            else
            {
                _depositAmount = clsUtil.ComputeConversionFromUSD(clsUtil.ComputeConversionToUSD(double.Parse(txtFirstAmount.Text.Split(" ")[0]), sourceCurrency.ExchangeRateToUSD), destCurrency.ExchangeRateToUSD);

            }

        }
        private void DetermineWithDrawAmount()
        {
            _withdrawAmount = double.Parse((txtFirstAmount.Text.Split(" ")[0]));
        }
        private bool Add()
        {
            clsTransaction transaction;
            clsTransfer transfer;


            transaction = new clsTransaction
            {
                Date = DateTime.Now,
                Amount = decimal.Parse(txtFirstAmount.Text.Split(" ")[0]),
                WalletID = (int)cbSource.SelectedValue!,
                CategoryID = 10,
                TransactionTypeID = (int)clsTransaction.TransactionType.Transfer,
                Description = string.IsNullOrWhiteSpace(txtBoxDescription.Text) ? null : txtBoxDescription.Text.Trim()
            };
            transfer = new clsTransfer
            {
                SourceWalletID = (int)cbSource.SelectedValue!,
                DestinationWalletID = (int)cbDest.SelectedValue!,
                FirstAmount = decimal.Parse(txtFirstAmount.Text.Split(" ")[0]),
                SecondAmount = decimal.Parse(txtSecondAmount.Text.Split(" ")[0]),

            };

            DetermineDepositAmount();
            DetermineWithDrawAmount();

            if (DepositToWallet(transfer.DestinationWalletID, _depositAmount) && WithDrawFromWallet(transfer.SourceWalletID, _withdrawAmount))
            {
                if (transaction.Save())
                    transfer.TransactionID = transaction.TransactionID;

                return transfer.Save();


            }
            return false;
        }
        private bool Update()
        {


            clsTransaction transaction = clsTransaction.GetTransaction(_transactionID);
            clsTransfer transfer = clsTransfer.getTransferByTransID(_transactionID);


            clsCurrency secondCurrency = clsCurrency.GetCurrencyByID(clsWallet.getCurrencyID(transfer.DestinationWalletID));
            clsCurrency firstCurrency = clsCurrency.GetCurrencyByID(clsWallet.getCurrencyID(transfer.SourceWalletID));

            clsWallet sourceWallet = clsWallet.GetWalletByID(transfer.SourceWalletID)!;
            clsWallet destWallet = clsWallet.GetWalletByID(transfer.DestinationWalletID)!;

            if (transfer.SourceWalletID == (int)cbSource.SelectedValue! && transfer.DestinationWalletID == (int)cbDest.SelectedValue!)
            {


                decimal amount = 0;
                try
                {

                    amount = Decimal.Parse(txtFirstAmount.Text.Split(" ")[0]);
                }
                catch
                {
                    return false;
                }
                if (amount != transfer.FirstAmount)
                {



                    if (amount > transfer.FirstAmount)
                    {
                        decimal amountSourceWallet = amount - transfer.FirstAmount;

                        double amountSecondWallet = clsUtil.ComputeConversionFromUSD((double)amountSourceWallet, secondCurrency.ExchangeRateToUSD);


                        sourceWallet.Balance -= amountSourceWallet;
                        destWallet.Balance += (decimal)amountSecondWallet;

                        if (!sourceWallet.Save() || !destWallet.Save())
                            return false;

                    }
                    else
                    {
                        decimal amountSourceWallet = transfer.FirstAmount - amount;

                        double amountSecondWallet = clsUtil.ComputeConversionFromUSD((double)amountSourceWallet, secondCurrency.ExchangeRateToUSD);
                        sourceWallet.Balance += amountSourceWallet;
                        destWallet.Balance -= (decimal)amountSecondWallet;

                        if (!sourceWallet.Save() || !destWallet.Save())
                            return false;

                    }

                }



            }

            else if (transfer.SourceWalletID == (int)cbSource.SelectedValue! && transfer.DestinationWalletID != (int)cbDest.SelectedValue!)
            {
                destWallet.Balance -= transfer.SecondAmount;
                clsWallet newDestWallet = clsWallet.GetWalletByID(((clsWallet)cbDest.SelectedItem!).WalletID)!;
                clsCurrency newCurrency = clsCurrency.GetCurrencyByID(newDestWallet.CurrencyID);
                decimal firstAmount= Convert.ToDecimal(txtFirstAmount.Text.Split(" ")[0]);

                if (firstCurrency.CurrencyID == 1)
                {

                    if (transfer.FirstAmount != firstAmount)
                    {
                        decimal amountFirstWallet;
                        decimal amountNewWallet;

                        if (newCurrency.CurrencyID == 1)
                        {

                            amountNewWallet = firstAmount;

                        }
                        else
                        {
                            amountNewWallet = (decimal)clsUtil.ComputeConversionFromUSD((double)firstAmount, newCurrency.ExchangeRateToUSD);

                        }

                        newDestWallet.Balance += amountNewWallet;

                        if (transfer.FirstAmount > firstAmount)
                        {


                            amountFirstWallet = transfer.FirstAmount - firstAmount;
                            sourceWallet.Balance += amountFirstWallet;

                        }
                        else
                        {
                            amountFirstWallet = firstAmount - transfer.FirstAmount;
                            sourceWallet.Balance -= amountFirstWallet;
                        }
                        if (!sourceWallet.Save() || !destWallet.Save() || !newDestWallet.Save())
                            return false;
                    }

                    else
                    {
                        if (firstCurrency.CurrencyID == 1)
                            newDestWallet.Balance += transfer.FirstAmount;

                        else
                        {


                            newDestWallet.Balance += (decimal)clsUtil.ComputeConversionFromUSD(Convert.ToDouble(txtFirstAmount.Text), newCurrency.ExchangeRateToUSD);
                        }

                        if (!destWallet.Save() || !newDestWallet.Save())
                            return false;


                    }

                }

                else             // different currency
                {
                    if (transfer.SecondAmount != firstAmount)
                    {

                        if (transfer.FirstAmount > firstAmount)
                        {
                            sourceWallet.Balance -= transfer.SecondAmount - firstAmount ;
                        }
                        else
                        {
                            sourceWallet.Balance += Convert.ToDecimal(txtSecondAmount.Text) - transfer.SecondAmount;
                        }


                    }

                    if (newCurrency.CurrencyID == 1)
                    {
                        newDestWallet.Balance += (decimal)clsUtil.ComputeConversionToUSD((double)firstAmount, firstCurrency.ExchangeRateToUSD);

                    }
                    else
                    {
                        newDestWallet.Balance += (decimal)clsUtil.ComputeConversionFromUSD
                            (clsUtil.ComputeConversionToUSD((double)firstAmount, firstCurrency.ExchangeRateToUSD), newCurrency.ExchangeRateToUSD);
                    }
                    if (!destWallet.Save() || !newDestWallet.Save())
                        return false;
                }



            }


            else if (transfer.SourceWalletID != (int)cbSource.SelectedValue! && transfer.DestinationWalletID == (int)cbDest.SelectedValue!)
            {
                sourceWallet.Balance += transfer.FirstAmount;
                clsWallet newSourceWallet = clsWallet.GetWalletByID(((clsWallet)cbSource.SelectedItem!).WalletID)!;
                clsCurrency newCurrency = clsCurrency.GetCurrencyByID(newSourceWallet.CurrencyID);
                decimal firstAmount = Convert.ToDecimal(txtFirstAmount.Text.Split(" ")[0]);

                if (secondCurrency.CurrencyID == 1)
                {
                    if (transfer.FirstAmount != firstAmount)
                    {
                        decimal amountFirstWallet;
                        decimal amountNewWallet;

                        if (newCurrency.CurrencyID == 1)
                        {

                            amountNewWallet = firstAmount;

                        }
                        else
                        {
                            amountNewWallet = (decimal)clsUtil.ComputeConversionFromUSD((double)firstAmount, newCurrency.ExchangeRateToUSD);

                        }

                        newSourceWallet.Balance += amountNewWallet;

                        if (transfer.FirstAmount > firstAmount)
                        {


                            amountFirstWallet = transfer.FirstAmount - firstAmount;
                            sourceWallet.Balance += amountFirstWallet;

                        }

                        else
                        {
                            amountFirstWallet = firstAmount - transfer.FirstAmount;
                            sourceWallet.Balance -= amountFirstWallet;
                        }
                        if (!sourceWallet.Save() || !destWallet.Save() || !newSourceWallet.Save())
                            return false;
                    }
                }

                else
                {
                    if (secondCurrency.CurrencyID == 1)
                        newSourceWallet.Balance += transfer.FirstAmount;

                    else
                    {


                        newSourceWallet.Balance += (decimal)clsUtil.ComputeConversionFromUSD((double)firstAmount, newCurrency.ExchangeRateToUSD);
                    }

                    if (!sourceWallet.Save() || !newSourceWallet.Save())
                        return false;


                }

                
            }

            else if (transfer.SourceWalletID != (int)cbSource.SelectedValue! && transfer.DestinationWalletID != (int)cbDest.SelectedValue!)
            {
                sourceWallet.Balance += transfer.FirstAmount;
                    destWallet.Balance -= transfer.SecondAmount;

                clsWallet newSourceWallet = clsWallet.GetWalletByID((int)cbSource.SelectedValue)!;
                clsWallet newDestWallet = clsWallet.GetWalletByID((int)cbDest.SelectedValue)!;

                


                DetermineDepositAmount();
                DetermineWithDrawAmount();
                newSourceWallet.Balance -= (decimal)_withdrawAmount;
                newDestWallet.Balance += (decimal)_depositAmount;

                if (!sourceWallet.Save() || !destWallet.Save() || !newSourceWallet.Save() || !newDestWallet.Save())
                    return false;

            }

            transaction = new clsTransaction
            {
                TransactionID = _transactionID,
                Date = DateTime.Now,
                Amount = decimal.Parse(txtFirstAmount.Text.Split(" ")[0]),
                WalletID = (int)cbSource.SelectedValue!,
                CategoryID = 10,
                TransactionTypeID = (int)clsTransaction.TransactionType.Transfer,
                Description = string.IsNullOrWhiteSpace(txtBoxDescription.Text) ? null : txtBoxDescription.Text.Trim(),
                SubscriptionID = transaction.SubscriptionID,
            };
            transfer = new clsTransfer
            {
                TransferID = transfer.TransferID,
                SourceWalletID = (int)cbSource.SelectedValue!,
                DestinationWalletID = (int)cbDest.SelectedValue!,
                FirstAmount = decimal.Parse(txtFirstAmount.Text.Split(" ")[0]),
                SecondAmount = decimal.Parse(txtSecondAmount.Text.Split(" ")[0]),
                TransactionID = _transactionID,
            };

            return transaction.Save()&&transfer.Save();
        }

        private bool DoSaveAction()
        {
            if (_mode == eMode.Add)
            {
                return Add();
            }
         
            else
                return Update();
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


            if (DoSaveAction()) {
                MessageBox.Show("Transfer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _mode= eMode.Edit;
            }
            
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
