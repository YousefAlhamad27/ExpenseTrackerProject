using ExpenseTracker.Wallets_Menu;
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
    public partial class EditTransactionForm : Form
    {
        private int transactionID;

        public enum eTransactionType
        {
            Income = 2,
            Expense = 1,
            Transfer = 3
        }

        private TransferControl transferControl;
        private IncomeExpenseControl expenseControl;
        private IncomeExpenseControl incomeControl;
        clsTransaction transaction;
        eTransactionType currentType;

        public EditTransactionForm(int transactionID)
        {
            InitializeComponent();

            this.transactionID = transactionID;
            transaction = clsTransaction.GetTransaction(transactionID);
            currentType = (eTransactionType)transaction.TransactionTypeID;
            LoadControl();


        }

        private void LoadControl()
        {
            if (currentType == eTransactionType.Transfer)
            {
                clsTransfer transfer = clsTransfer.getTransferByTransID(transactionID);

                transferControl = new TransferControl(transfer.SourceWalletID, transactionID, transfer.DestinationWalletID, TransferControl.eMode.Edit);
                transferControl.Dock = DockStyle.Fill;
                transferControl.Width = panel1.Width;
                transferControl.Visible = true;
                panel1.Controls.Add(transferControl);


            }

            else if (currentType == eTransactionType.Expense)
            {
                expenseControl = new IncomeExpenseControl(IncomeExpenseControl.TransactionType.Expense, transaction.WalletID,IncomeExpenseControl.eMode.Edit,transactionID);
                expenseControl.Visible = true;
                expenseControl.Dock = DockStyle.Fill;
                expenseControl.Width = panel1.Width;
                panel1.Controls.Add(expenseControl);
            }
            else
            {
                incomeControl = new IncomeExpenseControl(IncomeExpenseControl.TransactionType.Income, transaction.WalletID, IncomeExpenseControl.eMode.Edit, transactionID);
                incomeControl.Dock = DockStyle.Fill;
                incomeControl.Visible = true;
                incomeControl.Width = panel1.Width;
                panel1.Controls.Add(incomeControl);
            }
            panel1.Controls[0].Visible = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save changes?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = false;
                if (currentType == eTransactionType.Transfer)
                {
                    clsTransfer transfer = clsTransfer.getTransferByTransID(transactionID);
                    success = transfer.DeleteTransfer() && transaction.Delete();

                }

                else
                {
                    success = transaction.Delete();
                }
                if (success)
                {
                    MessageBox.Show("Transaction updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update transaction. Please check your inputs and try again.");
                }
            }
            return;
        }
    }
}
