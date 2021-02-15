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
   partial class AddMobilePhones : Form
    {
        Lombard lombard = new Lombard();
        Client client;
        MobilePhones mobile = new MobilePhones();
        int id;
        public AddMobilePhones()
        {
            InitializeComponent();
        }

        public AddMobilePhones(Client client1)
        {
            GetLombard();
            client = client1;
            InitializeComponent();
        }

        public AddMobilePhones(int client1)
        {
            GetLombard();
            id = client1;
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
            mobile.NameGood = textBoxNameGood.Text;
            mobile.Cost = Convert.ToDouble(numericUpDownCost.Value);
            mobile.DateGet = Convert.ToDateTime(dateTimePickerDateGet.Value);
            mobile.Term = Convert.ToInt32(numericUpDownTerm.Value);

            mobile.Producer = textBoxProducer.Text;
            mobile.Model = textBoxModel.Text;
            mobile.SerialNumber = textBoxSerialNumber.Text;
            mobile.Imei = Convert.ToInt32(numericUpDownImei.Value);

            if (client!=null)
                lombard.AddGood(client, mobile);
            else
                lombard.AddGood(id, mobile);

            MessageBox.Show(mobile.Summa.ToString());

            SaveLombard();
            buttonGoods_Click(sender, e);
        }
    }
}
