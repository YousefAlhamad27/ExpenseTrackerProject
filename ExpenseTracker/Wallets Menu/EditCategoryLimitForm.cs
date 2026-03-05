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
    public partial class EditCategoryLimitForm : Form
    {

        public event EventHandler<EventArgs> catEdited;
        public event EventHandler<EventArgs> catDeleted;

        clsCategoryLimit _CategoryLimit;
        public EditCategoryLimitForm(int ID)
        {
            _CategoryLimit = clsCategoryLimit.GetCategoryLimit(ID);

            InitializeComponent();
            LoadAmount();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAmount()
        {
            txtCurrent.Text = _CategoryLimit.Amount.ToString();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewLimit.Text))
            {
                MessageBox.Show("Fill the limit fieled", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            clsCategoryLimit categoryLimit = new clsCategoryLimit
            {
                CategoryID = _CategoryLimit.CategoryID,
                CategoryLimitID = _CategoryLimit.CategoryLimitID,
                Amount = Convert.ToDecimal(txtNewLimit.Text),
            };
            _CategoryLimit = categoryLimit;
            if (categoryLimit.Save())
            {
                LoadAmount();

                MessageBox.Show("Limit saved sucessfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                catEdited?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                MessageBox.Show("Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }


        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this limit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (_CategoryLimit.Delete())
                {
                    MessageBox.Show("Category Limit Deleted Successfully!", "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    catDeleted?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to delete Category Limit.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                return;
            }
        }

        private void txtNewLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (txtNewLimit.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
