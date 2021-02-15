using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    [Serializable]
    class DomesticAppl : Good
    {
        public DomesticAppl() : base()
        {

        }

        public DomesticAppl(string producer, string model, double power, string nameGood, double cost,
            DateTime dateGet, int term) : base(nameGood, cost, dateGet, term)
        {
            Producer = producer;
            Model = model;
            Power = power;
        }
        public string Producer { get; set; }
        public string Model { get; set; }
        public double Power { get; set; }
    }
}
