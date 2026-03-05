namespace ExpenseTracker.SettingsMenu
{
    partial class SettingsPanel
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
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            panel1 = new Panel();
            customButton1 = new CustomButton();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 14);
            label1.Name = "label1";
            label1.Size = new Size(163, 50);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(30, 30, 30);
            numericUpDown1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(3, 177);
            numericUpDown1.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(752, 38);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown1.KeyPress += numericUpDown1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F);
            label2.Location = new Point(0, 93);
            label2.Name = "label2";
            label2.Size = new Size(137, 29);
            label2.TabIndex = 2;
            label2.Text = "Salary Day";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(3, 134);
            label3.Name = "label3";
            label3.Size = new Size(556, 25);
            label3.TabIndex = 3;
            label3.Text = "Analytics are calculated for one month, starting from salary day.";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1093, 304);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.DragEnter += flowLayoutPanel1_DragEnter;
            flowLayoutPanel1.DragOver += Panel_DragOver;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F);
            label4.Location = new Point(0, 231);
            label4.Name = "label4";
            label4.Size = new Size(156, 29);
            label4.TabIndex = 5;
            label4.Text = "Your Wallets";
            // 
            // panel1
            // 
            panel1.Controls.Add(customButton1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 634);
            panel1.TabIndex = 6;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(30, 30, 30);
            customButton1.BackgroundColor = Color.FromArgb(30, 30, 30);
            customButton1.BorderColor = Color.OliveDrab;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 0;
            customButton1.Cursor = Cursors.Hand;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.Ivory;
            customButton1.Location = new Point(4, 435);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(1047, 50);
            customButton1.TabIndex = 8;
            customButton1.Text = "Remove Account";
            customButton1.TextColor = Color.Ivory;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(4, 375);
            label6.Name = "label6";
            label6.Size = new Size(612, 25);
            label6.TabIndex = 7;
            label6.Text = "Be aware that removing account is gonna erase all the data you have.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F);
            label5.Location = new Point(4, 321);
            label5.Name = "label5";
            label5.Size = new Size(207, 29);
            label5.TabIndex = 7;
            label5.Text = "Remove Account";
            // 
            // SettingsPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "SettingsPanel";
            Size = new Size(1093, 897);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private Panel panel1;
        private CustomButton customButton1;
        private Label label6;
        private Label label5;
    }
}
