using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Wallets_Menu
{
    public partial class TransactionsPanel : UserControl
    {
        public TransactionsPanel()
        {
            InitializeComponent();
            LoadTransactionRows();
            lbDate.Text = "2024-06-15";
        }

       
        public void LoadTransactionRows()
        {
             

            // Example loop
            for (int i = 0; i < 5; i++)
            {
                TransactionItem item= new TransactionItem();

                item.Amount = "9.99 USD";
                item.Title = "Netflix Subscription";
                item.Icon= Properties.Resources.Forggy1;

                // You can load images from your Resources
                // row.Icon = Properties.Resources.netflix_icon; 

                // Make it full width of the list



            }
        }
    }
}
