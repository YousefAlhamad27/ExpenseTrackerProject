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
        public event EventHandler<int> WalletCardClicked;
        public event EventHandler<EventArgs> WalletAdded;
        public DashboardControl()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            
            toolTip.SetToolTip(pictureBox1, "Refresh Dashboard.");
            toolTip.SetToolTip(btAddWallet,"Add new wallet.");
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadWallets()
        {
            WalletsLayoutPanel.Controls.Clear();
            List<clsWallet> wallets = clsWallet.GetAllWallets();

            foreach (clsWallet wallet in wallets)
            {
                WalletCard card = new WalletCard(wallet.WalletID);
                card.Click += (s, e) => WalletCardClicked?.Invoke(s, wallet.WalletID);

                card.WalletName = wallet.Name;

                //card.WalletName = "Wallet" + DateTime.Now.Ticks;
                string currencyCode = clsCurrency.GetCurrencyCodeByID(wallet.CurrencyID);
                card.WalletBalance = ((float)wallet.Balance).ToString("F2") + " " + currencyCode;


                WalletsLayoutPanel.Controls.Add(card);
            }

        }
        private void LoadTransactions()
        {
            flowLayoutPanel1.Controls.Clear();



           

            List<clsTransaction> transactions = clsTransaction.GetAllTransactions();
            foreach (clsTransaction transaction in transactions)
            {
                TransactionItem item = new TransactionItem(transaction.TransactionID);
                item.Title = transaction.Description;
                clsWallet wallet = clsWallet.GetWalletByID(transaction.WalletID);
                string currencyCode = clsCurrency.GetCurrencyCodeByID(wallet.CurrencyID);

                item.Amount = ((float)transaction.Amount).ToString() + " " + currencyCode;
                item.Width = flowLayoutPanel1.Width - 40;
                flowLayoutPanel1.Controls.Add(item);
            }



            
        }

        private void LoadMoneyCards()
        {
            MoneyPanel.Controls.Clear();
            List<clsWallet> wallets = clsWallet.GetAllWallets();

           
            foreach (clsWallet wallet in wallets)
            {
                string currencyCode = clsCurrency.GetCurrencyCodeByID(wallet.CurrencyID);

                if (MoneyPanel.Controls.Count==0)
                {
                    MoneyCard row = new MoneyCard();
                    row.Currency = currencyCode ;
                    row.Amount = $"{(float)wallet.Balance}";
                    row.Width = SubscriptionPanel.Width - 25;

                    MoneyPanel.Controls.Add(row);
                    continue;
                }
                foreach (MoneyCard card in MoneyPanel.Controls.OfType<MoneyCard>())
                {
                    if (card.Currency == currencyCode)
                    {
                        card.Amount = ((Convert.ToDecimal(card.Amount) +wallet.Balance)).ToString();
                        break;
                    }
                    else
                    {
                        MoneyCard row = new MoneyCard();
                        row.Currency = currencyCode;
                        row.Amount = $"{(float)wallet.Balance}";
                        row.Width = SubscriptionPanel.Width - 25;
                        MoneyPanel.Controls.Add(row);
                        break;
                    }
                }

                

               
                
            }
        }
        private void LoadSubscriptionRows()
        {
            SubscriptionPanel.Controls.Clear();
            List<clsSubscription> subscriptions = clsSubscription.GetAll();

            foreach (clsSubscription subscription in subscriptions)
            {
                clsWallet wallet = clsWallet.GetWalletByID(subscription.WalletID);
                string currencyCode = clsCurrency.GetCurrencyCodeByID(wallet.CurrencyID);


                SubscriptionRow row = new SubscriptionRow();
                row.Title = subscription.Description;
                row.Amount = $"{(float)subscription.Amount} {currencyCode}";

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
            LoadSubscriptionRows();
            LoadMoneyCards();
            LoadWallets();
        }


        private void btAddWallet_Click(object sender, EventArgs e)
        {
            AddWalletForm addWalletForm = new AddWalletForm();
            addWalletForm.WalletAdded += (s, args) => WalletAdded?.Invoke(s, args);
            addWalletForm.ShowDialog();
            LoadWallets();
            LoadMoneyCards();
        }
        private void RefreshData()
        {
            LoadTransactions();
            LoadSubscriptionRows();
            LoadMoneyCards();
            LoadWallets();
        }
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
