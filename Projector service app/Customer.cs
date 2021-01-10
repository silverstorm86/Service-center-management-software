using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projector_service_app
{
    //Class for the customers data
    [Serializable]
    internal class Customer
    {
        //Customer Id is always Uniqe
        public int Id { get; set; } 
        public string CompName { get; set; }
        public int  PostalCode { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public string VatNum { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }

    }
}
