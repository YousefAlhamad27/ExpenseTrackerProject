namespace ExpenseTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            customButton4 = new CustomButton();
            customButton5 = new CustomButton();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            btDashBoard = new CustomButton();
            btWalletsMenu = new CustomButton();
            btCategories = new CustomButton();
            btSettings = new CustomButton();
            MainViewPanel = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // customButton4
            // 
            customButton4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            customButton4.BackColor = Color.FromArgb(224, 224, 224);
            customButton4.BackgroundColor = Color.FromArgb(224, 224, 224);
            customButton4.BorderColor = Color.PaleVioletRed;
            customButton4.BorderRadius = 12;
            customButton4.BorderSize = 0;
            customButton4.Enabled = false;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton4.ForeColor = Color.Black;
            customButton4.Image = Properties.Resources._4658825__1_;
            customButton4.Location = new Point(51, 209);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(231, 68);
            customButton4.TabIndex = 4;
            customButton4.Text = "Give Feedback";
            customButton4.TextColor = Color.Black;
            customButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            customButton5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            customButton5.BackColor = Color.FromArgb(224, 224, 224);
            customButton5.BackgroundColor = Color.FromArgb(224, 224, 224);
            customButton5.BorderColor = Color.PaleVioletRed;
            customButton5.BorderRadius = 12;
            customButton5.BorderSize = 0;
            customButton5.Enabled = false;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton5.ForeColor = Color.Black;
            customButton5.Image = Properties.Resources._202590_200__1_;
            customButton5.Location = new Point(51, 292);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(231, 68);
            customButton5.TabIndex = 5;
            customButton5.Text = "Report Issue";
            customButton5.TextColor = Color.Black;
            customButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 897);
            panel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(customButton4);
            panel4.Controls.Add(customButton5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 512);
            panel4.Name = "panel4";
            panel4.Size = new Size(421, 385);
            panel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btDashBoard);
            panel3.Controls.Add(btWalletsMenu);
            panel3.Controls.Add(btCategories);
            panel3.Controls.Add(btSettings);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 514);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(60, 46);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 14;
            label1.Text = "Expense Tracker";
            // 
            // btDashBoard
            // 
            btDashBoard.BackColor = Color.FromArgb(224, 224, 224);
            btDashBoard.BackgroundColor = Color.FromArgb(224, 224, 224);
            btDashBoard.BorderColor = Color.PaleVioletRed;
            btDashBoard.BorderRadius = 12;
            btDashBoard.BorderSize = 0;
            btDashBoard.FlatAppearance.BorderSize = 0;
            btDashBoard.FlatStyle = FlatStyle.Flat;
            btDashBoard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDashBoard.ForeColor = Color.Black;
            btDashBoard.Image = Properties.Resources.dashboard_76__1_;
            btDashBoard.Location = new Point(51, 96);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(231, 68);
            btDashBoard.TabIndex = 9;
            btDashBoard.Text = "Dashboard";
            btDashBoard.TextColor = Color.Black;
            btDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btDashBoard.UseVisualStyleBackColor = false;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // btWalletsMenu
            // 
            btWalletsMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btWalletsMenu.BackColor = Color.FromArgb(224, 224, 224);
            btWalletsMenu.BackgroundColor = Color.FromArgb(224, 224, 224);
            btWalletsMenu.BorderColor = Color.PaleVioletRed;
            btWalletsMenu.BorderRadius = 12;
            btWalletsMenu.BorderSize = 0;
            btWalletsMenu.FlatAppearance.BorderSize = 0;
            btWalletsMenu.FlatStyle = FlatStyle.Flat;
            btWalletsMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btWalletsMenu.ForeColor = Color.Black;
            btWalletsMenu.Image = Properties.Resources.wallet_icon_5990__1_;
            btWalletsMenu.Location = new Point(51, 192);
            btWalletsMenu.Name = "btWalletsMenu";
            btWalletsMenu.Size = new Size(231, 68);
            btWalletsMenu.TabIndex = 11;
            btWalletsMenu.Text = "Wallets";
            btWalletsMenu.TextColor = Color.Black;
            btWalletsMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btWalletsMenu.UseVisualStyleBackColor = false;
            btWalletsMenu.Click += btWalletsMenu_Click;
            // 
            // btCategories
            // 
            btCategories.BackColor = Color.FromArgb(224, 224, 224);
            btCategories.BackgroundColor = Color.FromArgb(224, 224, 224);
            btCategories.BorderColor = Color.PaleVioletRed;
            btCategories.BorderRadius = 12;
            btCategories.BorderSize = 0;
            btCategories.FlatAppearance.BorderSize = 0;
            btCategories.FlatStyle = FlatStyle.Flat;
            btCategories.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCategories.ForeColor = Color.Black;
            btCategories.Image = Properties.Resources._1383970;
            btCategories.Location = new Point(51, 282);
            btCategories.Name = "btCategories";
            btCategories.Size = new Size(231, 68);
            btCategories.TabIndex = 10;
            btCategories.Text = "Categories";
            btCategories.TextColor = Color.Black;
            btCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btCategories.UseVisualStyleBackColor = false;
            // 
            // btSettings
            // 
            btSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btSettings.AutoSize = true;
            btSettings.BackColor = Color.FromArgb(224, 224, 224);
            btSettings.BackgroundColor = Color.FromArgb(224, 224, 224);
            btSettings.BorderColor = Color.PaleVioletRed;
            btSettings.BorderRadius = 12;
            btSettings.BorderSize = 0;
            btSettings.FlatAppearance.BorderSize = 0;
            btSettings.FlatStyle = FlatStyle.Flat;
            btSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSettings.ForeColor = Color.Black;
            btSettings.Image = Properties.Resources.settings_3110__1_;
            btSettings.Location = new Point(51, 375);
            btSettings.Name = "btSettings";
            btSettings.Size = new Size(231, 79);
            btSettings.TabIndex = 12;
            btSettings.Text = "Settings";
            btSettings.TextColor = Color.Black;
            btSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSettings.UseVisualStyleBackColor = false;
            btSettings.Click += btSettings_Click;
            // 
            // MainViewPanel
            // 
            MainViewPanel.BackColor = Color.FromArgb(64, 64, 64);
            MainViewPanel.Dock = DockStyle.Fill;
            MainViewPanel.Location = new Point(421, 0);
            MainViewPanel.Name = "MainViewPanel";
            MainViewPanel.Size = new Size(1093, 897);
            MainViewPanel.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1514, 897);
            Controls.Add(MainViewPanel);
            Controls.Add(panel1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomButton customButton4;
        private CustomButton customButton5;
        private Panel panel1;
        private Panel MainViewPanel;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private CustomButton btDashBoard;
        private CustomButton btWalletsMenu;
        private CustomButton btCategories;
        private CustomButton btSettings;
    }
}
