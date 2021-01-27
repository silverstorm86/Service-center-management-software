using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projector_service_app
{
    public partial class MoreInformation : UserControl
    {
        readonly DataSerializer serializer = new DataSerializer();
        List<Maintenance> maintenances = new List<Maintenance>();
        List<Customer> customers = new List<Customer>();
        Maintenance resultM = new Maintenance();
        Customer resultC = new Customer();



        public MoreInformation(string SelectedNum)
        {
            InitializeComponent();
            BindAll();
            GetSelection(SelectedNum);
            WriteCustomerData(resultC);
            DeviceData(resultM);
            ErrorData(resultM);
            RepairData(resultM);
            Offer(resultM);
            FixNot(resultM);
            RepairProcess(resultM);
            TakeOver(resultM);
        }
        private void BindAll()
        {
            try
            {
                maintenances = serializer.DeserializeMaintenance();
            }
            catch
            {
                MessageBox.Show("No writen data!");
            }

           try
            {
                customers = serializer.DeserializeCustomer();
            }
            catch
            {
                MessageBox.Show("No writen data!");
            }
        }
        private void GetSelection(string SelectedNum)
        {
            for (int i = 0; i < maintenances.Count; i++)
            {
                if (maintenances[i].Id.Equals(SelectedNum))
                {
                    resultM = maintenances[i];
                }
            }

            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id.Equals(resultM.CustomerId))
                {
                    resultC = customers[i];
                }
            }
        }
        private void WriteCustomerData(Customer resultC) 
        {
            CompName.Text = resultC.CompName;
            PostalCode.Text = resultC.PostalCode.ToString();
            Town.Text = resultC.Town;
            Address.Text = resultC.Address;
            ContactName.Text = resultC.ContactName;
            VatNum.Text = resultC.VatNum;
            PhoneNum.Text = resultC.PhoneNum;
            Email.Text = resultC.Email;

        }
        private void DeviceData(Maintenance resultM)
        {
            MaintNumber.Text = resultM.Id;
            DeviceType.Text = resultM.DeviceType;
            DeviceModel.Text = resultM.DeviceModel;
            DeviceSerial.Text = resultM.SerialNumber;
        }

        private void ErrorData(Maintenance resultM)
        {
            InDate.Text = resultM.InDate.ToString("yyyy-MM-dd");
            ErrorDesc.Text = resultM.ErrorDescription;
        }
        private void RepairData(Maintenance resultM)
        {
            if (resultM.RepairDescription != default)
            {
                RepairDescText.Text = resultM.RepairDescription;
                CostMat.Text = resultM.MaterialCost.ToString();
            }
            else
                Diagnosis.Visible = false;
        }
        private void Offer(Maintenance resultM)
        {
            if (resultM.Offer > 0)
            {
                OfferDate.Text = resultM.OfferDate.ToString("yyyy-MM-dd");
                OfferCost.Text = resultM.Offer.ToString();
            }
            else
                OfferGroup.Visible = false;
        }
        private void FixNot(Maintenance resultM)
        {
            if (resultM.FixOrNot != default)
            {
                if (resultM.FixOrNot != true)
                {
                    FixOrNot.Text = "Not for fixing!";
                }
                else
                    FixOrNot.Text = "Fix!";
            }
            else
                FixOrNot.Visible = false;
        }
        private void RepairProcess(Maintenance resultM)
        {
            if (resultM.RepairStartDate != default)
            {
                RepStart.Text = resultM.RepairStartDate.ToString("yyyy-MM-dd");
                RepFinish.Text = resultM.RepairFinishDate.ToString("yyyy-MM-dd");
            }
            else
            {
                RepairPro.Visible = false;
            }
        }

        private void TakeOver(Maintenance resultM)
        {
            if (resultM.OutDate != default)
            {
                TakeOverDate.Text = resultM.OutDate.ToString("yyyy-MM-dd");
            }
            else
                TakeOverGroup.Visible = false;
        }
    }
}
