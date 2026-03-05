using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class MultiUseRectangle : UserControl
    {
        public MultiUseRectangle()
        {
            InitializeComponent();
        }

        public void setBigText(string text)
        {
            lbDays.Text = text;
        }
        public void setText(string text)
        {
            lbText.Text = text;
        }
    }
}
