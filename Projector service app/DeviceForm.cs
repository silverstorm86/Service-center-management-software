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
    public partial class DeviceForm : Form
    {
        List<Device> devices = new List<Device>();
        DataSerializer serializer = new DataSerializer();
        public DeviceForm()
        {
            InitializeComponent();
            BindDevices();
        }
        private void BindDevices() 
        {
            try
            {
               devices = serializer.DeserializeDevice();
            }
            catch
            {
                MessageBox.Show("No writen data!");
            }

            BindingList<Device> bindingList = new BindingList<Device>(devices);
            BindingSource source = new BindingSource(bindingList, null);

            ListOfDevices.DataSource = source;

        }

        private void AddDevice_Click(object sender, EventArgs e)
        {
            devices.Add(new Device { Model = ModelText.Text, Type = TypeText.Text });
            serializer.SerializeDevice(devices);
            devices = null;
            BindDevices();
            ModelText.Text = null;
            TypeText.Text = null;
        }
    }
}
