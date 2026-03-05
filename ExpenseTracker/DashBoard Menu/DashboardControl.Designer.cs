namespace ExpenseTracker
{
    partial class DashboardControl
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            MoneyPanel = new FlowLayoutPanel();
            label3 = new Label();
            panel4 = new Panel();
            TransactionsPanel = new Panel();
            label4 = new Label();
            SubscriptionPanel = new FlowLayoutPanel();
            WalletsLayoutPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btAddWallet = new CustomButton();
            toolTip = new ToolTip(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            TransactionsPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 3;
            label2.Text = "Last Transactions";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 705);
            panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 94);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(344, 511);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(MoneyPanel);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(350, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 705);
            panel3.TabIndex = 6;
            // 
            // MoneyPanel
            // 
            MoneyPanel.AutoScroll = true;
            MoneyPanel.FlowDirection = FlowDirection.TopDown;
            MoneyPanel.Location = new Point(6, 94);
            MoneyPanel.Name = "MoneyPanel";
            MoneyPanel.Size = new Size(344, 560);
            MoneyPanel.TabIndex = 4;
            MoneyPanel.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 4;
            label3.Text = "Total Money";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(TransactionsPanel);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(0, 262);
            panel4.Name = "panel4";
            panel4.Size = new Size(1051, 705);
            panel4.TabIndex = 7;
            // 
            // TransactionsPanel
            // 
            TransactionsPanel.BackColor = Color.Transparent;
            TransactionsPanel.Controls.Add(label4);
            TransactionsPanel.Controls.Add(SubscriptionPanel);
            TransactionsPanel.Dock = DockStyle.Right;
            TransactionsPanel.Location = new Point(701, 0);
            TransactionsPanel.Name = "TransactionsPanel";
            TransactionsPanel.Size = new Size(350, 705);
            TransactionsPanel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 4;
            label4.Text = "All Subscriptions";
            // 
            // SubscriptionPanel
            // 
            SubscriptionPanel.AutoScroll = true;
            SubscriptionPanel.FlowDirection = FlowDirection.TopDown;
            SubscriptionPanel.Location = new Point(0, 94);
            SubscriptionPanel.Name = "SubscriptionPanel";
            SubscriptionPanel.Size = new Size(344, 560);
            SubscriptionPanel.TabIndex = 5;
            SubscriptionPanel.WrapContents = false;
            // 
            // WalletsLayoutPanel
            // 
            WalletsLayoutPanel.AutoScroll = true;
            WalletsLayoutPanel.BackColor = Color.Transparent;
            WalletsLayoutPanel.Dock = DockStyle.Bottom;
            WalletsLayoutPanel.Location = new Point(0, 69);
            WalletsLayoutPanel.Name = "WalletsLayoutPanel";
            WalletsLayoutPanel.Size = new Size(1051, 193);
            WalletsLayoutPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(WalletsLayoutPanel);
            panel1.Controls.Add(btAddWallet);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 262);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources._2725164__1_1;
            pictureBox1.Location = new Point(873, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(32, 4);
            label1.Name = "label1";
            label1.Size = new Size(159, 38);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btAddWallet
            // 
            btAddWallet.BackColor = SystemColors.ActiveCaptionText;
            btAddWallet.BackgroundColor = SystemColors.ActiveCaptionText;
            btAddWallet.BorderColor = Color.PaleVioletRed;
            btAddWallet.BorderRadius = 15;
            btAddWallet.BorderSize = 0;
            btAddWallet.Cursor = Cursors.Hand;
            btAddWallet.FlatAppearance.BorderSize = 0;
            btAddWallet.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btAddWallet.FlatStyle = FlatStyle.Flat;
            btAddWallet.ForeColor = Color.White;
            btAddWallet.Location = new Point(930, 13);
            btAddWallet.Name = "btAddWallet";
            btAddWallet.Size = new Size(115, 50);
            btAddWallet.TabIndex = 2;
            btAddWallet.Text = "Add Wallet ";
            btAddWallet.TextColor = Color.White;
            btAddWallet.UseVisualStyleBackColor = false;
            btAddWallet.Click += btAddWallet_Click;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "DashboardControl";
            Size = new Size(1051, 967);
            Load += DashboardControl_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            TransactionsPanel.ResumeLayout(false);
            TransactionsPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel TransactionsPanel;
        private FlowLayoutPanel WalletsLayoutPanel;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel SubscriptionPanel;
        private Label label1;
        private CustomButton btAddWallet;
        private FlowLayoutPanel MoneyPanel;
        private PictureBox pictureBox1;
        private ToolTip toolTip;
    }
}
