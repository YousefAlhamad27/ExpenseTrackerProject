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
            btRemove = new CustomButton();
            btSave = new CustomButton();
            txtNewLimit = new TextBox();
            txtCurrent = new TextBox();
            lbMaxAmount = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.Red;
            btRemove.BackgroundColor = Color.Red;
            btRemove.BorderColor = Color.PaleVioletRed;
            btRemove.BorderRadius = 20;
            btRemove.BorderSize = 0;
            btRemove.Cursor = Cursors.Hand;
            btRemove.FlatAppearance.BorderSize = 0;
            btRemove.FlatStyle = FlatStyle.Flat;
            btRemove.ForeColor = Color.White;
            btRemove.Location = new Point(213, 139);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(102, 50);
            btRemove.TabIndex = 0;
            btRemove.Text = "Remove";
            btRemove.TextColor = Color.White;
            btRemove.UseVisualStyleBackColor = false;
            btRemove.Click += btRemove_Click;
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
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(52, 139);
            btSave.Name = "btSave";
            btSave.Size = new Size(102, 50);
            btSave.TabIndex = 1;
            btSave.Text = "Save";
            btSave.TextColor = Color.White;
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // txtNewLimit
            // 
            txtNewLimit.Cursor = Cursors.IBeam;
            txtNewLimit.Location = new Point(107, 32);
            txtNewLimit.Name = "txtNewLimit";
            txtNewLimit.Size = new Size(176, 27);
            txtNewLimit.TabIndex = 2;
            txtNewLimit.KeyPress += txtNewLimit_KeyPress;
            // 
            // txtCurrent
            // 
            txtCurrent.Cursor = Cursors.IBeam;
            txtCurrent.Location = new Point(107, 80);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(176, 27);
            txtCurrent.TabIndex = 3;
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
            // EditCategoryLimitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(336, 201);
            Controls.Add(label2);
            Controls.Add(lbMaxAmount);
            Controls.Add(txtCurrent);
            Controls.Add(txtNewLimit);
            Controls.Add(btSave);
            Controls.Add(btRemove);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditCategoryLimitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCategoryLimitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton btRemove;
        private CustomButton btSave;
        private TextBox txtNewLimit;
        private TextBox txtCurrent;
        private Label lbMaxAmount;
        private Label label2;
    }
}