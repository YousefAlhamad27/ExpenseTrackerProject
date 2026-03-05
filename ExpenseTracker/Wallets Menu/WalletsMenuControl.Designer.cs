namespace ExpenseTracker.Wallets_Menu
{
    partial class WalletsMenuControl
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
            leftBigPanel = new Panel();
            TopPanel = new Panel();
            btNext = new CustomButton();
            btAddTransaction = new CustomButton();
            label1 = new Label();
            lbWalletName = new Label();
            TransactionsFlowLayoutPanel = new FlowLayoutPanel();
            rightBigPanel = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            lbAddSubscription = new Label();
            SubscriptionsFlow = new FlowLayoutPanel();
            panel1 = new Panel();
            lbText = new Label();
            lbAddLimit = new Label();
            CategoriesLimitsFlow = new FlowLayoutPanel();
            multiUseRectangle2 = new MultiUseRectangle();
            multiUseRectangle1 = new MultiUseRectangle();
            ToolTip = new ToolTip(components);
            btRemoveWallet = new CustomButton();
            leftBigPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            rightBigPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftBigPanel
            // 
            leftBigPanel.Controls.Add(TopPanel);
            leftBigPanel.Controls.Add(TransactionsFlowLayoutPanel);
            leftBigPanel.Dock = DockStyle.Left;
            leftBigPanel.Location = new Point(0, 0);
            leftBigPanel.Name = "leftBigPanel";
            leftBigPanel.Size = new Size(640, 897);
            leftBigPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(btRemoveWallet);
            TopPanel.Controls.Add(btNext);
            TopPanel.Controls.Add(btAddTransaction);
            TopPanel.Controls.Add(label1);
            TopPanel.Controls.Add(lbWalletName);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(640, 182);
            TopPanel.TabIndex = 1;
            // 
            // btNext
            // 
            btNext.BackColor = Color.Black;
            btNext.BackgroundColor = Color.Black;
            btNext.BorderColor = Color.PaleVioletRed;
            btNext.BorderRadius = 20;
            btNext.BorderSize = 0;
            btNext.Cursor = Cursors.Hand;
            btNext.FlatAppearance.BorderSize = 0;
            btNext.FlatStyle = FlatStyle.Flat;
            btNext.ForeColor = Color.White;
            btNext.Location = new Point(537, 12);
            btNext.Name = "btNext";
            btNext.Size = new Size(86, 60);
            btNext.TabIndex = 0;
            btNext.Text = "Next";
            btNext.TextColor = Color.White;
            btNext.UseVisualStyleBackColor = false;
            btNext.Click += btNext_Click;
            // 
            // btAddTransaction
            // 
            btAddTransaction.BackColor = Color.Black;
            btAddTransaction.BackgroundColor = Color.Black;
            btAddTransaction.BorderColor = Color.PaleVioletRed;
            btAddTransaction.BorderRadius = 20;
            btAddTransaction.BorderSize = 0;
            btAddTransaction.Cursor = Cursors.Hand;
            btAddTransaction.FlatAppearance.BorderSize = 0;
            btAddTransaction.FlatAppearance.MouseOverBackColor = Color.Gray;
            btAddTransaction.FlatStyle = FlatStyle.Flat;
            btAddTransaction.ForeColor = Color.White;
            btAddTransaction.Location = new Point(435, 118);
            btAddTransaction.Name = "btAddTransaction";
            btAddTransaction.Size = new Size(188, 50);
            btAddTransaction.TabIndex = 2;
            btAddTransaction.Text = "Add Transaction";
            btAddTransaction.TextColor = Color.White;
            btAddTransaction.UseVisualStyleBackColor = false;
            btAddTransaction.Click += customButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(3, 124);
            label1.Name = "label1";
            label1.Size = new Size(140, 31);
            label1.TabIndex = 1;
            label1.Text = "Transactions";
            // 
            // lbWalletName
            // 
            lbWalletName.AutoSize = true;
            lbWalletName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWalletName.ForeColor = SystemColors.ActiveCaptionText;
            lbWalletName.Location = new Point(3, 12);
            lbWalletName.Name = "lbWalletName";
            lbWalletName.Size = new Size(254, 41);
            lbWalletName.TabIndex = 0;
            lbWalletName.Text = "Bank Of America";
            // 
            // TransactionsFlowLayoutPanel
            // 
            TransactionsFlowLayoutPanel.AutoScroll = true;
            TransactionsFlowLayoutPanel.Dock = DockStyle.Bottom;
            TransactionsFlowLayoutPanel.Location = new Point(0, 188);
            TransactionsFlowLayoutPanel.Name = "TransactionsFlowLayoutPanel";
            TransactionsFlowLayoutPanel.Size = new Size(640, 709);
            TransactionsFlowLayoutPanel.TabIndex = 0;
            TransactionsFlowLayoutPanel.Paint += TransactionsFlowLayoutPanel_Paint;
            // 
            // rightBigPanel
            // 
            rightBigPanel.AutoScroll = true;
            rightBigPanel.Controls.Add(panel2);
            rightBigPanel.Controls.Add(panel1);
            rightBigPanel.Controls.Add(multiUseRectangle2);
            rightBigPanel.Controls.Add(multiUseRectangle1);
            rightBigPanel.Dock = DockStyle.Right;
            rightBigPanel.Location = new Point(646, 0);
            rightBigPanel.Name = "rightBigPanel";
            rightBigPanel.Size = new Size(447, 897);
            rightBigPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 30);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbAddSubscription);
            panel2.Controls.Add(SubscriptionsFlow);
            panel2.Location = new Point(3, 535);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 346);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 18);
            label2.Name = "label2";
            label2.Size = new Size(141, 30);
            label2.TabIndex = 9;
            label2.Text = "Subscriptions";
            // 
            // lbAddSubscription
            // 
            lbAddSubscription.AutoSize = true;
            lbAddSubscription.Cursor = Cursors.Hand;
            lbAddSubscription.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddSubscription.ForeColor = Color.Gainsboro;
            lbAddSubscription.Location = new Point(371, 9);
            lbAddSubscription.Name = "lbAddSubscription";
            lbAddSubscription.Size = new Size(44, 46);
            lbAddSubscription.TabIndex = 8;
            lbAddSubscription.Text = "+";
            lbAddSubscription.Click += lbAddSubscription_Click_1;
            lbAddSubscription.MouseLeave += lbAddSubscription_MouseLeave;
            lbAddSubscription.MouseHover += lbAddSubscription_MouseHover;
            // 
            // SubscriptionsFlow
            // 
            SubscriptionsFlow.AutoScroll = true;
            SubscriptionsFlow.Dock = DockStyle.Bottom;
            SubscriptionsFlow.Location = new Point(0, 69);
            SubscriptionsFlow.Name = "SubscriptionsFlow";
            SubscriptionsFlow.Size = new Size(430, 277);
            SubscriptionsFlow.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(lbText);
            panel1.Controls.Add(lbAddLimit);
            panel1.Controls.Add(CategoriesLimitsFlow);
            panel1.Location = new Point(3, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 355);
            panel1.TabIndex = 0;
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Font = new Font("Segoe UI", 13F);
            lbText.ForeColor = Color.White;
            lbText.Location = new Point(11, 14);
            lbText.Name = "lbText";
            lbText.Size = new Size(193, 30);
            lbText.TabIndex = 6;
            lbText.Text = "Limits By Category";
            // 
            // lbAddLimit
            // 
            lbAddLimit.AutoSize = true;
            lbAddLimit.Cursor = Cursors.Hand;
            lbAddLimit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddLimit.ForeColor = Color.Gainsboro;
            lbAddLimit.Location = new Point(379, 16);
            lbAddLimit.Name = "lbAddLimit";
            lbAddLimit.Size = new Size(44, 46);
            lbAddLimit.TabIndex = 4;
            lbAddLimit.Text = "+";
            lbAddLimit.Click += lbAddLimit_Click_1;
            lbAddLimit.MouseLeave += lbAddLimit_MouseLeave;
            lbAddLimit.MouseHover += lbAddLimit_MouseHover;
            // 
            // CategoriesLimitsFlow
            // 
            CategoriesLimitsFlow.AutoScroll = true;
            CategoriesLimitsFlow.Dock = DockStyle.Bottom;
            CategoriesLimitsFlow.Location = new Point(0, 65);
            CategoriesLimitsFlow.Name = "CategoriesLimitsFlow";
            CategoriesLimitsFlow.Size = new Size(430, 290);
            CategoriesLimitsFlow.TabIndex = 5;
            // 
            // multiUseRectangle2
            // 
            multiUseRectangle2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            multiUseRectangle2.BackColor = Color.FromArgb(30, 30, 30);
            multiUseRectangle2.Location = new Point(3, 62);
            multiUseRectangle2.Name = "multiUseRectangle2";
            multiUseRectangle2.Size = new Size(201, 106);
            multiUseRectangle2.TabIndex = 1;
            // 
            // multiUseRectangle1
            // 
            multiUseRectangle1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            multiUseRectangle1.BackColor = Color.FromArgb(30, 30, 30);
            multiUseRectangle1.Location = new Point(232, 62);
            multiUseRectangle1.Name = "multiUseRectangle1";
            multiUseRectangle1.Size = new Size(201, 106);
            multiUseRectangle1.TabIndex = 0;
            // 
            // btRemoveWallet
            // 
            btRemoveWallet.BackColor = Color.Red;
            btRemoveWallet.BackgroundColor = Color.Red;
            btRemoveWallet.BorderColor = Color.PaleVioletRed;
            btRemoveWallet.BorderRadius = 20;
            btRemoveWallet.BorderSize = 0;
            btRemoveWallet.Cursor = Cursors.Hand;
            btRemoveWallet.FlatAppearance.BorderSize = 0;
            btRemoveWallet.FlatStyle = FlatStyle.Flat;
            btRemoveWallet.ForeColor = Color.White;
            btRemoveWallet.Location = new Point(445, 12);
            btRemoveWallet.Name = "btRemoveWallet";
            btRemoveWallet.Size = new Size(86, 60);
            btRemoveWallet.TabIndex = 3;
            btRemoveWallet.Text = "Remove";
            btRemoveWallet.TextColor = Color.White;
            btRemoveWallet.UseVisualStyleBackColor = false;
            btRemoveWallet.Click += btRemoveWallet_Click;
            // 
            // WalletsMenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            Controls.Add(rightBigPanel);
            Controls.Add(leftBigPanel);
            Name = "WalletsMenuControl";
            Size = new Size(1093, 897);
            Load += WalletsMenuControl_Load;
            leftBigPanel.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            rightBigPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftBigPanel;
        private FlowLayoutPanel TransactionsFlowLayoutPanel;
        private Panel rightBigPanel;
        private Panel TopPanel;
        private CustomButton btAddTransaction;
        private Label label1;
        private Label lbWalletName;
        private MultiUseRectangle multiUseRectangle2;
        private MultiUseRectangle multiUseRectangle1;
        private Panel panel2;
        private Label label2;
        private Label lbAddSubscription;
        private FlowLayoutPanel SubscriptionsFlow;
        private Panel panel1;
        private Label lbText;
        private Label lbAddLimit;
        private FlowLayoutPanel CategoriesLimitsFlow;
        private CustomButton btNext;
        private ToolTip ToolTip;
        private CustomButton btRemoveWallet;
    }
}
