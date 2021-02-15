using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    [Serializable]
    class Apartment : Good
    {
        public Apartment() : base()
        {

        }

        public Apartment(string adress, string technicalPass, string owner, double square, int rooms,
         int floor, string nameGood, double cost,
            DateTime dateGet, int term) : base(nameGood, cost, dateGet, term)
        {
            Adress = adress;
            TechnicalPass = technicalPass;
            Owner = owner;
            Square = square;
            Rooms = rooms;
            Floor = floor;
        }
        public string Adress { get; set; }
        public string TechnicalPass { get; set; }
        public string Owner { get; set; }
        public double Square { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }

    }
}
