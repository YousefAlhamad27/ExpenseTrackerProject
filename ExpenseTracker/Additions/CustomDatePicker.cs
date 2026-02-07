using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public class CustomDatePicker : UserControl
    {
        // UI Components
        private Label lblDate;
        private PictureBox pbIcon;
        private Panel pnlDivider;
        private DateTimePicker dtpBacking; // The hidden "Real" calendar

        // Colors
        private Color _borderColor = Color.FromArgb(60, 60, 60);
        private Color _backColor = Color.Black;
        private Color _textColor = Color.White;

        // Events
        public event EventHandler DateChanged;

        public CustomDatePicker()
        {
            this.Size = new Size(250, 45);
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.Transparent; // Important for rounded corners

            InitializeControls();
        }

        // --- Properties ---
        public DateTime Value
        {
            get => dtpBacking.Value;
            set
            {
                dtpBacking.Value = value;
                UpdateLabel();
            }
        }

        public Image Icon
        {
            get => pbIcon.Image;
            set => pbIcon.Image = File.Exists("selection-date-1.png" ?? "") ? Image.FromFile("selection-date-1.png"!) : value;
        }

        // --- Setup UI ---
        private void InitializeControls()
        {
            // 1. The Hidden DateTimePicker
            dtpBacking = new DateTimePicker();
            dtpBacking.Width = 0; // Hide it visually
            dtpBacking.ValueChanged += (s, e) => {
                UpdateLabel();
                DateChanged?.Invoke(this, EventArgs.Empty);
            };
            this.Controls.Add(dtpBacking);

            // 2. The Calendar Icon (Right)
            pbIcon = new PictureBox();
            pbIcon.Size = new Size(24, 24);
            pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIcon.Dock = DockStyle.Right;
            pbIcon.Cursor = Cursors.Hand;
            // Add a little padding to the right
            Panel pnlIconContainer = new Panel();
            pnlIconContainer.Width = 40;
            pnlIconContainer.Dock = DockStyle.Right;
            pnlIconContainer.Padding = new Padding(8);
            pnlIconContainer.Controls.Add(pbIcon);
            pnlIconContainer.Click += OpenCalendar; // Click triggers calendar
            pbIcon.Click += OpenCalendar;

            // 3. The Vertical Divider Line
            pnlDivider = new Panel();
            pnlDivider.Width = 1;
            pnlDivider.BackColor = Color.FromArgb(60, 60, 60);
            pnlDivider.Dock = DockStyle.Right;

            // 4. The Date Label (Left - Fill)
            lblDate = new Label();
            lblDate.Text = "Today";
            lblDate.ForeColor = _textColor;
            lblDate.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            lblDate.Dock = DockStyle.Fill;
            lblDate.Padding = new Padding(10, 0, 0, 0); // Left padding
            lblDate.Click += OpenCalendar; // Click triggers calendar

            // Add Controls (Order matters for Docking)
            this.Controls.Add(lblDate);          // Fill rest
            this.Controls.Add(pnlDivider);       // Line
            this.Controls.Add(pnlIconContainer); // Right Icon
        }

        // --- Logic ---

        private void UpdateLabel()
        {
            if (dtpBacking.Value.Date == DateTime.Today)
            {
                lblDate.Text = "Today";
            }
            else
            {
                // Format: "Jan 15, 2026"
                lblDate.Text = dtpBacking.Value.ToString("MMM dd, yyyy");
            }
        }

        // The Magic Trick: Programmatically open the hidden DTP
        private void OpenCalendar(object sender, EventArgs e)
        {
            // This forces the hidden standard calendar to pop up
            SendMessage(dtpBacking.Handle, WM_SYSKEYDOWN, VK_DOWN, 0);
        }

        // --- Drawing (Rounded Borders) ---
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw Background & Border
            using (var path = GetRoundedPath(new Rectangle(0, 0, this.Width - 1, this.Height - 1), 10))
            using (var brush = new SolidBrush(_backColor))
            using (var pen = new Pen(_borderColor))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // --- Native Windows Magic to open Calendar ---
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private const int WM_SYSKEYDOWN = 0x0104;
        private const int VK_DOWN = 0x28;
    }
}