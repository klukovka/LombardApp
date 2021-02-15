using LombardApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LombardApp.Views
{
    partial class AddClothes : Form
    {
        Lombard lombard = new Lombard();
        Client client;
        Clothes clothes = new Clothes();
        int id;
        public AddClothes()
        {
            InitializeComponent();
        }

        public AddClothes(Client client1)
        {
            GetLombard();
            client = client1;
            InitializeComponent();
        }
        public AddClothes(int id)
        {
            GetLombard();
            this.id = id;
            InitializeComponent();
        }
        private void GetLombard()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("lombard.dat", FileMode.OpenOrCreate))
            {
                lombard = (Lombard)formatter.Deserialize(fs);
            }
        }

        private void SaveLombard()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("lombard.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, lombard);
            }
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            goods.Show();
            this.Hide();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            this.Hide();
        }

        private void buttonAddGood_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            clothes.NameGood = textBoxNameGood.Text;
            clothes.Cost = Convert.ToDouble(numericUpDownCost.Value);
            clothes.DateGet = Convert.ToDateTime(dateTimePickerDateGet.Value);
            clothes.Term = Convert.ToInt32(numericUpDownTerm.Value);


            clothes.Height = Convert.ToDouble(numericUpDownHeight.Value);
            clothes.Size = Convert.ToInt32(numericUpDownSize.Value);
            clothes.Fabric = textBoxFabric.Text;

            if(client!=null)
                lombard.AddGood(client, clothes);
            else
                lombard.AddGood(id, clothes);

            MessageBox.Show(clothes.Summa.ToString());

            SaveLombard();
            buttonGoods_Click(sender, e);
        }
    }
}
