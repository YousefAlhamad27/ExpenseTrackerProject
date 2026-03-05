using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerBussinessLogic;

namespace ExpenseTracker.Wallets_Menu
{
    public partial class WalletsMenuControl : UserControl
    {
        private int _CurrentWalletIndex = 0;
        List<clsWallet> wallets = clsWallet.GetAllWallets();

        public void RefreshWallets()
        {
            wallets = clsWallet.GetAllWallets();
        }
        public WalletsMenuControl()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            SetToolTip();
        }
        private void changeWalletTitle(string title)
        {
            lbWalletName.Text = title;
        }
        public async Task ShowWallet(int walletID)
        {

            for (int i = 0; i < wallets.Count; i++)
            {
                if (wallets[i].WalletID == walletID)
                {
                    _CurrentWalletIndex = i;
                    break;
                }
            }

            changeWalletTitle(wallets[_CurrentWalletIndex].Name);
            LoadTransactionRows();

        }
        private void MoveToNextWallet()
        {

            _CurrentWalletIndex++;
            if (_CurrentWalletIndex == wallets.Count)
                _CurrentWalletIndex = 0;
            changeWalletTitle(wallets[_CurrentWalletIndex].Name);
            LoadTransactionRows();
            setExpectedBalance();


        }
        private void LoadCategoryLimits()
        {
            CategoriesLimitsFlow.Controls.Clear();

            List<clsCategoryLimit> limits = clsCategoryLimit.GetAllCategoryLimits();

            foreach (clsCategoryLimit limit in limits)
            {
                clsCategory category = clsCategory.GetCategory(limit.CategoryID);
                CategoryLimitControl row = new CategoryLimitControl(limit.CategoryLimitID);

                row.setText(category.CategoryName);
                double remainingAmount = clsCategoryLimit.GetRemainingAmount(limit.CategoryLimitID);

                if (remainingAmount < 0)
                {
                    row.setRemaining("LIMIT EXCEEDED", Color.Red);

                }
                row.setAmount(((float)remainingAmount).ToString() + " USD");
                row.setProgress(clsUtil.ComputeLimitProgressBar(limit.CategoryID, (float)limit.Amount));

                row.Width = CategoriesLimitsFlow.Width - 25;


                CategoriesLimitsFlow.Controls.Add(row);
            }

        }

        private void SetToolTip()
        {

            ToolTip.SetToolTip(lbAddLimit, "Add a new category limit.");
            ToolTip.SetToolTip(lbAddSubscription, "Add a new subscription.");
            ToolTip.SetToolTip(btAddTransaction, "Add a new transaction.");
            ToolTip.SetToolTip(btNext, "Jump to next wallet.");
            ToolTip.SetToolTip(btRemoveWallet, "Remove this wallet.");

        }
        private int GetWalletID()
        {

            return wallets[_CurrentWalletIndex].WalletID;

        }

        public void LoadTransactionRows()
        {
            TransactionsFlowLayoutPanel.Controls.Clear();
            List<clsTransaction> transactions = clsTransaction.GetAll30Days(wallets[_CurrentWalletIndex].WalletID);

            if (transactions.Count == 0)
            {
                System.Windows.Forms.Label noTransactionsLabel = new System.Windows.Forms.Label();
                noTransactionsLabel.AutoSize = true;
                noTransactionsLabel.Text = "No transactions in the last 30 days.";
                noTransactionsLabel.ForeColor = Color.Gray;
                noTransactionsLabel.Font = new Font("Segoe UI", 10, FontStyle.Italic);
                TransactionsFlowLayoutPanel.Controls.Add(noTransactionsLabel);
                return;
            }


            transactions.Sort((x, y) => y.Date.CompareTo(x.Date));


            TransactionsPanel row = new TransactionsPanel();


            DateTime currentDate = DateTime.Now;
            foreach (clsTransaction transaction in transactions)
            {
                row.Width = TransactionsFlowLayoutPanel.Width - 25;

                if (transaction.Date.Day == currentDate.Day && transaction.Date.Month == currentDate.Month && transaction.Date.Year == currentDate.Year)
                {
                    row.setDate = transaction.Date.ToString("yyyy-MM-dd");
                    row.AddTransactionRow(transaction);
                    currentDate = transaction.Date;
                    TransactionsFlowLayoutPanel.Controls.Add(row);
                }

                else
                {
                    row = new TransactionsPanel();
                    row.Width = TransactionsFlowLayoutPanel.Width - 25;
                    row.setDate = transaction.Date.ToString("yyyy-MM-dd");
                    currentDate = transaction.Date;
                    row.AddTransactionRow(transaction);
                    TransactionsFlowLayoutPanel.Controls.Add(row);
                }


            }
        }
        private void LoadSubscriptionsRows()
        {
            SubscriptionsFlow.Controls.Clear();
            List<clsSubscription> subscriptions = clsSubscription.GetAll();

            foreach (clsSubscription subscription in subscriptions)
            {
                clsWallet wallet = clsWallet.GetWalletByID(subscription.WalletID);
                if (wallet == null)
                    continue;
                string currencyCode = clsCurrency.GetCurrencyCodeByID(wallet.CurrencyID);
                SubscriptionItem row = new SubscriptionItem(subscription.SubscriptionID);

                row.setAmount(((float)subscription.Amount).ToString() + $" {currencyCode}");
                row.setText(subscription.Description);
                row.Width = SubscriptionsFlow.Width - 25;

                SubscriptionsFlow.Controls.Add(row);
            }


        }

        private void setExpectedBalance()
        {

            multiUseRectangle2.setText("Expected Balance");
            string currencyCode = clsCurrency.GetCurrencyCodeByID(wallets[_CurrentWalletIndex].CurrencyID);

            multiUseRectangle2.setBigText($"{(float)clsWallet.GetExpectedBalance(wallets[_CurrentWalletIndex].WalletID, clsUtil.GetLastSalaryDate(clsSettings.GetSalaryDay()))} {currencyCode}");

        }
        private void setRemainingForSalaryDay()
        {
            DateTime nextSalaryDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 2);

            multiUseRectangle1.setBigText($"{Math.Ceiling(Math.Abs((DateTime.Now - nextSalaryDate).TotalDays))} Days");


            multiUseRectangle1.setText("Days Before Salary");

        }
        private void WalletsMenuControl_Load(object sender, EventArgs e)
        {
            GetWalletID();
            setRemainingForSalaryDay();
            setExpectedBalance();
            LoadTransactionRows();
            LoadCategoryLimits();
            LoadSubscriptionsRows();

        }
        private void lbAddLimit_MouseHover(object sender, EventArgs e)
        {

            lbAddLimit.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void lbAddSubscription_MouseHover(object sender, EventArgs e)
        {
            lbAddSubscription.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void lbAddSubscription_MouseLeave(object sender, EventArgs e)
        {
            lbAddSubscription.BackColor = Color.Transparent;
        }

        private void lbAddLimit_MouseLeave(object sender, EventArgs e)
        {
            lbAddLimit.BackColor = Color.Transparent;
        }

        private void RefreshWalletControl()
        {
            setExpectedBalance();
            LoadTransactionRows();
            LoadCategoryLimits();
            LoadSubscriptionsRows();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            AddTransactionForm form = new AddTransactionForm(wallets[_CurrentWalletIndex].WalletID);
            form.ShowDialog();
            RefreshWalletControl();
        }

        private void lbAddSubscription_Click_1(object sender, EventArgs e)
        {
            AddSubscriptionForm form = new AddSubscriptionForm(wallets[_CurrentWalletIndex].WalletID, AddSubscriptionForm.OperationMode.Add);
            form.ShowDialog();
            RefreshWalletControl();
        }

        private void lbAddLimit_Click_1(object sender, EventArgs e)
        {
            AddCategoryLimitForm form = new AddCategoryLimitForm();
            form.ShowDialog();
            LoadCategoryLimits();
        }

        private void TransactionsFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            MoveToNextWallet();

        }

        private void btRemoveWallet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this wallet? This action cannot be undone.", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                clsWallet wallet = clsWallet.GetWalletByID(wallets[_CurrentWalletIndex].WalletID)!;
                if (wallet.DeleteWallet())
                {
                    MessageBox.Show("Wallet removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wallets.RemoveAt(_CurrentWalletIndex);
                    _CurrentWalletIndex--;
                }
                else {


                    if (wallet.RemoveWallet())
                    {
                        MessageBox.Show("Wallet removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wallets.RemoveAt(_CurrentWalletIndex);
                        _CurrentWalletIndex--;
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove wallet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                

                }

                if (wallets.Count == 0)
                {

                    TransactionsFlowLayoutPanel.Controls.Clear();
                    CategoriesLimitsFlow.Controls.Clear();
                    SubscriptionsFlow.Controls.Clear();
                    multiUseRectangle1.setBigText("-");
                    multiUseRectangle2.setBigText("-");
                }
                else
                {
                    RefreshWallets();
                    MoveToNextWallet();
                    RefreshWalletControl();
                  
                }
            }
        }
    }
}
