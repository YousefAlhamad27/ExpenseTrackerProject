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
    public partial class IncomeExpenseControl : UserControl
    {
        public enum TransactionType
        {
            Income,
            Expense
        }

        TransactionType currentType;
        public IncomeExpenseControl(TransactionType currentType)
        {
            InitializeComponent();
            this.currentType = currentType;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
