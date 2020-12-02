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
    public partial class Form1 : Form
    {
        /*List<Customer> cm;
        
        DataSerializer c = new DataSerializer();*/
        public Form1()
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
