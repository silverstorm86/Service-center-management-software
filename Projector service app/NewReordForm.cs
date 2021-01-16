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
    public partial class NewReordForm : Form
    {
        private CustomerForm cf;
        private DeviceForm df;
        internal Maintenance mt;
        public NewReordForm(int number)
        {
            InitializeComponent();
            MaintaneID(number);
        }

        
        private void MaintaneID(int number)
        {
            MaintanceNumber.Text = (number + 1).ToString() + "MN" + DateTime.Now.Year.ToString();
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
            }
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            if (MaintanceNumber.Text != null && CustomerID.Text != "Customer not selected"  && CustomerName.Text != "Customer not selected" &&
                DeviceModel.Text != "Device not selected" && DeviceType.Text != "Device not selected" && SerialText.Text != null && ErrorText.Text != null)
            {
                mt = new Maintenance
                {
                    Id = MaintanceNumber.Text,
                    CustomerId = Convert.ToInt32(CustomerID.Text),
                    CustomerCompName = CustomerName.Text,
                    DeviceType = DeviceType.Text,
                    DeviceModel = DeviceModel.Text,
                    SerialNumber = SerialText.Text,
                    ErrorDescription = ErrorText.Text
                };


                if (mt != default)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else 
            {
                MessageBox.Show("Some fields are empty or not selected!");
            }
            
            
        }
    }
}
