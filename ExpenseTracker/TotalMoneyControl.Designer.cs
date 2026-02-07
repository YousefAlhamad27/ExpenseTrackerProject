namespace ExpenseTracker
{
    partial class TotalMoneyControl
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
            lbAmount = new Label();
            lbCurrency = new Label();
            SuspendLayout();
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Font = new Font("Segoe UI", 13.8F);
            lbAmount.Location = new Point(3, 21);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(76, 31);
            lbAmount.TabIndex = 0;
            lbAmount.Text = "label1";
            // 
            // lbCurrency
            // 
            lbCurrency.AutoSize = true;
            lbCurrency.Font = new Font("Segoe UI", 13.8F);
            lbCurrency.Location = new Point(304, 21);
            lbCurrency.Name = "lbCurrency";
            lbCurrency.Size = new Size(76, 31);
            lbCurrency.TabIndex = 1;
            lbCurrency.Text = "label2";
            // 
            // TotalMoneyControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbCurrency);
            Controls.Add(lbAmount);
            Name = "TotalMoneyControl";
            Size = new Size(381, 70);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAmount;
        private Label lbCurrency;
    }
}
