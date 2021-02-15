using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace LombardApp.Models
{
    [Serializable]
    class Lombard
    {

        public List<Client> Clients { get; set; }
        public double Summa { get; set; }
        public double Percent { get; set; }

        public Lombard()
        {
            Clients = new List<Client>();
            Summa = 100000;
            Percent = 0.3;
        }

        public Lombard(Lombard lombard, double S)
        {
            this.Clients = lombard.Clients;
            this.Percent = lombard.Percent;
            this.Summa = S;
        }

        public void Profit()
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                foreach(Good good in Clients[i].GoodsInLombard)
                {
                    if (good.CountDaysAfter < 0)
                        Summa += good.Cost * (1 + Percent);
                }
                Clients[i].Remove();
            }
        }

        public void Profit(int idClient, int idGood)
        {
            var good = Clients[idClient].GoodsInLombard[idGood];
            Summa += good.Summa;
            Summa += good.Summa * (1 * good.CountDaysBefore * Good.Percent);
            Clients[idClient].GoodsInLombard.Remove(good);          
        }

        public void AddGood(Client client, Good good)
        {
            client.GoodsInLombard.Add(good);
            Clients.Add(client);
            Summa -= good.Summa;
        }

        public void AddGood(int idClient, Good good)
        {
            Clients[idClient].GoodsInLombard.Add(good);
            Summa -= good.Summa;
        }


        public void RemoveClient(int idClient)
        {

            if (Clients[idClient].GoodsInLombard.Count != 0)
                MessageBox.Show("Ви не можете видалити цього клієнта!");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ви точно хочете видалити товар?",
                "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                    Clients.RemoveAt(idClient);
            }
        }

        public List<Good> this[Client client]
        {
            get => Clients[Clients.IndexOf(client)].GoodsInLombard;
            set => Clients[Clients.IndexOf(client)].GoodsInLombard.Union(value);

        }
        
        public int CountClients
        {
            get => Clients.Count;
        }

        public int CountGoods
        {
            get
            {
                int count = 0;
                foreach (Client client in Clients)
                {
                    foreach (Good good in client.GoodsInLombard)
                        count++;
                }
                return count;
            }
        }
    }
}
