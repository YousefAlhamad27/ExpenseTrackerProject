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
    public partial class AddCategoryLimitForm : Form
    {
        public AddCategoryLimitForm()
        {
            InitializeComponent();
            LoadCategories();
        }
        private void LoadCategories()
        {
            List<clsCategory> categories = clsCategory.GetAllCategories();

            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.SelectedIndex = 0;
            comboBox1.ValueMember = "CategoryID";
        }
        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool AddCategoryLimit()
        {
            clsCategoryLimit limit = new clsCategoryLimit
            {
                Amount = decimal.Parse(txtAmount.Text.Split(" ")[0]),
                CategoryID = (int)comboBox1.SelectedValue!,
               
            };
            return limit.Save();
        }
        private bool IsEligibleForSave()
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                return false;
            }
            if (comboBox1.SelectedItem == null)
            {
                return false;
            }
            return true;
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and a single decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Only allow one decimal point
            if (e.KeyChar == '.' && (txtAmount.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {

            if (!IsEligibleForSave())
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AddCategoryLimit())
            {
                MessageBox.Show("Category limit added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add category limit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
