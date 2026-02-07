namespace ExpenseTracker
{
    partial class TransactionItem
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
            pictureBox1 = new PictureBox();
            lbAmount = new Label();
            lbCategory = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources._6065255_2_;
            pictureBox1.Location = new Point(350, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(13, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAmount.Location = new Point(55, 6);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(93, 31);
            lbAmount.TabIndex = 1;
            lbAmount.Text = "amount";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategory.Location = new Point(75, 38);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(56, 25);
            lbCategory.TabIndex = 2;
            lbCategory.Text = "name";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.Forggy1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // TransactionItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(lbCategory);
            Controls.Add(lbAmount);
            Controls.Add(pictureBox1);
            Name = "TransactionItem";
            Size = new Size(363, 70);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbAmount;
        private Label lbCategory;
        private PictureBox pictureBox2;
    }
}
