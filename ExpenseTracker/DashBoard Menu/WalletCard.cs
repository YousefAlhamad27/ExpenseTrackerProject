using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.DashBoard_Menu
{


    public partial class WalletCard : UserControl
    {
        public event EventHandler<int> CardClicked;
        private int _walletID;
        public WalletCard(int walletID)
        {
            InitializeComponent();
            _walletID = walletID;
            toolTip1.SetToolTip(this, "Navigate To Wallet");
        }
        public string WalletName
        {

            get { return lbName.Text; }
            set { lbName.Text = value; }
        }
        public string WalletBalance
        {
            get { return lbAmount.Text; }
            set { lbAmount.Text = value; }
        }

        private void WalletCard_MouseEnter(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, _walletID);
        }

        private void WalletCard_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void WalletCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor= Color.FromArgb(30, 30, 30);
        }
    }
}
