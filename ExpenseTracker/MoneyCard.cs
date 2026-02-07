using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class MoneyCard : Control
    {
        // Properties
        private string _amount = "0.00";
        private string _currency = "USD";
        
        // Colors from your screenshot
        private Color _cardColor = Color.FromArgb(25, 25, 25); // Very dark grey
        private Color _textColor = Color.White;
        private Color _currencyColor = Color.LightGray;

        public MoneyCard()
        {
            // Optimize painting for smooth edges
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            
            this.Size = new Size(300, 60); // Default size
        }

        // Data Properties
        public string Amount
        {
            get => _amount;
            set { _amount = value; Invalidate(); } // Redraw when changed
        }

        public string Currency
        {
            get => _currency;
            set { _currency = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 1. Draw the Rounded Background (Pill Shape)
            using (var path = GetRoundedPath(new Rectangle(0, 0, this.Width - 1, this.Height - 1), 25)) // 25 is the curve radius
            using (var brush = new SolidBrush(_cardColor))
            {
                g.FillPath(brush, path);
            }

            // 2. Draw Amount (Left aligned)
            using (var font = new Font("Segoe UI", 14, FontStyle.Bold))
            using (var brush = new SolidBrush(_textColor))
            {
                // Draw at x=20, y=Center
                float yPos = (this.Height - font.Height) / 2;
                g.DrawString(_amount, font, brush, 20, yPos);
            }

            // 3. Draw Currency (Right aligned)
            using (var font = new Font("Segoe UI", 12, FontStyle.Bold))
            using (var brush = new SolidBrush(_currencyColor))
            {
                // Measure text so we know where to start drawing from the right
                SizeF textSize = g.MeasureString(_currency, font);
                float xPos = this.Width - textSize.Width - 20; // 20px padding from right
                float yPos = (this.Height - font.Height) / 2;
                
                g.DrawString(_currency, font, brush, xPos, yPos);
            }
        }

        // Helper for rounded corners
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
    }
}