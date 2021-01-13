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
    public partial class Status : Form
    {
        private List<Maintenance> maintenances = new List<Maintenance>();
        private readonly DataSerializer serializer = new DataSerializer();
        private NewReordForm nrf;
        public Status()
        {
            InitializeComponent();
            BindMaintenance();
        }

        private void BindMaintenance()
        {
            try
            {
                maintenances = serializer.DeserializeMaintenance();
            }
            catch
            {
                MessageBox.Show("No writen data!");
            }


            

            BindingList<Maintenance> bindingList = new BindingList<Maintenance>(maintenances);
            BindingSource source = new BindingSource(bindingList, null);

            ListOfMaintenance.DataSource = source;
            ListOfMaintenance.Columns[1].Visible = false;
            ListOfMaintenance.Columns[6].Visible = false;
            ListOfMaintenance.Columns[8].Visible = false;

        }

        private void NewRecordButton_Click(object sender, EventArgs e)
        {
            nrf = new NewReordForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            nrf.ShowDialog();
        }
    }
    
}
