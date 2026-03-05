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
   
    public partial class CategoryLimitControl : UserControl
    {
        

        private int ID { get; set; }
        public enum eStatus
        {
            Left = 1,
            Over = 2
        }
        public CategoryLimitControl(int id)
        {
            ID = id;
            InitializeComponent();
           
        }

        public void setMode(eStatus status)
        {
            switch (status)
            {
                case eStatus.Left:
                    lbRemaining.Text = "Left";
                    progressBar1.ForeColor = Color.White;
                    break;
                case eStatus.Over:
                    lbRemaining.Text = "Over";
                    progressBar1.ForeColor = Color.DarkRed;
                    break;
            }
        }
        public void setRemaining(string remaining,Color color)
        {
            lbRemaining.Text = remaining;
            if (color == Color.Red)
            {
                lbRemaining.ForeColor = Color.Red;
               
            }
            else
                lbRemaining.ForeColor = Color.FromKnownColor(KnownColor.ControlLight);

                
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
            EditCategoryLimitForm editForm = new EditCategoryLimitForm(ID);
            editForm.catEdited += ReloadCategoryLimit!;
            editForm.catDeleted += DeleteControl!;
            editForm.ShowDialog();

        }
        private void DeleteControl(object sender,EventArgs e)
        {
            this.Dispose();
        }
        private void ReloadCategoryLimit(object sender,EventArgs e ){

            clsCategoryLimit newLimit = clsCategoryLimit.GetCategoryLimit(ID);

            setProgress(clsUtil.ComputeLimitProgressBar(newLimit.CategoryID,(double)newLimit.Amount));
            setAmount(newLimit.Amount.ToString());
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
