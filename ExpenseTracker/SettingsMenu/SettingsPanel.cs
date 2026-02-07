using ExpenseTracker.DashBoard_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.SettingsMenu
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {
            InitializeComponent();
           
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.DragEnter += flowLayoutPanel1_DragEnter;
            flowLayoutPanel1.DragOver += Panel_DragOver;

            // 3. Load data
            LoadWallets();

        }
        private Control _draggedItem;

        private void LoadWallets()
        {
            for (int i = 5; i > 0; i--)
            {
                WalletCard card = new WalletCard();

                card.WalletName = "Wallet" + DateTime.Now.Ticks;
                card.WalletBalance = (i * 100).ToString() + " USD";
                card.MouseDown += Wallet_MouseDown;
               
                foreach (Control child in card.Controls)
                {
                    child.MouseDown += Wallet_MouseDown;
                }
                card.Width = flowLayoutPanel1.ClientSize.Width - 40; // Full width minus scrollbar space
                flowLayoutPanel1.Controls.Add(card);
            }

            
        }
        //private void AddWalletToPanel()
        //{
        //    WalletCard card = new WalletCard();
        //    card.Name = "Wallet" + DateTime.Now.Ticks;
            
        //    card.Width = flowLayoutPanel1.ClientSize.Width - 40; // Full width minus scrollbar space
        //    // --- ENABLE DRAGGING ---
        //    // A. Allow the user to click and drag this card
        //    card.MouseDown += Wallet_MouseDown;

        //    // B. Allow the specific card to accept drops (optional, but good for smoothness)
        //    card.AllowDrop = true;

        //    // C. Add to panel
        //    flowLayoutPanel1.Controls.Add(card);
        //}

        // 2. Configure the Panel itself in the Constructor or Form_Load
        public void SetupPanel()
        {
            
            flowLayoutPanel1.DragEnter += flowLayoutPanel1_DragEnter;
            flowLayoutPanel1.DragOver += Panel_DragOver;
        }
        // EVENT 1: User clicks the wallet to start dragging
        private void Wallet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control c = sender as Control;

                // If we clicked a Label, climb up until we find the WalletCard
                while (c != null && !(c is WalletCard))
                {
                    c = c.Parent;
                }

                _draggedItem = c;

                // Start the drag only if we found a valid card
                if (_draggedItem != null)
                {
                    _draggedItem.DoDragDrop(_draggedItem, DragDropEffects.Move);
                }
            }

            }

        // EVENT 2: The mouse enters the panel area
      

        // EVENT 3: The magic "Live Reordering"
        private void Panel_DragOver(object sender, DragEventArgs e)
        {
            Point clientPoint = flowLayoutPanel1.PointToClient(new Point(e.X, e.Y));
            Control itemUnderMouse = flowLayoutPanel1.GetChildAtPoint(clientPoint)!;

            // 2. Check if we are hovering over a DIFFERENT wallet
            if (itemUnderMouse != null && itemUnderMouse != _draggedItem)
            {
                // 3. Get the exact positions (Indices) of both items
                int myIndex = flowLayoutPanel1.Controls.GetChildIndex(_draggedItem);
                int targetIndex = flowLayoutPanel1.Controls.GetChildIndex(itemUnderMouse);

                // 4. THE SWAP LOGIC
                // We temporarily move the target to MY spot, then move ME to the target's spot.
                // This effectively trades their places.

                flowLayoutPanel1.Controls.SetChildIndex(itemUnderMouse, myIndex);
                flowLayoutPanel1.Controls.SetChildIndex(_draggedItem, targetIndex);

                // 5. Force a redraw so you see it happen instantly
                flowLayoutPanel1.Invalidate();
            }
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (_draggedItem != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        }
}
