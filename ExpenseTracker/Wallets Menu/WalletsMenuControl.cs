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

namespace ExpenseTracker.Wallets_Menu
{
    public partial class WalletsMenuControl : UserControl
    {
        public WalletsMenuControl()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }


        public void LoadTransactionRows()
        {


            // Example loop
            for (int i = 0; i < 5; i++)
            {
                TransactionsPanel row = new TransactionsPanel();
                row.Width = TransactionsFlowLayoutPanel.Width - 25;


                // You can load images from your Resources
                // row.Icon = Properties.Resources.netflix_icon; 

                // Make it full width of the list

                TransactionsFlowLayoutPanel.Controls.Add(row);

            }
        }
        private void LoadSubscriptionsRows()
        {
            for (int i = 0; i < 2; i++)
            {
                SubscriptionItem row = new SubscriptionItem();
                row.setAmount("$15.00");
                row.setText("Netflix");
                row.Width = SubscriptionsFlow.Width - 25;
                // You can load images from your Resources
                // row.Icon = Properties.Resources.netflix_icon; 
                // Make it full width of the list
                SubscriptionsFlow.Controls.Add(row);
            }


        }
        private void LoadCategoriesLimits()
        {
            for (int i = 0; i < 2; i++)
            {
                CategoryLimitControl row = new CategoryLimitControl();
                row.setAmount("$150.00");
                row.setText("Entertainment");
                row.setProgress(70);
                row.setMode(CategoryLimitControl.eStatus.Left);
                row.Width = CategoriesLimitsFlow.Width - 25;

                // You can load images from your Resources
                // row.Icon = Properties.Resources.netflix_icon; 

                // Make it full width of the list

                CategoriesLimitsFlow.Controls.Add(row);

            }
        }
        private void setRectanglesValues()
        {
            multiUseRectangle1.setBigText("10 Days");
            multiUseRectangle2.setBigText("451.41 USD");

            multiUseRectangle1.setText("Days Before Salary");
            multiUseRectangle2.setText("Expected Balance");
        }
        private void WalletsMenuControl_Load(object sender, EventArgs e)
        {
            setRectanglesValues();
            LoadTransactionRows();
            LoadCategoriesLimits();
            LoadSubscriptionsRows();
        }

        private void lbAddLimit_Click(object sender, EventArgs e)
        {

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

        private void lbAddSubscription_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            AddTransactionForm form = new AddTransactionForm();
            form.ShowDialog();
        }

        private void lbAddSubscription_Click_1(object sender, EventArgs e)
        {
            AddSubscriptionForm form = new AddSubscriptionForm();
            form.ShowDialog();
        }

        private void lbAddLimit_Click_1(object sender, EventArgs e)
        {
            AddCategoryForm form = new AddCategoryForm();
            form.ShowDialog();
        }
    }
}
