namespace ExpenseTracker.DashBoard_Menu
{
    partial class WalletCard
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
            lbName = new Label();
            lbAmount = new Label();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Transparent;
            lbName.ForeColor = Color.WhiteSmoke;
            lbName.Location = new Point(3, 10);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Name";
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Font = new Font("Segoe UI", 10.8F);
            lbAmount.ForeColor = Color.White;
            lbAmount.Location = new Point(13, 42);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(77, 25);
            lbAmount.TabIndex = 3;
            lbAmount.Text = "Amount";
            // 
            // WalletCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(lbAmount);
            Controls.Add(lbName);
            Name = "WalletCard";
            Size = new Size(229, 76);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbAmount;
    }
}
