using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projector_service_app
{
    public partial class PriceAcceptance : Form
    {
        internal bool decide;
        public PriceAcceptance()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            decide = true;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            decide = false;
        }
    }
}
