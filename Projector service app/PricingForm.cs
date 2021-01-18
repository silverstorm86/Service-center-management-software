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
    public partial class PricingForm : Form
    {
        //Adding just one variable for the proce or too say for offer the date of offer will be automated
        internal int Offer { get; set; }
        public PricingForm()
        {
            InitializeComponent();
        }
        //Just number is alowed
        private void OfferPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Occurs after button is clicked
        private void OfferAdd_Click(object sender, EventArgs e)
        {
            if (OfferPrice != default)
            {
                Offer = Convert.ToInt32(OfferPrice.Text);
            }
            else
                MessageBox.Show("First write the price!");
        }
    }
}
