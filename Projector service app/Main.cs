using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projector_service_app
{
    public partial class Main : Form
    {
        private CustomerForm cf;
        private DeviceForm df;
        private Status st;
        public Main()
        {
            InitializeComponent();
            BorderRounded();
        }

        private void BorderRounded()
        {
            GraphicsPath graphicpath = new GraphicsPath();
            graphicpath.StartFigure();
            graphicpath.AddArc(0, 0, 40, 40, 180, 90);
            graphicpath.AddLine(40, 0, this.Width - 40, 0);
            graphicpath.AddArc(this.Width - 40, 0, 40, 40, 270, 90);
            graphicpath.AddLine(this.Width, 40, this.Width, this.Height - 25);
            graphicpath.AddArc(this.Width - 40, this.Height - 40, 40, 40, 0, 90);
            graphicpath.AddLine(this.Width - 40, this.Height, 40, this.Height);
            graphicpath.AddArc(0, this.Height - 40, 40, 40, 90, 90);
            graphicpath.CloseFigure();
            this.Region = new Region(graphicpath);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DevicesButtonActivate()
        {
            df = new DeviceForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            df.ShowDialog();
        }
        private void Devices_Click(object sender, EventArgs e)
        {
            DevicesButtonActivate();
        }

        private void DevicesLabel_Click(object sender, EventArgs e)
        {
            DevicesButtonActivate();
        }
        private void CustomersButtonActivate()
        {
            cf = new CustomerForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            cf.ShowDialog();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            CustomersButtonActivate();
        }

        private void CustomerLabel_Click(object sender, EventArgs e)
        {
            CustomersButtonActivate();
        }
        private void StatusButtonActivate() 
        {
            st = new Status
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            st.ShowDialog();
        }


        private void Status_Click(object sender, EventArgs e)
        {
            StatusButtonActivate();
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
            StatusButtonActivate();
        }
    }
}
