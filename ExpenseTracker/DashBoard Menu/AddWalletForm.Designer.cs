namespace ExpenseTracker
{
    partial class AddWalletForm
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
            addWalletControlcs1 = new AddWalletControlcs();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addWalletControlcs1
            // 
            addWalletControlcs1.BackColor = Color.FromArgb(64, 64, 64);
            addWalletControlcs1.Cursor = Cursors.Default;
            addWalletControlcs1.Dock = DockStyle.Fill;
            addWalletControlcs1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addWalletControlcs1.Location = new Point(0, 0);
            addWalletControlcs1.Margin = new Padding(4);
            addWalletControlcs1.Name = "addWalletControlcs1";
            addWalletControlcs1.Size = new Size(583, 515);
            addWalletControlcs1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(560, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 28);
            label1.TabIndex = 5;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(addWalletControlcs1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 517);
            panel1.TabIndex = 6;
            // 
            // AddWalletForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 517);
            Controls.Add(panel1);
            Cursor = Cursors.WaitCursor;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddWalletForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddWalletForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AddWalletControlcs addWalletControlcs1;
        private Label label1;
        private Panel panel1;
    }
}