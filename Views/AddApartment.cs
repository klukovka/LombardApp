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
using LombardApp.Models;

namespace LombardApp.Views
{
    partial class AddApartment : Form
    {

        Lombard lombard = new Lombard();
        Client client;
        Apartment app = new Apartment();
        int idClient;
        public AddApartment()
        {
            InitializeComponent();
        }
        public AddApartment(Client client1)
        {
            GetLombard();
            client = client1;            
            InitializeComponent();
        }
        public AddApartment(int id)
        {
            GetLombard();
            idClient = id;
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
            app.NameGood = textBoxNameGood.Text;
            app.Cost = Convert.ToDouble(numericUpDownCost.Value);
            app.DateGet = Convert.ToDateTime(dateTimePickerDateGet.Value);
            app.Term = Convert.ToInt32(numericUpDownTerm.Value);

            app.Adress = textBoxAdress.Text;
            app.TechnicalPass = textBoxTechnicalPass.Text;
            app.Owner = textBoxOwner.Text;
            app.Square = (int)numericUpDownSquare.Value;
            app.Rooms = (int)numericUpDownRooms.Value;
            app.Floor = (int)numericUpDownFloor.Value;

            if (client != null)
                lombard.AddGood(client, app);
            else
                lombard.AddGood(idClient, app);

            SaveLombard();
            buttonGoods_Click(sender, e);

        }
    }
}
