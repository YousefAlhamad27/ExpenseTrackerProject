namespace ExpenseTracker.Wallets_Menu
{
    partial class SubscriptionItem
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
            pictureBox2 = new PictureBox();
            lbText = new Label();
            lbAmount = new Label();
            lbPaid = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = Properties.Resources._6065255_2_1;
            pictureBox2.Location = new Point(367, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbText.ForeColor = Color.White;
            lbText.Location = new Point(45, 23);
            lbText.Name = "lbText";
            lbText.Size = new Size(194, 31);
            lbText.TabIndex = 2;
            lbText.Text = "Bank Account Fee";
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAmount.ForeColor = Color.White;
            lbAmount.Location = new Point(245, 23);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(112, 31);
            lbAmount.TabIndex = 3;
            lbAmount.Text = "5000 USD";
            // 
            // lbPaid
            // 
            lbPaid.AutoSize = true;
            lbPaid.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPaid.ForeColor = Color.White;
            lbPaid.Location = new Point(16, 3);
            lbPaid.Name = "lbPaid";
            lbPaid.Size = new Size(57, 20);
            lbPaid.TabIndex = 4;
            lbPaid.Text = "Unpaid";
            // 
            // SubscriptionItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(lbPaid);
            Controls.Add(lbAmount);
            Controls.Add(lbText);
            Controls.Add(pictureBox2);
            Name = "SubscriptionItem";
            Size = new Size(393, 74);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label lbText;
        private Label lbAmount;
        private Label lbPaid;
    }
}
