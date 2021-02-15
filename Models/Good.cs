using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    [Serializable]
    public abstract class Good
    {
        public Good()
        {
            Percent = 0.01;
        }
        public Good(string nameGood, double cost, DateTime dateGet, int term )//, int id)
        {
            NameGood = nameGood;
            Cost = cost;
            DateGet = dateGet;
            Term = term;
            Percent = 0.01;
         //   IdGood = id;

        }
     //   public int IdGood { get; set; }
        public string NameGood { get; set; }
        public double Cost { get; set; }
        public DateTime DateGet { get; set; }
        public int Term { get; set; }
        public static double Percent { get; set; }
        public DateTime DateTake
        {
            get => DateGet.AddDays(Term);
        }
        public int CountDaysBefore
        {
            get
            {
                TimeSpan time = DateTime.Now - DateGet;
                return time.Days;
            }
        }

        public int CountDaysAfter
        {
            get
            {
                TimeSpan time = DateTake - DateTime.Now;
                return time.Days;
            }
        }

        public double Summa
        {
            get => Cost * 0.7;
        }
       
    }
}
