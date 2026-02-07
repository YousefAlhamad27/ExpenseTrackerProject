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
    public partial class SubscriptionItem : UserControl
    {
        public SubscriptionItem()
        {
            InitializeComponent();
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
    }
}
