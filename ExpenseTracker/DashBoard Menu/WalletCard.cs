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
        public WalletCard()
        {
            InitializeComponent();
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
    }
}
