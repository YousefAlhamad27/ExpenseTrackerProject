using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class AddWalletForm : Form
    {
        public event EventHandler<EventArgs> WalletAdded;
        public AddWalletForm()
        {
            InitializeComponent();
            addWalletControlcs1.WalletAdded += (s, e) => WalletAdded?.Invoke(s, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
