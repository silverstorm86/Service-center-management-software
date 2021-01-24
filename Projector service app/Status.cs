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
        private NewRecordForm nrf;
        private InspectionForm ifr;
        private PricingForm pf;
        private int selectedRow;
        private PriceAcceptance pa;
        private ModifyRecordForm mrf;
        //Variable for selecting a row that will be modified
        private string SelectedMaintenanceNum;
        //For printing
        private Bitmap PrintPicture;
        private MoreInformation mi;
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
            ListOfMaintenance_VisibleChanged(this, new EventArgs());

        }

        private void NewRecordButton_Click(object sender, EventArgs e)
        {
            nrf = new NewRecordForm(maintenances.Count())
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            nrf.ShowDialog();

            if (nrf.DialogResult == DialogResult.OK)
            {
                Maintenance mc = nrf.mt;
                maintenances.Add(mc);
                serializer.SerializeMaintenance(maintenances);
                maintenances = null;

                BindMaintenance();
            }
        }

        private void InspectionButton_Click(object sender, EventArgs e)
        {
            if (SelectedMaintenanceNum != default)
            {
                ifr = new InspectionForm
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                ifr.ShowDialog();

                if (ifr.DialogResult == DialogResult.OK)
                {
                    foreach (var num in maintenances)
                    {
                        if (num.Id.Equals(SelectedMaintenanceNum))
                        {
                            num.RepairDescription = ifr.RepairDescription;
                            num.MaterialCost = ifr.MaterialCost;
                        }
                    }

                    serializer.SerializeMaintenance(maintenances);
                    maintenances = null;

                    BindMaintenance();
                }
            }
            else
                MessageBox.Show("First select a row!");
        }
        //Getting the id from the selected row
        private void ListOfMaintenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            SelectedMaintenanceNum = ListOfMaintenance.Rows[selectedRow].Cells[0].Value.ToString();
        }
        //Adding the color to the datagridview if something changes in it

        private void ListOfMaintenance_VisibleChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ListOfMaintenance.Rows.Count; i++)
            {
                if (Convert.ToDateTime(ListOfMaintenance.Rows[i].Cells[7].Value) != default)
                {
                    ListOfMaintenance.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
                if (Convert.ToInt32(ListOfMaintenance.Rows[i].Cells[9].Value) > 0)
                {
                    ListOfMaintenance.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
                }
                if (Convert.ToDateTime(ListOfMaintenance.Rows[i].Cells[10].Value) != default)
                {
                    ListOfMaintenance.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (Convert.ToDateTime(ListOfMaintenance.Rows[i].Cells[13].Value) != default)
                {
                    ListOfMaintenance.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
                if (Convert.ToDateTime(ListOfMaintenance.Rows[i].Cells[14].Value) != default)
                {
                    ListOfMaintenance.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                if (Convert.ToDateTime(ListOfMaintenance.Rows[i].Cells[15].Value) != default)
                {
                    ListOfMaintenance.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
            }
        }
        //Adding the prices to the list
        private void PricingButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ListOfMaintenance.Rows[selectedRow].Cells[9].Value) > 0 && Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[10].Value) == default)
            {

                if (SelectedMaintenanceNum != default)
                {
                    pf = new PricingForm()
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    pf.ShowDialog();

                    if (pf.DialogResult == DialogResult.OK)
                    {
                        foreach (var num in maintenances)
                        {
                            if (num.Id.Equals(SelectedMaintenanceNum))
                            {
                                num.Offer = pf.Offer;
                                num.OfferDate = DateTime.Now.Date;
                            }
                        }

                        serializer.SerializeMaintenance(maintenances);
                        maintenances = null;

                        BindMaintenance();
                    }
                }
            }
            else
                MessageBox.Show("You must select inspected device!");

        }
        //Accept or not the repair cost by he customer
        private void PriceAcceptanceButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ListOfMaintenance.Rows[selectedRow].Cells[9].Value) > 0 && Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[10].Value) != default &&
                Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[13].Value) == default)
            {
                if (SelectedMaintenanceNum != default)
                {
                    pa = new PriceAcceptance()
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    pa.ShowDialog();

                    if (pa.DialogResult == DialogResult.Yes)
                    {
                        foreach (var num in maintenances)
                        {
                            if (num.Id.Equals(SelectedMaintenanceNum))
                            {
                                num.FixOrNot = true;
                                num.RepairStartDate = DateTime.Now.Date;
                            }
                        }
                        serializer.SerializeMaintenance(maintenances);
                        maintenances = null;

                        BindMaintenance();
                    }
                    else if (pa.DialogResult == DialogResult.No)
                    {
                        foreach (var num in maintenances)
                        {
                            if (num.Id.Equals(SelectedMaintenanceNum))
                            {
                                num.FixOrNot = false;
                                num.RepairStartDate = DateTime.Now.Date;
                                num.RepairFinishDate = DateTime.Now.Date;
                            }
                        }
                        serializer.SerializeMaintenance(maintenances);
                        maintenances = null;

                        BindMaintenance();
                    }
                }
                else
                    MessageBox.Show("You must select inspected device!");
            }
            else
                MessageBox.Show("Some requirment are not met!");
        }

        //Repair finished
        private void RepairCompleteButton_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(ListOfMaintenance.Rows[selectedRow].Cells[9].Value) > 0 && Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[10].Value) != default
                && Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[13].Value) != default && Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[14].Value) == default)
            {
                if (SelectedMaintenanceNum != default)
                {
                    foreach (var num in maintenances)
                    {
                        if (num.Id.Equals(SelectedMaintenanceNum))
                        {
                            num.RepairFinishDate = DateTime.Now.Date;
                        }
                    }

                    serializer.SerializeMaintenance(maintenances);
                    maintenances = null;

                    BindMaintenance();
                }
                else
                    MessageBox.Show("You must select inspected device!");
            }
            else
                MessageBox.Show("Some requirment are not met!");
        }
        //Customer gone with the device
        private void TakeoverButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ListOfMaintenance.Rows[selectedRow].Cells[9].Value) > 0 && Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[10].Value) != default
               && Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[13].Value) != default && Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[14].Value) != default &&
               Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[15].Value) == default)
            {
                if (SelectedMaintenanceNum != default)
                {
                    foreach (var num in maintenances)
                    {
                        if (num.Id.Equals(SelectedMaintenanceNum))
                        {
                            num.OutDate = DateTime.Now.Date;
                        }
                    }

                    serializer.SerializeMaintenance(maintenances);
                    maintenances = null;

                    BindMaintenance();
                }
                else
                    MessageBox.Show("You must select inspected device!");
            }
            else
                MessageBox.Show("Some requirment are not met!");
        }
        //Activazing modify button
        private void Modify_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(ListOfMaintenance.Rows[selectedRow].Cells[15].Value) == default)
            {
                if (SelectedMaintenanceNum != default)
                {
                    foreach (var num in maintenances)
                    {
                        if (num.Id.Equals(SelectedMaintenanceNum))
                        {
                            mrf = new ModifyRecordForm(num)
                            {
                                StartPosition = FormStartPosition.CenterScreen
                            };
                        }
                    }
                    
                    mrf.ShowDialog();
                    if (mrf.DialogResult == DialogResult.OK)
                    {
                        foreach (var num in maintenances)
                        {
                            if (num.Id.Equals(SelectedMaintenanceNum))
                            {
                                num.CustomerId = mrf.Mainnew.CustomerId;
                                num.CustomerCompName = mrf.Mainnew.CustomerCompName;
                                num.DeviceType = mrf.Mainnew.DeviceType;
                                num.DeviceModel = mrf.Mainnew.DeviceModel;
                                num.SerialNumber = mrf.Mainnew.SerialNumber;
                                num.ErrorDescription = mrf.Mainnew.ErrorDescription;
                                num.RepairDescription = mrf.Mainnew.RepairDescription;
                                num.MaterialCost = mrf.Mainnew.MaterialCost;
                                num.Offer = mrf.Mainnew.Offer;
                            }
                        }
                    }

                    serializer.SerializeMaintenance(maintenances);
                    maintenances = null;

                    BindMaintenance();
                }
                else
                    MessageBox.Show("You must select inspected device!");
            }
            else
                MessageBox.Show("You can't modify finished device!");
        }
        //Methods for printing doument
        private void PrintDocumentMI_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(PrintPicture, e.PageBounds);
        }

        private void MoreInfo_Click(object sender, EventArgs e)
        {

            if (SelectedMaintenanceNum != default)
            {
                mi = new MoreInformation(SelectedMaintenanceNum);
                PrintPicture = new Bitmap(mi.Width, mi.Height);
                PrintPicture.SetResolution(150, 150);
                mi.DrawToBitmap(PrintPicture, new Rectangle(0, 0, PrintPicture.Width, PrintPicture.Height));
                PrintPreviewDialogMoreInfo.Document = PrintDocumentMI;
                PrintPreviewDialogMoreInfo.StartPosition = FormStartPosition.CenterScreen;

                PrintPreviewDialogMoreInfo.ClientSize = new System.Drawing.Size(PrintPicture.Width, PrintPicture.Height);
                PrintPreviewDialogMoreInfo.ShowDialog();
            }
            else
                MessageBox.Show("You must select inspected device!");
        }
    }
    
}
