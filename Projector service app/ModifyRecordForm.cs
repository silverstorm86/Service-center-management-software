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
    public partial class ModifyRecordForm : Form
    {
        
        internal Maintenance Mainnew { get; set; }
        private CustomerForm cf;
        private DeviceForm df;
        internal ModifyRecordForm(Maintenance mainold)
        {
            InitializeComponent();
            FillTheForm(mainold);
        }
        private void FillTheForm(Maintenance mainold)
        {
            RepairDescriptionText.Enabled = false;
            MaterialCostText.Enabled = false;
            OfferPrice.Enabled = false;
            MaintanceNumber.Text = mainold.Id;
            CustomerID.Text = mainold.CustomerId.ToString();
            CustomerName.Text = mainold.CustomerCompName;
            DeviceType.Text = mainold.DeviceType;
            DeviceModel.Text = mainold.DeviceModel;
            SerialText.Text = mainold.SerialNumber;
            ErrorText.Text = mainold.ErrorDescription;
            if (mainold.RepairDescription != default)
            {
                RepairDescriptionText.Enabled = true;
                RepairDescriptionText.Text = mainold.RepairDescription;
            }
            if (mainold.MaterialCost > 0)
            {
                MaterialCostText.Enabled = true;
                MaterialCostText.Text = mainold.MaterialCost.ToString();
            }
            if (mainold.Offer > 0)
            {
                OfferPrice.Enabled = true;
                OfferPrice.Text = mainold.Offer.ToString();
            }
            Mainnew = mainold;
        }

        private void SelectCustomerButton_Click(object sender, EventArgs e)
        {
            cf = new CustomerForm(1)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            cf.ShowDialog();

            if (cf.DialogResult == DialogResult.OK)
            {
                Customer cm = cf.SelectedCustomer;
                CustomerID.Text = cm.Id.ToString();
                CustomerName.Text = cm.CompName.ToString();
                Mainnew.CustomerId = cm.Id;
                Mainnew.CustomerCompName = cm.CompName;
            }
        }

        private void DeviceSelectButton_Click(object sender, EventArgs e)
        {
            df = new DeviceForm(1)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            df.ShowDialog();

            if (df.DialogResult == DialogResult.OK)
            {
                Device dc = df.SelectedDevice;
                DeviceModel.Text = dc.Model;
                DeviceType.Text = dc.Type;
                Mainnew.DeviceModel = dc.Model;
                Mainnew.DeviceType = dc.Type;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Mainnew.SerialNumber = SerialText.Text;
            Mainnew.ErrorDescription = ErrorText.Text;
            Mainnew.RepairDescription = RepairDescriptionText.Text;
            Mainnew.MaterialCost = Convert.ToInt32(MaterialCostText.Text);
            Mainnew.Offer = Convert.ToInt32(OfferPrice.Text);

        }
    }
}
