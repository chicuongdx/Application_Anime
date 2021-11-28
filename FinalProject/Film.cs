using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Film : UserControl
    {
        public Film()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler PictureBoxClick;

        private void pctImage_Click(object sender, EventArgs e)
        {
            if (this.PictureBoxClick != null)
                this.PictureBoxClick(this, e);
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            if (this.PictureBoxClick != null)
                this.PictureBoxClick(this, e);
        }
    }
}
