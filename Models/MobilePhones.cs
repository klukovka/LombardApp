using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    [Serializable]
    class MobilePhones : Good
    {
        public MobilePhones() : base()
        {

        }

        public MobilePhones(string producer, string model, string serialNumber, int imei, string nameGood, double cost,
            DateTime dateGet, int term) : base(nameGood, cost, dateGet, term)
        {
            Producer = producer;
            Model = model;
            SerialNumber = serialNumber;
            Imei = imei;
        }
        public string Producer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public int Imei { get; set; }
    }
}
