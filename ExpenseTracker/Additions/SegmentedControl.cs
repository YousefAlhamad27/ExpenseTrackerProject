using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Windows.Forms;

 namespace ExpenseTracker
{
    public class SegmentedControl : Control
    {
        private List<string> _items = new List<string> { "Expense", "Income", "Transfer" };
        private int _selectedIndex = 1;

        // Animation variables
        private float _currentX; // Where the pill IS right now
        private float _targetX;  // Where the pill WANTS to go
        private System.Windows.Forms.Timer _animTimer;

        // Colors
        private Color _backColor = Color.FromArgb(30, 30, 30);
        private Color _selectionColor = Color.FromArgb(80, 80, 80);
        private Color _textColor = Color.Gray;
        private Color _selectedTextColor = Color.White;

        public event EventHandler SelectedIndexChanged;

        public SegmentedControl()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.Height = 40;
            this.Width = 300;
            this.Cursor = Cursors.Hand;

            // Initialize Animation Timer
            _animTimer = new System.Windows.Forms.Timer();
            _animTimer.Interval = 15; // Speed (lower is smoother/faster updates)
            _animTimer.Tick += AnimTimer_Tick;
        }

        public List<string> Items
        {
            get => _items;
            set
            {
                _items = value;
                Invalidate();
            }
        }

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if (value >= 0 && value < _items.Count)
                {
                    _selectedIndex = value;

                    // Calculate where the pill should go
                    float segmentWidth = (float)this.Width / _items.Count;
                    _targetX = _selectedIndex * segmentWidth;

                    // Start the animation
                    _animTimer.Start();

                    SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            // Simple "Lerp" (Linear Interpolation) for smooth slowing down effect
            // Move 20% of the remaining distance per tick
            float speed = 0.2f;

            _currentX += (_targetX - _currentX) * speed;

            // If we are very close to the target, snap to it and stop timer to save CPU
            if (Math.Abs(_targetX - _currentX) < 0.5)
            {
                _currentX = _targetX;
                _animTimer.Stop();
            }

            Invalidate(); // Redraw with new position
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 1. Draw Background
            using (var path = GetRoundedPath(ClientRectangle, this.Height))
            using (var brush = new SolidBrush(_backColor))
            {
                g.FillPath(brush, path);
            }

            if (_items.Count == 0) return;

            float segmentWidth = (float)this.Width / _items.Count;

            // Handle initial load case (if timer hasn't run yet)
            if (!_animTimer.Enabled && _currentX == 0 && _selectedIndex > 0)
            {
                _currentX = _selectedIndex * segmentWidth;
            }

            // 2. Draw the ANIMATED Selection Pill 
            // We use _currentX here instead of calculating from index
            RectangleF selectionRect = new RectangleF(
                _currentX + 2,
                2,
                segmentWidth - 4,
                this.Height - 4
            );

            using (var path = GetRoundedPath(selectionRect, (int)selectionRect.Height))
            using (var brush = new SolidBrush(_selectionColor))
            {
                g.FillPath(brush, path);
            }

            // 3. Draw Text
            using (var font = new Font("Segoe UI", 10, FontStyle.Regular))
            using (var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    // Note: You could also animate color blending here, but simple switching is usually fine
                    var brushColor = (i == _selectedIndex) ? _selectedTextColor : _textColor;

                    RectangleF textRect = new RectangleF(i * segmentWidth, 0, segmentWidth, this.Height);

                    using (var textBrush = new SolidBrush(brushColor))
                    {
                        g.DrawString(_items[i], font, textBrush, textRect, format);
                    }
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (_items.Count == 0) return;

            float segmentWidth = (float)this.Width / _items.Count;
            int clickedIndex = (int)(e.X / segmentWidth);

            if (clickedIndex != _selectedIndex && clickedIndex < _items.Count)
            {
                SelectedIndex = clickedIndex; // This triggers the setter -> starts animation
            }
        }

        private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius + rect.X, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius + rect.X, rect.Height - radius + rect.Y, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius + rect.Y, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}