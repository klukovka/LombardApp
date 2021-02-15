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
    public partial class AddGood : Form
    {
        Lombard lombard = new Lombard();

        
        public AddGood()
        {
            GetLombard();
            InitializeComponent();
            foreach (Client client in lombard.Clients)
                comboBoxClient.Items.Add(client.NameClient);
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
            if (comboBoxGood.SelectedIndex == 0)
            {
                new AddApartment(comboBoxClient.SelectedIndex).Show();
                this.Hide();
            }
            if (comboBoxGood.SelectedIndex == 1)
            {
                new AddClothes(comboBoxClient.SelectedIndex).Show();
                this.Hide();
            }
            if (comboBoxGood.SelectedIndex == 2)
            {
                new AddDomesticAppl(comboBoxClient.SelectedIndex).Show();
                this.Hide();
            }
            if (comboBoxGood.SelectedIndex == 3)
            {
                new AddJewelry(comboBoxClient.SelectedIndex).Show();
                this.Hide();
            }
            if (comboBoxGood.SelectedIndex == 4)
            {
                new AddMobilePhones(comboBoxClient.SelectedIndex).Show();
                this.Hide();
            }
  
        }

      
    }
}
