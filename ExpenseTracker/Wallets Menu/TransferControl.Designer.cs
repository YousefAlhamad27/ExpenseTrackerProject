namespace ExpenseTracker.Wallets_Menu
{
    partial class TransferControl
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSecondAmount = new PlaceholderTextBox();
            txtFirstAmount = new PlaceholderTextBox();
            cbDest = new ComboBox();
            cbSource = new ComboBox();
            txtBoxDescription = new PlaceholderTextBox();
            DateTimePicker = new CustomDatePicker();
            btSave = new CustomButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(20, 8);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(342, 8);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(15, 70);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(342, 70);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(20, 227);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 4;
            label5.Text = "Event Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(15, 152);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 5;
            label6.Text = "Description";
            // 
            // txtSecondAmount
            // 
            txtSecondAmount.BackColor = Color.DarkGray;
            txtSecondAmount.BorderStyle = BorderStyle.FixedSingle;
            txtSecondAmount.Cursor = Cursors.IBeam;
            txtSecondAmount.Font = new Font("Segoe UI", 10.8F);
            txtSecondAmount.Location = new Point(332, 98);
            txtSecondAmount.Name = "txtSecondAmount";
            txtSecondAmount.PlaceholderText = "0.00 EUR";
            txtSecondAmount.Size = new Size(189, 31);
            txtSecondAmount.TabIndex = 6;
            txtSecondAmount.KeyPress += txtSecondAmount_KeyPress;
            // 
            // txtFirstAmount
            // 
            txtFirstAmount.BackColor = Color.DarkGray;
            txtFirstAmount.BorderStyle = BorderStyle.FixedSingle;
            txtFirstAmount.Cursor = Cursors.IBeam;
            txtFirstAmount.Font = new Font("Segoe UI", 10.8F);
            txtFirstAmount.Location = new Point(15, 98);
            txtFirstAmount.Name = "txtFirstAmount";
            txtFirstAmount.PlaceholderText = "0.00 USD";
            txtFirstAmount.Size = new Size(189, 31);
            txtFirstAmount.TabIndex = 7;
            txtFirstAmount.TextChanged += txtFirstAmount_TextChanged;
            txtFirstAmount.KeyPress += txtKeyPress;
            // 
            // cbDest
            // 
            cbDest.BackColor = Color.DarkGray;
            cbDest.FlatStyle = FlatStyle.System;
            cbDest.FormattingEnabled = true;
            cbDest.Location = new Point(332, 36);
            cbDest.Name = "cbDest";
            cbDest.Size = new Size(189, 28);
            cbDest.TabIndex = 8;
            cbDest.SelectedIndexChanged += cbDest_SelectedIndexChanged;
            // 
            // cbSource
            // 
            cbSource.BackColor = Color.DarkGray;
            cbSource.FlatStyle = FlatStyle.System;
            cbSource.FormattingEnabled = true;
            cbSource.Location = new Point(15, 36);
            cbSource.Name = "cbSource";
            cbSource.Size = new Size(189, 28);
            cbSource.TabIndex = 9;
            cbSource.SelectedIndexChanged += cbSource_SelectedIndexChanged;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.BackColor = Color.DarkGray;
            txtBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            txtBoxDescription.Cursor = Cursors.IBeam;
            txtBoxDescription.Font = new Font("Segoe UI", 10.8F);
            txtBoxDescription.Location = new Point(15, 182);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.PlaceholderText = "Just Saved Some Money";
            txtBoxDescription.Size = new Size(506, 31);
            txtBoxDescription.TabIndex = 10;
            // 
            // DateTimePicker
            // 
            DateTimePicker.BackColor = Color.DarkGray;
            DateTimePicker.Icon = Properties.Resources.selection_date_1;
            DateTimePicker.Location = new Point(15, 257);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(506, 48);
            DateTimePicker.TabIndex = 11;
            DateTimePicker.Value = new DateTime(2026, 2, 14, 12, 45, 34, 0);
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
            btSave.Location = new Point(14, 314);
            btSave.Name = "btSave";
            btSave.Size = new Size(506, 45);
            btSave.TabIndex = 12;
            btSave.Text = "Save";
            btSave.TextColor = Color.White;
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += customButton1_Click;
            // 
            // TransferControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(btSave);
            Controls.Add(DateTimePicker);
            Controls.Add(txtBoxDescription);
            Controls.Add(cbSource);
            Controls.Add(cbDest);
            Controls.Add(txtFirstAmount);
            Controls.Add(txtSecondAmount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TransferControl";
            Size = new Size(548, 373);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PlaceholderTextBox txtSecondAmount;
        private PlaceholderTextBox txtFirstAmount;
        private ComboBox cbDest;
        private ComboBox cbSource;
        private PlaceholderTextBox txtBoxDescription;
        private CustomDatePicker DateTimePicker;
        private CustomButton btSave;
    }
}
