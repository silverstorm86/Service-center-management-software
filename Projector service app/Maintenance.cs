using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projector_service_app
{
    //Class for the process of maintenance
    [Serializable]
    class Maintenance
    {
        //The CustomerId and the DeviceModel are from other class
        public string Id { get; set; }
        public int CustomerId { get; set; }
        public string DeviceModel { get; set; }
        public string SerialNumber { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime InDate { get; set; }
        public DateTime RepairStartDate { get; set; }
        public int MaterialCost { get; set; }
        public DateTime OfferDate { get; set; }
        public int Offer { get; set; }
        public bool FixOrNot { get; set; }
        public DateTime RepairFinishDate { get; set; }
        public DateTime OutDate { get; set; }

    }
}
