namespace ExpenseTracker.Wallets_Menu
{
    partial class AddCategoryLimitForm
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
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btSave = new CustomButton();
            SuspendLayout();
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Segoe UI", 13F);
            labelClose.ForeColor = Color.DarkGray;
            labelClose.Location = new Point(491, 9);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(26, 30);
            labelClose.TabIndex = 21;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10.8F);
            txtAmount.Location = new Point(171, 185);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "0.00 USD";
            txtAmount.Size = new Size(286, 31);
            txtAmount.TabIndex = 20;
            txtAmount.KeyPress += this.txtAmount_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 33);
            comboBox1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(21, 185);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 18;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(17, 93);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 17;
            label3.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 16;
            label1.Text = "Add Category Limit";
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
            btSave.Location = new Point(6, 257);
            btSave.Name = "btSave";
            btSave.Size = new Size(506, 45);
            btSave.TabIndex = 22;
            btSave.Text = "Save";
            btSave.TextColor = Color.White;
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // AddCategoryLimitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(524, 323);
            Controls.Add(btSave);
            Controls.Add(labelClose);
            Controls.Add(txtAmount);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCategoryLimitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategoryLimitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClose;
        private PlaceholderTextBox txtAmount;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private CustomButton btSave;
    }
}