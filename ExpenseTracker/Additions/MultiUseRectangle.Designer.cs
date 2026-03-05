namespace ExpenseTracker
{
    partial class MultiUseRectangle
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbDays = new Label();
            lbText = new Label();
            SuspendLayout();
            // 
            // lbDays
            // 
            lbDays.AutoSize = true;
            lbDays.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDays.ForeColor = SystemColors.ButtonFace;
            lbDays.Location = new Point(12, 49);
            lbDays.Name = "lbDays";
            lbDays.Size = new Size(63, 31);
            lbDays.TabIndex = 4;
            lbDays.Text = "Days";
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbText.ForeColor = Color.DarkGray;
            lbText.Location = new Point(12, 18);
            lbText.Name = "lbText";
            lbText.Size = new Size(173, 28);
            lbText.TabIndex = 3;
            lbText.Text = "Days Before Salary";
            // 
            // MultiUseRectangle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(lbDays);
            Controls.Add(lbText);
            Name = "MultiUseRectangle";
            Size = new Size(201, 106);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDays;
        private Label lbText;
    }
}
