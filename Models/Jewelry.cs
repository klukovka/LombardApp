using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    [Serializable]
    class Jewelry : Good
    {

        public Jewelry() : base()
        {

        }

        public Jewelry(double weight, int purity, string nameGood, double cost,
            DateTime dateGet, int term) : base(nameGood, cost, dateGet, term)
        {
            Weight = weight;
            Purity = purity;
        }
        public double Weight { get; set; }
        public int Purity { get; set; } //проба

    }
}
