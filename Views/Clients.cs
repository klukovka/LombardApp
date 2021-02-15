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
    public partial class Clients : Form
    {
        Lombard lombard = new Lombard();

        public Clients()
        {
            GetLombard();
            lombard.Profit();
            InitializeComponent();
            Point point = new Point(10, 10);
            foreach (Client client in lombard.Clients)
                PrintClients(ref point, client);

            SaveLombard();
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


        private void PrintClients(ref Point point, Client client)
        {
            Panel innerPanel = new Panel();
            innerPanel.Size = new Size(765, 215);
            innerPanel.Location = point;
            point.Y += 225;
            innerPanel.BackColor = Color.Azure;
            innerPanel.BorderStyle = BorderStyle.Fixed3D;

            TextBox NameClient = new TextBox();
            NameClient.Size = new Size(360, 35);
            NameClient.Multiline = true;
            NameClient.Location = new Point(15, 10);
            NameClient.ReadOnly = true;
            NameClient.BackColor = Color.AliceBlue;
            NameClient.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            NameClient.ForeColor = Color.FromArgb(36, 0, 18);
            NameClient.Text = "ПІБ клієнта: " + client.NameClient;

            TextBox Bday = new TextBox();
            Bday.Size = new Size(360, 35);
            Bday.Multiline = true;
            Bday.Location = new Point(15, 50);
            Bday.ReadOnly = true;
            Bday.BackColor = Color.AliceBlue;
            Bday.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            Bday.ForeColor = Color.FromArgb(36, 0, 18);
            Bday.Text = "Дата народження: " + client.Bday.ToString("yyyy-MM-dd");


            TextBox Sex = new TextBox();
            Sex.Size = new Size(360, 35);
            Sex.Multiline = true;
            Sex.Location = new Point(15, 90);
            Sex.ReadOnly = true;
            Sex.BackColor = Color.AliceBlue;
            Sex.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            Sex.ForeColor = Color.FromArgb(36, 0, 18);
            Sex.Text = "Стать: " + client.Sex;

            TextBox goods = new TextBox();
            goods.Size = new Size(735, 35);
            goods.Multiline = true;
            goods.Location = new Point(15, 130);
            goods.ReadOnly = true;
            goods.BackColor = Color.AliceBlue;
            goods.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            goods.ForeColor = Color.FromArgb(36, 0, 18);
            goods.Text = "Кількість товарів у ломбарді: " + client.GoodsInLombard.Count.ToString();


            Button remove = new Button();
            remove.Name = lombard.Clients.IndexOf(client).ToString();
            remove.Size = new Size(735, 35);
            remove.Location = new Point(15, 170);
            remove.BackColor = Color.AliceBlue;
            remove.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            remove.ForeColor = Color.FromArgb(36, 0, 18);
            remove.Text = "Видалити клієнта";


            TextBox Phone = new TextBox();
            Phone.Size = new Size(360, 35);
            Phone.Multiline = true;
            Phone.Location = new Point(390, 10);
            Phone.ReadOnly = true;
            Phone.BackColor = Color.AliceBlue;
            Phone.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            Phone.ForeColor = Color.FromArgb(36, 0, 18);
            Phone.Text = "Телефон: " + client.Phone;

            TextBox Mail = new TextBox();
            Mail.Size = new Size(360, 35);
            Mail.Multiline = true;
            Mail.Location = new Point(390, 50);
            Mail.ReadOnly = true;
            Mail.BackColor = Color.AliceBlue;
            Mail.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            Mail.ForeColor = Color.FromArgb(36, 0, 18);
            Mail.Text = "Пошта: " + client.Mail;

            TextBox Passport = new TextBox();
            Passport.Size = new Size(360, 35);
            Passport.Multiline = true;
            Passport.Location = new Point(390, 90);
            Passport.ReadOnly = true;
            Passport.BackColor = Color.AliceBlue;
            Passport.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            Passport.ForeColor = Color.FromArgb(36, 0, 18);
            Passport.Text = "Паспорт: " + client.Passport;

            MainPanel.Controls.Add(innerPanel);
            innerPanel.Controls.Add(NameClient);
            innerPanel.Controls.Add(Bday);
            innerPanel.Controls.Add(Sex);
            innerPanel.Controls.Add(goods);
            innerPanel.Controls.Add(remove);
            innerPanel.Controls.Add(Phone);
            innerPanel.Controls.Add(Mail);
            innerPanel.Controls.Add(Passport);

            remove.Click += Remove_CLick;

        }

        private void Remove_CLick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button)sender).Name);

            lombard.RemoveClient(id);

            SaveLombard();

            new Clients().Show();
            this.Hide();

        }
    }
}
