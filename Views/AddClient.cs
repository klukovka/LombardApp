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
    public partial class AddClient : Form
    {
        Lombard lombard = new Lombard();
        public AddClient()
        {
            GetLombard();
            InitializeComponent();
            radioButtonMan.Checked = true;
            SaveLombard();
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
            new Main().Show();
            this.Hide();
        }

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            new Goods().Show();
            this.Hide();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            new Clients().Show();
            this.Hide();
        }

        private void buttonAddGood_Click(object sender, EventArgs e)
        {
            new Add().ShowDialog();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Client client = new Client()
            {
                NameClient = textBoxName.Text,
                Bday = dateTimePickerBD.Value,
                Phone = textBoxPhone.Text,
                Mail = textBoxMail.Text,
                Passport = textBoxPassport.Text
            };
            if (radioButtonMan.Checked)
                client.Sex = "Чоловік";
            else {
                client.Sex = "Жінка";
                    }

           
            SaveLombard();

            if (comboBoxGood.SelectedIndex == 0)
            {
                new AddApartment(client).Show();
                this.Hide();
            }
            if (comboBoxGood.SelectedIndex == 1)
            {
                new AddClothes(client).Show();
                this.Hide();
            }
            if (comboBoxGood.SelectedIndex == 2)
            {
                new AddDomesticAppl(client).Show();
                this.Hide();
            }
            if (comboBoxGood.SelectedIndex == 3)
            {
                new AddJewelry(client).Show();
                this.Hide();
            }
            if (comboBoxGood.SelectedIndex == 4)
            {
                new AddMobilePhones(client).Show();
                this.Hide();
            }

        }
    }
}
