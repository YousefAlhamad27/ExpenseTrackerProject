namespace ExpenseTracker.Wallets_Menu
{
    partial class CategoryLimitControl
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
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbAmount = new Label();
            lbRemaining = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Silver;
            progressBar1.Location = new Point(54, 39);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(230, 19);
            progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(36, 6);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Font = new Font("Segoe UI", 11F);
            lbAmount.Location = new Point(168, 6);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(79, 25);
            lbAmount.TabIndex = 3;
            lbAmount.Text = "Amount";
            // 
            // lbRemaining
            // 
            lbRemaining.AutoSize = true;
            lbRemaining.ForeColor = SystemColors.ControlLight;
            lbRemaining.Location = new Point(282, 11);
            lbRemaining.Name = "lbRemaining";
            lbRemaining.Size = new Size(31, 20);
            lbRemaining.TabIndex = 4;
            lbRemaining.Text = "left";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(290, 38);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 5;
            label3.Text = "Options";
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            label3.MouseHover += label3_MouseHover;
            // 
            // CategoryLimitControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(label3);
            Controls.Add(lbRemaining);
            Controls.Add(lbAmount);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Name = "CategoryLimitControl";
            Size = new Size(350, 69);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbAmount;
        private Label lbRemaining;
        private Label label3;
    }
}
