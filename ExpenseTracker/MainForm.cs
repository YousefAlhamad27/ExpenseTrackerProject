using ExpenseTracker.SettingsMenu;
using ExpenseTracker.Wallets_Menu;
using static ExpenseTracker.CustomButton;

namespace ExpenseTracker
{
    public partial class MainForm : Form
    {
        private int currentIndex = 0;
        DashboardControl dashboardControl = new DashboardControl();
        WalletsMenuControl walletsMenuControl = new WalletsMenuControl();
        SettingsPanel settingsPanel = new SettingsPanel();

        // other controls
        private enum eMenuIndex
        {
            Dashboard = 0,
            Wallets = 1,
            Categories = 3,
            Settings = 2

            
        }
        eMenuIndex selectedMenuIndex;

        private void NewWalletAdded(object sender, EventArgs e)
        {
             walletsMenuControl.RefreshWallets();
        }
        public MainForm()
        {
            InitializeComponent();

            dashboardControl.WalletCardClicked += WalletCardClicked;
            settingsPanel.WalletCardClicked += WalletCardClicked;
            dashboardControl.WalletAdded += (s, e) =>NewWalletAdded(s, e);
            FormLoad();
        }

        private void FormLoad()
        {
            clearMenuPanel();
            FillPanel();
        }
        private void FillPanel()
        {
            clearMenuPanel();
            MainViewPanel.Controls.Add(dashboardControl);
            MainViewPanel.Controls.Add(walletsMenuControl);
            MainViewPanel.Controls.Add(settingsPanel);
            MainViewPanel.Controls[0].Dock = DockStyle.Fill;
            MainViewPanel.Controls[1].Dock = DockStyle.Fill;
            MainViewPanel.Controls[2].Dock = DockStyle.Fill;

            MainViewPanel.Controls[1].Visible = false;
            MainViewPanel.Controls[2].Visible = false;
            btDashBoard.Enabled = false;
        }
        private async void WalletCardClicked(object sender, int walletID)
        {

            try
            {
                await walletsMenuControl.ShowWallet(walletID);
                 btWalletsMenu.PerformClick();
            }
            catch
            {
                return;
            }
           
        }


        private void btDashBoard_Click(object sender, EventArgs e)
        {
            selectedMenuIndex = eMenuIndex.Dashboard;
            DetermineCurrentIndex();

        }
        private void clearMenuPanel()
        {

            MainViewPanel.Controls.Clear();

        }
        private void disablePreviousView()
        {


            MainViewPanel.Controls[currentIndex].Visible = false;
            currentIndex = (int)selectedMenuIndex;

        }
        private void enableOtherViewsButtons()
        {
            if (selectedMenuIndex == eMenuIndex.Dashboard)
            {
                btSettings.Enabled = true;
                btCategories.Enabled = true;
                btWalletsMenu.Enabled = true;
            }
            else if (selectedMenuIndex == eMenuIndex.Wallets)
            {
                btSettings.Enabled = true;
                btCategories.Enabled = true;
                btDashBoard.Enabled = true;
            }
            else if (selectedMenuIndex == eMenuIndex.Categories)
            {
                btSettings.Enabled = true;
                btSettings.Enabled = true;
                btDashBoard.Enabled = true;
            }
            else if (selectedMenuIndex == eMenuIndex.Settings)
            {
                btWalletsMenu.Enabled = true;
                btCategories.Enabled = true;
                btDashBoard.Enabled = true;
            }
        }
        private void disableCurrentViewButton()
        {
            switch (selectedMenuIndex)
            {
                case eMenuIndex.Dashboard:
                    btDashBoard.Enabled = false;
                    break;

                case eMenuIndex.Wallets:
                    btWalletsMenu.Enabled = false;
                    break;

                case eMenuIndex.Categories:
                    btCategories.Enabled = false;
                    break;
                case eMenuIndex.Settings:
                    btSettings.Enabled = false;
                    break;

            }
        }
        private void DetermineCurrentIndex()
        {
            switch (selectedMenuIndex)
            {
                case eMenuIndex.Dashboard:
                    MainViewPanel.Controls[(int)selectedMenuIndex].Visible = true;

                    disablePreviousView();
                    break;
                case eMenuIndex.Wallets:
                    //  currentIndex = (int)selectedMenuIndex;
                    MainViewPanel.Controls[(int)selectedMenuIndex].Visible = true;
                    disablePreviousView();

                    break;
                case eMenuIndex.Settings:
                    MainViewPanel.Controls[(int)selectedMenuIndex].Visible = true;
                    disablePreviousView();
                    break;

                // more 
                default:
                    return;
            }
            currentIndex = (int)selectedMenuIndex;
            disableCurrentViewButton();
            enableOtherViewsButtons();
        }

        private void btWalletsMenu_Click(object sender, EventArgs e)
        {
            selectedMenuIndex = eMenuIndex.Wallets;
            DetermineCurrentIndex();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            selectedMenuIndex= eMenuIndex.Settings;
            DetermineCurrentIndex();
        }
    }
}
