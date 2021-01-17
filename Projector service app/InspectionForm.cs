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
    public partial class InspectionForm : Form
    {
        //Variable that will be filled with info
        internal string RepairDescription { get; set; }
        internal int MaterialCost { get; set; }
        public InspectionForm()
        {
            InitializeComponent();
        }

        //Enable just numbers
        private void MaterialCostText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Validating data and activating the button
        private void RepairDescriptionText_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(RepairDescriptionText.Text))
            {
                if (!String.IsNullOrEmpty(MaterialCostText.Text))
                {
                    MaterialCost = Convert.ToInt32(MaterialCostText.Text);
                    AddButton.Enabled = true;
                }
                else
                    MaterialCostText.Focus();

                RepairDescription = RepairDescriptionText.Text;
            }
            else
                RepairDescriptionText.Focus();
        }

        //Validating data and activating the button
        private void MaterialCostText_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(MaterialCostText.Text))
            {
                if (!String.IsNullOrEmpty(RepairDescriptionText.Text))
                {
                    RepairDescription = RepairDescriptionText.Text;
                    AddButton.Enabled = true;
                }
                else
                    RepairDescriptionText.Focus();

                MaterialCost = Convert.ToInt32(MaterialCostText.Text);
            }
            else
                MaterialCostText.Focus();
        }
    }
}
