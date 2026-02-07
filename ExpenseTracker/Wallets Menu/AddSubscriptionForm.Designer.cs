namespace ExpenseTracker.Wallets_Menu
{
    partial class AddSubscriptionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelClose = new Label();
            txtAmount = new PlaceholderTextBox();
            txtDescritption = new PlaceholderTextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Segoe UI", 13F);
            labelClose.ForeColor = Color.DarkGray;
            labelClose.Location = new Point(489, 9);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(26, 30);
            labelClose.TabIndex = 15;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10.8F);
            txtAmount.Location = new Point(171, 277);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "0.00 USD";
            txtAmount.Size = new Size(286, 31);
            txtAmount.TabIndex = 14;
            // 
            // txtDescritption
            // 
            txtDescritption.Font = new Font("Segoe UI", 10.8F);
            txtDescritption.Location = new Point(171, 103);
            txtDescritption.Name = "txtDescritption";
            txtDescritption.PlaceholderText = "ex: Spotify";
            txtDescritption.Size = new Size(286, 31);
            txtDescritption.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 33);
            comboBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(21, 277);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 11;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(17, 185);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 10;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(17, 102);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 8;
            label1.Text = "Add Subscription";
            // 
            // AddSubscriptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(524, 346);
            Controls.Add(labelClose);
            Controls.Add(txtAmount);
            Controls.Add(txtDescritption);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSubscriptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSubscriptionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClose;
        private PlaceholderTextBox txtAmount;
        private PlaceholderTextBox txtDescritption;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}