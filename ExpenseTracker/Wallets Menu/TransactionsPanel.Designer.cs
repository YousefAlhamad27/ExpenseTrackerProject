namespace ExpenseTracker.Wallets_Menu
{
    partial class TransactionsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsPanel));
            lbDate = new Label();
            transactionItem2 = new TransactionItem();
            SuspendLayout();
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.Black;
            lbDate.Location = new Point(16, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(65, 28);
            lbDate.TabIndex = 1;
            lbDate.Text = "label1";
            // 
            // transactionItem2
            // 
            transactionItem2.Amount = "amount";
            transactionItem2.BackColor = Color.FromArgb(30, 30, 30);
            transactionItem2.Dock = DockStyle.Bottom;
            transactionItem2.Icon = (Image)resources.GetObject("transactionItem2.Icon");
            transactionItem2.Location = new Point(0, 39);
            transactionItem2.Name = "transactionItem2";
            transactionItem2.Size = new Size(742, 88);
            transactionItem2.TabIndex = 2;
            transactionItem2.Title = "name";
            transactionItem2.TransactionId = 0;
            // 
            // TransactionsPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(transactionItem2);
            Controls.Add(lbDate);
            Name = "TransactionsPanel";
            Size = new Size(742, 127);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbDate;
        private TransactionItem transactionItem2;
    }
}
