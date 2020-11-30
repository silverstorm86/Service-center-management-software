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
    public partial class Form1 : Form
    {
        /*List<Customer> cm;
        
        DataSerializer c = new DataSerializer();*/
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            cm = new List<Customer>();

            c.SerializeCustomer(cm);
            List<Customer> cs = c.DeserializeCustomer();

            var bindingList = new BindingList<Customer>(cs);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }*/
    }
}
