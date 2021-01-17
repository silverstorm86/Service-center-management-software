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
using System.Windows.Documents;

namespace Projector_service_app
{
    public partial class CustomerForm : Form
    {
        private List<Customer> customers = new List<Customer>();
        private readonly DataSerializer serializer = new DataSerializer();
        private string searchWord = "";
        internal Customer SelectedCustomer { get; set; }
        public CustomerForm(int select)
        {
            InitializeComponent();
            BindCustomer(searchWord);
            
            if(select < 1)
            {
                SelectVisibleOrNot.Visible = false;
            }
        }

        private void BindCustomer(string searchWord)
        {
            try
            {
                customers = serializer.DeserializeCustomer();
            }
            catch
            {
                MessageBox.Show("No writen data!");
            }
            customers = customers.OrderBy(x => x.CompName).ToList();

            if (searchWord != "")
            {
                List<Customer> result = new List<Customer>();
                for (int i = 0; i < customers.Count(); i++)
                {
                   if (customers[i].CompName.ToUpper().Contains(searchWord.ToUpper()))
                    {
                        result.Add(customers[i]);
                    }
                    
                }
                customers = result;
            }

            

            BindingList<Customer> bindingList = new BindingList<Customer>(customers);
            BindingSource source = new BindingSource(bindingList, null);

            ListOfCustomers.DataSource = source;
            ListOfCustomers.Columns[0].Visible = false;
                                    
        }
        private void ClearTextboxes()
        {

            NameText.Text = string.Empty;
            PostalCodeText.Text = string.Empty;
            TownText.Text = string.Empty;
            AddressText.Text = string.Empty;
            VATText.Text = string.Empty;
            ContactText.Text = string.Empty;
            EmailText.Text = string.Empty;
            PhoneText.Text = string.Empty;

        }
        //Method for adding new customer
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            customers.Add(new Customer {
                Id = customers.Count(),
                CompName = NameText.Text,
                PostalCode = Convert.ToInt32(PostalCodeText.Text),
                Town = TownText.Text,
                Address = AddressText.Text,
                VatNum = VATText.Text,
                ContactName = ContactText.Text,
                Email = EmailText.Text,
                PhoneNum = PhoneText.Text,
            });

            serializer.SerializeCustomer(customers);

            BindCustomer(searchWord);

            ListOfCustomers_VisibleChanged(this, new EventArgs());

            ClearTextboxes();
        }
               
        //Method enables just pressing numbers
        private void PostalCodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Method enables just pressing numbers
        private void VATText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Validating email address
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
        //Validating Phone number with regex
        private void PhoneText_Validating(object sender, CancelEventArgs e)
        {
             if (!Regex.Match(PhoneText.Text, "^[0-9-()/]*$").Success) 
             {
                MessageBox.Show("Not a valid phone number!");
                PhoneText.Focus();
             };
            
        }

        private void CompanySearchText_TextChanged(object sender, EventArgs e)
        {
            searchWord = CompanySearchText.Text;
            BindCustomer(searchWord);
        }

        private void ListOfCustomers_VisibleChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ListOfCustomers.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    ListOfCustomers.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        

        private void ListOfCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCustomer = (Customer)ListOfCustomers.CurrentRow.DataBoundItem;
        }
                
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (SelectedCustomer != default)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("First choose a customer!");
            }
        }
    }         
}           