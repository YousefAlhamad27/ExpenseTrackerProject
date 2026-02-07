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


    public partial class TransactionItem : UserControl
    {
        public TransactionItem()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(30, 30, 30);
            // UX Polish: Make the whole row change color when you hover over it
            this.MouseEnter += (s, e) => this.BackColor = Color.FromArgb(40, 40, 40);
            this.MouseLeave += (s, e) => this.BackColor = Color.FromArgb(30, 30, 30); // Or your default color
        }

        // 1. Title Property
        public string Title
        {
            get { return lbCategory.Text; }
            set { lbCategory.Text = value; }
        }

        // 2. Amount Property
        public string Amount
        {
            get { return lbAmount.Text; }
            set { lbAmount.Text = value; }
        }

        // 3. Icon Property
        public Image Icon
        {
            get { return pictureBox2.Image; }
            set { pictureBox2.Image = value; }
        }

        // 4. Data Property (Hidden ID)
        // Useful for knowing WHICH transaction this is (e.g., ID 105)
        public int TransactionId { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }
    }
}
