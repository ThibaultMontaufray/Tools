using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools.Utilities.UI.Graphics
{
    public partial class ElementTile : UserControl
    {
        public ElementTile()
        {
            InitializeComponent();
        }

        private void ElementTile_MouseHover(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.BackColor = Color.FromArgb(100, 37, 37, 37);
            this.buttonClose.Visible = true;
            this.ResumeLayout();
        }
        private void ElementTile_MouseLeave(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.BackColor = Color.Transparent;
            this.buttonClose.Visible = false;
            this.ResumeLayout();
        }
    }
}
