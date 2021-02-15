using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    [Serializable]
    class Clothes : Good
    {
        public Clothes() : base()
        {

        }

        public Clothes(int size, double height, string fabric, string nameGood, double cost,
            DateTime dateGet, int term) : base(nameGood, cost, dateGet, term)
        {
            Size = size;
            Height = height;
            Fabric = fabric;
        }

        public int Size { get; set; }
        public double Height { get; set; }
        public string Fabric { get; set; }
    }
}
