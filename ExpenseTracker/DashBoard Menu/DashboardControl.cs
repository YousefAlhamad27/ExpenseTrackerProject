using ExpenseTracker.DashBoard_Menu;
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

namespace ExpenseTracker
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadWallets()
        {
            WalletsLayoutPanel.Controls.Clear();
             List<clsWallet> wallets = clsWallet.GetAllWallets();

            foreach(clsWallet wallet in wallets)
            {
                WalletCard card = new WalletCard();
              
               
                card.WalletName=wallet.Name;
                //card.WalletName = "Wallet" + DateTime.Now.Ticks;
                string currencyCode = clsCurrency.GetCurrencyCodeByID(wallet.CurrencyID);
                card.WalletBalance=wallet.Balance.ToString("F2") + " " + currencyCode;
                

                WalletsLayoutPanel.Controls.Add(card);
            }
            
        }
        private void LoadTransactions()
        {
            flowLayoutPanel1.Controls.Clear();



            //var myData = GetTransactionsFromDB();

            //  foreach (var data in myData)
            // {
            // 1. Create a new instance of your Custom Design


            // 2. Fill it with data
            //item.Title = data.Description; // "Disney Plus"
            //item.Amount = data.Amount + " EUR"; // "15 EUR"
            //item.TransactionId = data.Id;

            for (int i = 0; i < 2; i++)
            {
                TransactionItem item = new TransactionItem();
                item.Title = "Disney Plus";
                item.Amount = 15.5 + " EUR";
                item.TransactionId = 41;
                item.Width = SubscriptionPanel.Width - 25;
                flowLayoutPanel1.Controls.Add(item);
                item.Title = "Spotify";
                item.Amount = 5 + " US";
                item.TransactionId = 14;
                item.Width = SubscriptionPanel.Width - 25;
                flowLayoutPanel1.Controls.Add(item);
            }




            //}
        }

        private void LoadMoneyCards()
        {
            MoneyPanel.Controls.Clear();

            // Example loop
            for (int i = 0; i < 5; i++)
            {
                MoneyCard row = new MoneyCard();
                row.Currency = "USD";
                row.Amount = "9.99 USD";

                // You can load images from your Resources
                // row.Icon = Properties.Resources.netflix_icon; 

                // Make it full width of the list
                row.Width = SubscriptionPanel.Width - 25;

                MoneyPanel.Controls.Add(row);
            }
        }
        private void LoadTransactionRows()
        {
            SubscriptionPanel.Controls.Clear();

            // Example loop
            for (int i = 0; i < 5; i++)
            {
                TransactionRow row = new TransactionRow();
                row.Title = "Netflix Subscription";
                row.Amount = "9.99 USD";

                // You can load images from your Resources
                // row.Icon = Properties.Resources.netflix_icon; 

                // Make it full width of the list
                row.Width = SubscriptionPanel.Width - 25;

                SubscriptionPanel.Controls.Add(row);
            }
        }
        private void DashboardControl_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            LoadTransactionRows();
            LoadMoneyCards();
            LoadWallets();
        }

        private void btAddWallet_Click(object sender, EventArgs e)
        {
            AddWalletForm addWalletForm = new AddWalletForm();
            
            addWalletForm.ShowDialog();
            LoadWallets();
            //load money cards again to reflect new wallet
        }
    }
}
