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
    public partial class TransactionsPanel : UserControl
    {
        public TransactionsPanel()
        {
            InitializeComponent();
           // LoadTransactionRows();
            
        }
        public string setDate
        {
            get { return lbDate.Text; }
            set { lbDate.Text = value; }
        }
        public void AddTransactionRow(clsTransaction transaction)
        {
             

           
                TransactionItem item = new TransactionItem(transaction.TransactionID);

                clsWallet wallet = clsWallet.GetWalletByID(transaction.WalletID)!;
                if (wallet.CurrencyID != 1)
                {
                    clsCurrency currency = clsCurrency.GetCurrencyByID(wallet.CurrencyID);

                    item.Amount = ((float)transaction.Amount) + " " + currency.Code;
                }
                else

                    item.Amount = $"{(float)transaction.Amount} USD";
                clsCategory category = clsCategory.GetCategory(transaction.CategoryID);

                item.Title = category.CategoryName;
                item.Icon = Properties.Resources.Forggy1;
            item.Width= flowLayoutPanel2.Width - 40;
            flowLayoutPanel2.Controls.Add(item);

        }


        public void LoadTransactionRows(List<clsTransaction> transactions)
        {
             

            // Example loop
           

                // You can load images from your Resources
                // row.Icon = Properties.Resources.netflix_icon; 

                // Make it full width of the list



            }
        }
    
}
