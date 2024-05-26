using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpButtonLibrary
{
    public partial class HelpButtonControl : UserControl
    {
        public event EventHandler ExitClicked;
        public HelpButtonControl()
        {
            InitializeComponent();
        }

        private void pbExitHelp_Click(object sender, EventArgs e)
        {
            ExitClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
