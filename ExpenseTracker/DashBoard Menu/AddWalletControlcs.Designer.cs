namespace ExpenseTracker
{
    partial class AddWalletControlcs
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            customButton1 = new CustomButton();
            txtName = new PlaceholderTextBox();
            txtBalance = new PlaceholderTextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(51, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(437, 33);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 75);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 188);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 4;
            label2.Text = "Currency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 298);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 5;
            label3.Text = "Balance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(111, 75);
            label6.Name = "label6";
            label6.Size = new Size(20, 28);
            label6.TabIndex = 8;
            label6.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(126, 298);
            label4.Name = "label4";
            label4.Size = new Size(20, 28);
            label4.TabIndex = 9;
            label4.Text = "*";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Black;
            customButton1.BackgroundColor = Color.Black;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 0;
            customButton1.Cursor = Cursors.Hand;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(70, 394);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(385, 50);
            customButton1.TabIndex = 11;
            customButton1.Text = "Save";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(51, 117);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Bank Of America";
            txtName.Size = new Size(437, 31);
            txtName.TabIndex = 12;
            // 
            // txtBalance
            // 
            txtBalance.Cursor = Cursors.IBeam;
            txtBalance.Location = new Point(51, 340);
            txtBalance.Name = "txtBalance";
            txtBalance.PlaceholderText = "Bank Of America";
            txtBalance.Size = new Size(437, 31);
            txtBalance.TabIndex = 13;
            txtBalance.Text = "0.00";
            // 
            // AddWalletControlcs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            Controls.Add(txtBalance);
            Controls.Add(txtName);
            Controls.Add(customButton1);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AddWalletControlcs";
            Size = new Size(516, 471);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private CustomButton customButton1;
        private PlaceholderTextBox txtName;
        private PlaceholderTextBox txtBalance;
    }
}
