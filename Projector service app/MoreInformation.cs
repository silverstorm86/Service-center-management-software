using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projector_service_app
{
    public partial class MoreInformation : UserControl
    {
        readonly DataSerializer serializer = new DataSerializer();
        List<Maintenance> maintenances = new List<Maintenance>();
        List<Customer> customers = new List<Customer>();
        Maintenance resultM = new Maintenance();
        Customer resultC = new Customer();


        public MoreInformation(string SelectedNum)
        {
            InitializeComponent();
            BindAll();
            GetSelection(SelectedNum);
            WriteCustomerData(resultC);
        }
        private void BindAll()
        {
            try
            {
                maintenances = serializer.DeserializeMaintenance();
            }
            catch
            {
                MessageBox.Show("No writen data!");
            }

           try
            {
                customers = serializer.DeserializeCustomer();
            }
            catch
            {
                MessageBox.Show("No writen data!");
            }
        }
        private void GetSelection(string SelectedNum)
        {
            for (int i = 0; i < maintenances.Count; i++)
            {
                if (maintenances[i].Id.Equals(SelectedNum))
                {
                    resultM = maintenances[i];
                }
            }

            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id.Equals(resultM.CustomerId))
                {
                    resultC = customers[i];
                }
            }
        }
        private void WriteCustomerData(Customer resultC) 
        {
            CompName.Text = resultC.CompName;
            PostalCode.Text = resultC.PostalCode.ToString();
            Town.Text = resultC.Town;
            Address.Text = resultC.Address;
            ContactName.Text = resultC.ContactName;
            VatNum.Text = resultC.VatNum;
            PhoneNum.Text = resultC.PhoneNum;
            Email.Text = resultC.Email;

        }
    }
}
