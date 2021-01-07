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
        private List<Device> devices = new List<Device>();
        private readonly DataSerializer serializer = new DataSerializer();
        public DeviceForm()
        {
            InitializeComponent();
            BindDevices();
            SelectVisibleOrNot.Visible = false;
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

            devices = devices.OrderBy(x => x.Type).ToList();

            BindingList<Device> bindingList = new BindingList<Device>(devices);
            BindingSource source = new BindingSource(bindingList, null);

            ListOfDevices.DataSource = source;
        }

        private void AddDevice_Click(object sender, EventArgs e)
        {
            var findTheSame = from s in devices
                          where s.Model == ModelText.Text
                          select s.Model;
            if (ModelText.Text != "" && TypeText.Text != "")
            {
                if (findTheSame.Count() != 0)
                {
                    MessageBox.Show("The model must be unique!");
                }
                else
                {
                    devices.Add(new Device { Model = ModelText.Text, Type = TypeText.Text });
                    serializer.SerializeDevice(devices);
                    devices = null;
                    BindDevices();
                    ModelText.Text = null;
                    TypeText.Text = null;
                }
            }
            else
                MessageBox.Show("Some forms are not filled out!");
        }
    }
}
