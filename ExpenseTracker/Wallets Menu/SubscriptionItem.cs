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
    public partial class SubscriptionItem : UserControl
    {
        private int _subscriptionId;
        public SubscriptionItem(int subscriptionId)
        {
            InitializeComponent();
            _subscriptionId = subscriptionId;
        }
        public void setText(string name)
        {
            lbText.Text = name;
        }
        public void setAmount(string amount)
        {
            lbAmount.Text = amount;
        }



        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(30, 30, 30);
        }
        private void DisposeControl(object sender,EventArgs e)
        {
            this.Dispose();
        }
        private void ReloadData(object sender,EventArgs e)
        {
            clsSubscription subscription = clsSubscription.GetByID(_subscriptionId);
            clsWallet wallet = clsWallet.GetWalletByID(subscription.WalletID);
            string currencyCode = clsCurrency.GetCurrencyCodeByID(wallet.CurrencyID);

            setAmount(((float)subscription.Amount).ToString() + " " + currencyCode);

            setText(subscription.Description!);
            lbPaid.Text = subscription.LastPaymentDate == null ? "Not Paid" : " Paid";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EditSubscriptionForm form = new EditSubscriptionForm(_subscriptionId);
            form.Deleted += DisposeControl;
            form.Edited+=ReloadData;
            form.ShowDialog();
        }
    }
}
