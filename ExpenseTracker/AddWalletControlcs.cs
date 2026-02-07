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
    public partial class AddWalletControlcs : UserControl
    {
       
        public AddWalletControlcs( )
        {
            InitializeComponent();
            
            LoadCurrencies();
        }

        private void LoadCurrencies() {

            List<clsCurrency> currencies = clsCurrency.GetAllCurrencies();
          
            comboBox1.Items.Clear();
            foreach (var currency in currencies)
            {
                comboBox1.Items.Add(currency.Code);
            }
            comboBox1.SelectedIndex = 0; // Select the first currency by default
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private bool isEligibleForSave()
        {
            if (string.IsNullOrWhiteSpace(txtBalance.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                return false;
            }
            try
            {
                
                float amount = float.Parse(txtBalance.Text);
                if (amount <= 0)
                {
                    return false;
                }
                return true;
            }
            catch

            {
                return false;
            }
            
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            if(!isEligibleForSave())
            {
                MessageBox.Show("Please enter valid data","Invalid Data",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            double balance = double.Parse(txtBalance.Text);
            string name=txtName.Text.Trim();
            int currencyID = comboBox1.SelectedIndex+1;
            clsWallet wallet=new clsWallet(0,txtName.Text.Trim(),Convert.ToDecimal(balance), currencyID, DateTime.Now);
            

            if (!wallet.Save())
                {
                MessageBox.Show("Failed to add wallet","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Wallet Added Successfully!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
