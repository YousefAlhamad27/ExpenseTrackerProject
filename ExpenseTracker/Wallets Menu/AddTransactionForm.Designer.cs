namespace ExpenseTracker.Wallets_Menu
{
    partial class AddTransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransactionForm));
            label1 = new Label();
            segmentedControl1 = new SegmentedControl();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(521, -5);
            label1.Name = "label1";
            label1.Size = new Size(24, 28);
            label1.TabIndex = 7;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // segmentedControl1
            // 
            segmentedControl1.ForeColor = SystemColors.ActiveCaptionText;
            segmentedControl1.Items = (List<string>)resources.GetObject("segmentedControl1.Items");
            segmentedControl1.Location = new Point(88, 21);
            segmentedControl1.Name = "segmentedControl1";
            segmentedControl1.SelectedIndex = 1;
            segmentedControl1.Size = new Size(375, 50);
            segmentedControl1.TabIndex = 8;
            segmentedControl1.Text = "segmentedControl1";
            segmentedControl1.Click += segmentedControl1_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 373);
            panel1.TabIndex = 9;
            // 
            // AddTransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(548, 450);
            Controls.Add(panel1);
            Controls.Add(segmentedControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTransactionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private SegmentedControl segmentedControl1;
        private Panel panel1;
    }
}