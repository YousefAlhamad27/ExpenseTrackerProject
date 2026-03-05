namespace ExpenseTracker.Wallets_Menu
{
    partial class AddCategoryForm
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
            btSave = new CustomButton();
            label3 = new Label();
            label1 = new Label();
            txtCatName = new PlaceholderTextBox();
            labelClose = new Label();
            SuspendLayout();
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
            btSave.Location = new Point(1, 148);
            btSave.Name = "btSave";
            btSave.Size = new Size(506, 45);
            btSave.TabIndex = 25;
            btSave.Text = "Save";
            btSave.TextColor = Color.White;
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(11, 69);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 24;
            label3.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 2);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 23;
            label1.Text = "Add Category";
            // 
            // txtCatName
            // 
            txtCatName.Font = new Font("Segoe UI", 10.8F);
            txtCatName.Location = new Point(142, 69);
            txtCatName.Name = "txtCatName";
            txtCatName.PlaceholderText = "ex: games";
            txtCatName.Size = new Size(286, 31);
            txtCatName.TabIndex = 26;
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Segoe UI", 13F);
            labelClose.ForeColor = Color.DarkGray;
            labelClose.Location = new Point(481, 4);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(26, 30);
            labelClose.TabIndex = 27;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(506, 217);
            Controls.Add(labelClose);
            Controls.Add(txtCatName);
            Controls.Add(btSave);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton btSave;
        private Label label3;
        private Label label1;
        private PlaceholderTextBox txtCatName;
        private Label labelClose;
    }
}