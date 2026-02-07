using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class TransactionRow : UserControl
    {
        private Label lblTitle;
        private Label lblAmount;
        private PictureBox pbIcon;

        public TransactionRow()
        {
            InitializeControls();

            // Add hover effect
            this.MouseEnter += (s, e) => this.BackColor = Color.FromArgb(50, 50, 50);
            this.MouseLeave += (s, e) => this.BackColor = Color.FromArgb(30, 30, 30);
        }

        // PROPERTIES to pass data in
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string Amount
        {
            get => lblAmount.Text;
            set => lblAmount.Text = value;
        }

        public Image Icon
        {
            get => pbIcon.Image;
            set => pbIcon.Image = value;
        }

        // Setup the layout manually so you don't have to fight the Designer
        private void InitializeControls()
        {
            this.Size = new Size(400, 50);
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Padding = new Padding(10); // Spacing from edges

            // 1. Amount (Right side)
            lblAmount = new Label();
            lblAmount.Text = "0.00 USD";
            lblAmount.ForeColor = Color.White;
            lblAmount.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblAmount.AutoSize = true;
            lblAmount.Dock = DockStyle.Right; // Sticks to right
            lblAmount.TextAlign = ContentAlignment.MiddleRight;

            // 2. Icon (Left side)
            pbIcon = new PictureBox();
            pbIcon.Size = new Size(30, 30);
            pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIcon.Dock = DockStyle.Left; // Sticks to left
                                          // Note: I'll add a paint event below to make it circular if you want!

            // 3. Title (Fills the middle)
            lblTitle = new Label();
            lblTitle.Text = "Transaction Name";
            lblTitle.ForeColor = Color.LightGray;
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblTitle.Dock = DockStyle.Fill; // Takes remaining space
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // Add a little left padding so text isn't touching the icon
            lblTitle.Padding = new Padding(10, 0, 0, 0);

            // Add controls in this specific order!
            // (Dock=Fill controls must be added LAST to work correctly)
            this.Controls.Add(lblTitle);   // 3
            this.Controls.Add(lblAmount);  // 1
            this.Controls.Add(pbIcon);     // 2
        }

        // Optional: Draw the icon as a circle (like the green checks in your image)
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // If you want a circle background for the icon area

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Brush b = new SolidBrush(Color.FromArgb(40, 40, 40)))
            {
                e.Graphics.FillEllipse(b, pbIcon.Left, pbIcon.Top, pbIcon.Width, pbIcon.Height);
            }
        }

        private void TransactionRow_Load(object sender, EventArgs e)
        {

        }
    }
}