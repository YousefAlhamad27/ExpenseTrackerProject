namespace ExpenseTracker
{
    partial class WalletControl
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
            customButton1 = new CustomButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(30, 30, 30);
            customButton1.BackgroundColor = Color.FromArgb(30, 30, 30);
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 5;
            customButton1.BorderSize = 0;
            customButton1.Dock = DockStyle.Fill;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(0, 0);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(229, 76);
            customButton1.TabIndex = 0;
            customButton1.Text = "Amount";
            customButton1.TextAlign = ContentAlignment.BottomLeft;
            customButton1.TextColor = Color.Black;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // WalletControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(customButton1);
            Name = "WalletControl";
            Size = new Size(229, 76);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton customButton1;
        private Label label1;
    }
}
