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
            customDatePicker1 = new CustomDatePicker();
            placeholderTextBox2 = new PlaceholderTextBox();
            label3 = new Label();
            placeholderTextBox3 = new PlaceholderTextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
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
            // customDatePicker1
            // 
            customDatePicker1.BackColor = Color.DarkGray;
            customDatePicker1.Icon = Properties.Resources.selection_date_1;
            customDatePicker1.Location = new Point(16, 259);
            customDatePicker1.Name = "customDatePicker1";
            customDatePicker1.Size = new Size(506, 48);
            customDatePicker1.TabIndex = 13;
            customDatePicker1.Value = new DateTime(2026, 1, 16, 12, 5, 6, 545);
            // 
            // placeholderTextBox2
            // 
            placeholderTextBox2.BackColor = Color.DarkGray;
            placeholderTextBox2.BorderStyle = BorderStyle.FixedSingle;
            placeholderTextBox2.Cursor = Cursors.IBeam;
            placeholderTextBox2.Font = new Font("Segoe UI", 10.8F);
            placeholderTextBox2.Location = new Point(15, 54);
            placeholderTextBox2.Name = "placeholderTextBox2";
            placeholderTextBox2.PlaceholderText = "0.00 USD";
            placeholderTextBox2.Size = new Size(210, 31);
            placeholderTextBox2.TabIndex = 16;
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
            // placeholderTextBox3
            // 
            placeholderTextBox3.BackColor = Color.DarkGray;
            placeholderTextBox3.BorderStyle = BorderStyle.FixedSingle;
            placeholderTextBox3.Cursor = Cursors.IBeam;
            placeholderTextBox3.Font = new Font("Segoe UI", 10.8F);
            placeholderTextBox3.Location = new Point(291, 54);
            placeholderTextBox3.Name = "placeholderTextBox3";
            placeholderTextBox3.PlaceholderText = "Bought a new Phone";
            placeholderTextBox3.Size = new Size(230, 31);
            placeholderTextBox3.TabIndex = 18;
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
            // comboBox2
            // 
            comboBox2.BackColor = Color.DarkGray;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(16, 140);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(506, 36);
            comboBox2.TabIndex = 20;
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
            // 
            // IncomeExpenseControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(placeholderTextBox3);
            Controls.Add(label6);
            Controls.Add(placeholderTextBox2);
            Controls.Add(label3);
            Controls.Add(customButton1);
            Controls.Add(customDatePicker1);
            Name = "IncomeExpenseControl";
            Size = new Size(548, 373);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton customButton1;
        private CustomDatePicker customDatePicker1;
        private PlaceholderTextBox placeholderTextBox2;
        private Label label3;
        private PlaceholderTextBox placeholderTextBox3;
        private Label label6;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}
