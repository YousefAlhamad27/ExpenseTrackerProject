namespace ExpenseTracker.Wallets_Menu
{
    partial class EditCategoryLimitForm
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
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbMaxAmount = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Red;
            customButton1.BackgroundColor = Color.Red;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 0;
            customButton1.Cursor = Cursors.Hand;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(213, 139);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(102, 50);
            customButton1.TabIndex = 0;
            customButton1.Text = "Remove";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.Gray;
            customButton2.BackgroundColor = Color.Gray;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 20;
            customButton2.BorderSize = 0;
            customButton2.Cursor = Cursors.Hand;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(52, 139);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(102, 50);
            customButton2.TabIndex = 1;
            customButton2.Text = "Edit";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(107, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(107, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 27);
            textBox2.TabIndex = 3;
            // 
            // lbMaxAmount
            // 
            lbMaxAmount.AutoSize = true;
            lbMaxAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMaxAmount.ForeColor = Color.WhiteSmoke;
            lbMaxAmount.Location = new Point(38, 32);
            lbMaxAmount.Name = "lbMaxAmount";
            lbMaxAmount.Size = new Size(54, 25);
            lbMaxAmount.TabIndex = 4;
            lbMaxAmount.Text = "Limit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(19, 79);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 5;
            label2.Text = "Current:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(312, -4);
            label1.Name = "label1";
            label1.Size = new Size(24, 28);
            label1.TabIndex = 6;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // EditCategoryLimitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(336, 201);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lbMaxAmount);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditCategoryLimitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCategoryLimitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton customButton1;
        private CustomButton customButton2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbMaxAmount;
        private Label label2;
        private Label label1;
    }
}