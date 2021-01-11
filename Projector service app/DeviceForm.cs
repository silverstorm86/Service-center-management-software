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
        private string searchTypeS = "";
        private string searchModelS = "";
        public DeviceForm()
        {
            InitializeComponent();
            BindDevices(searchTypeS, searchModelS);
            SelectVisibleOrNot.Visible = false;
        }
        private void BindDevices(string searchTypeS, string searchModelS) 
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

            if (searchTypeS != "")
            {
                List<Device> result = new List<Device>();
                for (int i = 0; i < devices.Count(); i++)
                {
                    if (devices[i].Type.ToUpper().Contains(searchTypeS.ToUpper()))
                    {
                        result.Add(devices[i]);
                    }

                }
                devices = result;
            }

            if (searchModelS != "")
            {
                List<Device> result = new List<Device>();
                for (int i = 0; i < devices.Count(); i++)
                {
                    if (devices[i].Model.ToUpper().Contains(searchModelS.ToUpper()))
                    {
                        result.Add(devices[i]);
                    }

                }
                devices = result;
            }

            BindingList<Device> bindingList = new BindingList<Device>(devices);
            BindingSource source = new BindingSource(bindingList, null);

            ListOfDevices.DataSource = source;

            ListOfDevices_VisibleChanged(this, new EventArgs());
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

                    BindDevices(searchTypeS,searchModelS);

                    ModelText.Text = string.Empty;
                    TypeText.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("Some forms are not filled out!");
        }

        private void ListOfDevices_VisibleChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ListOfDevices.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    ListOfDevices.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void SearchType_TextChanged(object sender, EventArgs e)
        {
            searchTypeS = SearchType.Text;
            searchModelS = SearchModel.Text;
            BindDevices(searchTypeS, searchModelS);
        }

        private void SearchModel_TextChanged(object sender, EventArgs e)
        {
            searchTypeS = SearchType.Text;
            searchModelS = SearchModel.Text;
            BindDevices(searchTypeS, searchModelS);
        }
    }
}
