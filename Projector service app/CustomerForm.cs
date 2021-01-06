using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Projector_service_app
{
    public partial class CustomerForm : Form
    {
        private List<Customer> customers = new List<Customer>();
        private readonly DataSerializer serializer = new DataSerializer();
        public CustomerForm()
        {
            InitializeComponent();
            BindCustomer();
        }

        private void BindCustomer()
        {
            try
            {
                customers = serializer.DeserializeCustomer();
            }
            catch
            {
                MessageBox.Show("No writen data!");
            }

            customers = customers.OrderBy(x => x.Name).ToList();
            BindingList<Customer> bindingList = new BindingList<Customer>(customers);
            BindingSource source = new BindingSource(bindingList, null);

            ListOfCustomers.DataSource = source;
            ListOfCustomers.Columns[0].Visible = false;
                                    
        }
        

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            customers.Add(new Customer {
                Id = customers.Count(),
                Name = NameText.Text,
                PostalCode = Convert.ToInt32(PostalCodeText.Text),
                Town = TownText.Text,
                Address = AddressText.Text,
                VatNum = VATText.Text,
                ContactName = ContactText.Text,
                Email = EmailText.Text,
                PhoneNum = PhoneText.Text,
            });

            serializer.SerializeCustomer(customers);

            BindCustomer();

        }

        private void PostalCodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void VATText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EmailText_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                var mail = new MailAddress(EmailText.Text);
                bool isValidEmail = mail.Host.Contains(".");
                if (!isValidEmail)
                {
                    MessageBox.Show("Not a valid e-mail address!");
                    EmailText.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not a valid e-mail address!");
                EmailText.Focus();
            }
        }

        private void PhoneText_Validating(object sender, CancelEventArgs e)
        {
             if (!Regex.Match(PhoneText.Text, "^[0-9-()/]*$").Success) 
             {
                MessageBox.Show("Not a valid phone number!");
                PhoneText.Focus();
             };
            
        }
    }         
}           