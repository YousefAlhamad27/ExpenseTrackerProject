namespace ExpenseTracker.Wallets_Menu
{
    partial class EditSubscriptionForm
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
            txtDescritption = new PlaceholderTextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btSave = new CustomButton();
            labelClose = new Label();
            txtAmount = new PlaceholderTextBox();
            label4 = new Label();
            cbWallets = new ComboBox();
            label5 = new Label();
            radioPaid = new RadioButton();
            radioUnpaid = new RadioButton();
            panel1 = new Panel();
            customButton1 = new CustomButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescritption
            // 
            txtDescritption.Font = new Font("Segoe UI", 10.8F);
            txtDescritption.Location = new Point(162, 88);
            txtDescritption.Name = "txtDescritption";
            txtDescritption.PlaceholderText = "ex: Spotify";
            txtDescritption.Size = new Size(286, 31);
            txtDescritption.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(162, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 33);
            comboBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(8, 170);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 16;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(8, 87);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 15;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 14;
            label1.Text = "Edit Subscription";
            // 
            // btSave
            // 
            btSave.BackColor = Color.Gray;
            btSave.BackgroundColor = Color.Gray;
            btSave.BorderColor = Color.PaleVioletRed;
            btSave.BorderRadius = 20;
            btSave.BorderSize = 0;
            btSave.Cursor = Cursors.Hand;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(12, 435);
            btSave.Name = "btSave";
            btSave.Size = new Size(506, 45);
            btSave.TabIndex = 22;
            btSave.Text = "Save";
            btSave.TextColor = Color.White;
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Segoe UI", 13F);
            labelClose.ForeColor = Color.DarkGray;
            labelClose.Location = new Point(489, 11);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(26, 30);
            labelClose.TabIndex = 21;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10.8F);
            txtAmount.Location = new Point(162, 235);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "0.00 USD";
            txtAmount.Size = new Size(286, 31);
            txtAmount.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(12, 235);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 19;
            label4.Text = "Amount";
            // 
            // cbWallets
            // 
            cbWallets.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWallets.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbWallets.FormattingEnabled = true;
            cbWallets.Location = new Point(162, 297);
            cbWallets.Name = "cbWallets";
            cbWallets.Size = new Size(286, 33);
            cbWallets.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(12, 297);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 24;
            label5.Text = "Wallet";
            // 
            // radioPaid
            // 
            radioPaid.AutoSize = true;
            radioPaid.Font = new Font("Segoe UI", 12F);
            radioPaid.ForeColor = Color.Gainsboro;
            radioPaid.Location = new Point(48, 17);
            radioPaid.Name = "radioPaid";
            radioPaid.Size = new Size(70, 32);
            radioPaid.TabIndex = 25;
            radioPaid.TabStop = true;
            radioPaid.Text = "Paid";
            radioPaid.UseVisualStyleBackColor = true;
            // 
            // radioUnpaid
            // 
            radioUnpaid.AutoSize = true;
            radioUnpaid.Font = new Font("Segoe UI", 12F);
            radioUnpaid.ForeColor = Color.Gainsboro;
            radioUnpaid.Location = new Point(145, 17);
            radioUnpaid.Name = "radioUnpaid";
            radioUnpaid.Size = new Size(90, 32);
            radioUnpaid.TabIndex = 26;
            radioUnpaid.TabStop = true;
            radioUnpaid.Text = "Unpay";
            radioUnpaid.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioPaid);
            panel1.Controls.Add(radioUnpaid);
            panel1.Location = new Point(17, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 73);
            panel1.TabIndex = 27;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Red;
            customButton1.BackgroundColor = Color.Red;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(372, 369);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(140, 49);
            customButton1.TabIndex = 28;
            customButton1.Text = "Delete";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // EditSubscriptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(524, 518);
            Controls.Add(customButton1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(cbWallets);
            Controls.Add(btSave);
            Controls.Add(labelClose);
            Controls.Add(txtAmount);
            Controls.Add(label4);
            Controls.Add(txtDescritption);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditSubscriptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditSubscriptionForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PlaceholderTextBox txtDescritption;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private CustomButton btSave;
        private Label labelClose;
        private PlaceholderTextBox txtAmount;
        private Label label4;
        private ComboBox cbWallets;
        private Label label5;
        private RadioButton radioPaid;
        private RadioButton radioUnpaid;
        private Panel panel1;
        private CustomButton customButton1;
    }
}