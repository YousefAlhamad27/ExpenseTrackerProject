using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class PlaceholderTextBox : TextBox
    {
        // Import the Windows function to set the "Cue Banner" (Placeholder)
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;
        private string _placeholderText = "";

        // Add a property to the Properties Panel
        public string PlaceholderText
        {
            get => _placeholderText;
            set
            {
                _placeholderText = value;
                UpdateCueBanner();
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateCueBanner(); // Apply it when the control is created
        }

        private void UpdateCueBanner()
        {
            // The '1' in wParam keeps the text visible even when the box has focus
            SendMessage(this.Handle, EM_SETCUEBANNER, 1, _placeholderText);
        }
    }
}