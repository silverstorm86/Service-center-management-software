using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projector_service_app
{
    //Class for the devices data
    [Serializable]
    class Device
    {
        public string Type { get; set; }
        //Model is always uniqe
        public string Model { get; set; }
        
    }
}
