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
    public partial class AddTransactionForm : Form
    {
        private TransferControl transferControl = new TransferControl();
        private IncomeExpenseControl incomeControl = new IncomeExpenseControl(IncomeExpenseControl.TransactionType.Income);
        private IncomeExpenseControl expenseControl = new IncomeExpenseControl(IncomeExpenseControl.TransactionType.Expense);
        private short currentIndex = 0;

        public AddTransactionForm()
        {
            InitializeComponent();
            LoadControls();
        }
        private void LoadControls()
        {
            panel1.Controls.Add(expenseControl);
            panel1.Controls.Add(incomeControl);
            panel1.Controls.Add(transferControl);
            incomeControl.Dock = DockStyle.Fill;
            expenseControl.Dock = DockStyle.Fill;
            transferControl.Dock = DockStyle.Fill;

            incomeControl.Visible = false;
            expenseControl.Visible = true;
            transferControl.Visible = false;
        }

        private void segmentedControl1_Click(object sender, EventArgs e)
        {
            if (segmentedControl1.SelectedIndex == 0)
            {
                if (currentIndex == 0)
                    return;
                expenseControl.Visible = true;
                incomeControl.Visible = false;
                transferControl.Visible = false;
                currentIndex = 0;

            }
            else if (segmentedControl1.SelectedIndex == 1)
            {
                if (currentIndex == 1)
                    return;
                expenseControl.Visible = false;
                incomeControl.Visible = true;
                transferControl.Visible = false;
                currentIndex = 1;
            }
            else if (segmentedControl1.SelectedIndex == 2)
            {
                if (currentIndex == 2)
                    return;
                expenseControl.Visible = false;
                incomeControl.Visible = false;
                transferControl.Visible = true;
                currentIndex = 2;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
