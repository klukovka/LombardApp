using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    [Serializable]
    class Client
    {
        public List<Good> GoodsInLombard;

        public Client()
        {
            GoodsInLombard = new List<Good>();
        }

        public Client(/*int id*,*/ string name, DateTime bd,
            string sex, string phone, string mail, string pass)
        {
            GoodsInLombard = new List<Good>();
        //    IdClient = id;
            NameClient = name;
            Bday = bd;
            Sex = sex;
            Phone = phone;
            Mail = mail;
            Passport = pass;
        }
      //  public int IdClient { get; set; }
        public string NameClient { get; set; }
        public DateTime Bday { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Passport { get; set; }
       

        public void Remove()
        {
           
            for(int i = 0; i < GoodsInLombard.Count; i++)
            {
                if (GoodsInLombard[i].CountDaysAfter < 0)
                    GoodsInLombard.RemoveAt(i);
            }   
        }

    }
}
