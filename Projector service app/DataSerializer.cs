using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Projector_service_app
{
    internal class DataSerializer
    {
        //Serialize all the data for later use
        //Getting data for the app by Deserialize

        internal void SerializeCustomer(List<Customer> input)
        {
            using (FileStream fileStream = new FileStream("Customer.psa", FileMode.Create, FileAccess.Write))
            {                
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, input);
            }
        }
        internal List<Customer> DeserializeCustomer()
        {

            using (FileStream fileStream = new FileStream("Customer.psa", FileMode.Open, FileAccess.Read))
            {
                List<Customer> output = new List<Customer>();

                BinaryFormatter formatter = new BinaryFormatter();
                output = (List<Customer>)formatter.Deserialize(fileStream);

                return output;
            }
        }
        internal void SerializeDevice(List<Device> input)
        {
            using (FileStream fileStream = new FileStream("Device.psa", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, input);
            }
        }
        internal List<Device> DeserializeDevice()
        {

            using (FileStream fileStream = new FileStream("Device.psa", FileMode.Open, FileAccess.Read))
            {
                List<Device> output = new List<Device>();

                BinaryFormatter formatter = new BinaryFormatter();
                output = (List<Device>)formatter.Deserialize(fileStream);

                return output;
            }
        }
        internal void SerializeMaintenance(List<Maintenance> input)
        {
            using (FileStream fileStream = new FileStream("Maintenance.psa", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, input);
            }
        }
        internal List<Maintenance> DeserializeMaintenance()
        {

            using (FileStream fileStream = new FileStream("Maintenance.psa", FileMode.Open, FileAccess.Read))
            {
                List<Maintenance> output = new List<Maintenance>();

                BinaryFormatter formatter = new BinaryFormatter();
                output = (List<Maintenance>)formatter.Deserialize(fileStream);

                return output;
            }
        }
    }
}
