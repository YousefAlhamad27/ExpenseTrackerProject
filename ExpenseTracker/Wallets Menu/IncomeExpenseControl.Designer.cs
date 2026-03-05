namespace ExpenseTracker.Wallets_Menu
{
    partial class IncomeExpenseControl
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
            DateTimePicker = new CustomDatePicker();
            txtAmount = new PlaceholderTextBox();
            label3 = new Label();
            txtDesc = new PlaceholderTextBox();
            label6 = new Label();
            cbCat = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Gray;
            customButton1.BackgroundColor = Color.Gray;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 0;
            customButton1.Cursor = Cursors.Hand;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(15, 316);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(506, 45);
            customButton1.TabIndex = 14;
            customButton1.Text = "Save";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // DateTimePicker
            // 
            DateTimePicker.BackColor = Color.DarkGray;
            DateTimePicker.Icon = Properties.Resources.selection_date_1;
            DateTimePicker.Location = new Point(16, 259);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(506, 48);
            DateTimePicker.TabIndex = 13;
            DateTimePicker.Value = new DateTime(2026, 2, 14, 0, 0, 0, 0);
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.DarkGray;
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Cursor = Cursors.IBeam;
            txtAmount.Font = new Font("Segoe UI", 10.8F);
            txtAmount.Location = new Point(15, 54);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "0.00 USD";
            txtAmount.Size = new Size(210, 31);
            txtAmount.TabIndex = 16;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(15, 26);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 15;
            label3.Text = "Amount";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.DarkGray;
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Cursor = Cursors.IBeam;
            txtDesc.Font = new Font("Segoe UI", 10.8F);
            txtDesc.Location = new Point(291, 54);
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Bought a new Phone";
            txtDesc.Size = new Size(230, 31);
            txtDesc.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(291, 24);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 17;
            label6.Text = "Description";
            // 
            // cbCat
            // 
            cbCat.BackColor = Color.DarkGray;
            cbCat.FlatStyle = FlatStyle.System;
            cbCat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCat.FormattingEnabled = true;
            cbCat.Location = new Point(16, 140);
            cbCat.Name = "cbCat";
            cbCat.Size = new Size(506, 36);
            cbCat.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(16, 112);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 19;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(16, 193);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 21;
            label2.Text = "Don't see a category?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.DimGray;
            linkLabel1.LinkColor = Color.DarkGray;
            linkLabel1.Location = new Point(199, 195);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(132, 23);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "+ Add Category";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // IncomeExpenseControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(cbCat);
            Controls.Add(label1);
            Controls.Add(txtDesc);
            Controls.Add(label6);
            Controls.Add(txtAmount);
            Controls.Add(label3);
            Controls.Add(customButton1);
            Controls.Add(DateTimePicker);
            Name = "IncomeExpenseControl";
            Size = new Size(548, 373);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton customButton1;
        private CustomDatePicker DateTimePicker;
        private PlaceholderTextBox txtAmount;
        private Label label3;
        private PlaceholderTextBox txtDesc;
        private Label label6;
        private ComboBox cbCat;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}
