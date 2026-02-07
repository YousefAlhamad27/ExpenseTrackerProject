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
            pictureBox1 = new PictureBox();
            lbText = new Label();
            lbAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // SubscriptionItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(lbAmount);
            Controls.Add(lbText);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "SubscriptionItem";
            Size = new Size(393, 74);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbText;
        private Label lbAmount;
    }
}
