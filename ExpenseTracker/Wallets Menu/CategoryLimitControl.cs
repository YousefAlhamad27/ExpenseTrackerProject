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
    public partial class CategoryLimitControl : UserControl
    {
        public int ID { get; set; }
        public enum eStatus
        {
            Left = 1,
            Over = 2
        }
        public CategoryLimitControl()
        {
            InitializeComponent();
        }

        public void setMode(eStatus status)
        {
            switch (status)
            {
                case eStatus.Left:
                    label2.Text = "Left";
                    progressBar1.ForeColor = Color.White;
                    break;
                case eStatus.Over:
                    label2.Text = "Over";
                    progressBar1.ForeColor = Color.DarkRed;
                    break;
            }
        }

        public void setAmount(string amount)
        {
            lbAmount.Text = amount;
        }
        public void setText(string text)
        {
            label1.Text = text;
        }

        public void setProgress(int percent)
        {
            progressBar1.Value = percent;
        }
        public void setColor(Color color)
        {
            progressBar1.ForeColor = color;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            EditCategoryLimitForm editForm = new EditCategoryLimitForm(1);
            editForm.ShowDialog();

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
           label3.BackColor = Color.FromArgb(60, 60, 60);
           // label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;

        }
    }
}
