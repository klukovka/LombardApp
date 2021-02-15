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
    public partial class Goods : Form
    {
        Lombard lombard = new Lombard();

        public Goods()
        {
            GetLombard();
            lombard.Profit();
            InitializeComponent();
            Point point = new Point(10, 10);

            foreach(Client client in lombard.Clients)
            {
                foreach (var good in client.GoodsInLombard)
                {
                    if (good is Apartment)
                        PrintApartment(ref point, client, (Apartment)good);
                    if (good is Clothes)
                        PrintClothes(ref point, client, (Clothes)good);
                    if (good is DomesticAppl)
                        PrintDomesticAppl(ref point, client, (DomesticAppl)good);
                    if (good is Jewelry)
                        PrintJewelry(ref point, client, (Jewelry)good);
                    if (good is MobilePhones)
                        PrintMobilePhones(ref point, client, (MobilePhones)good);

                }
            }
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


        private Panel GetPanel(ref Point point)
        {
            Panel innerPanel = new Panel();
            innerPanel.Size = new Size(765, 295);
            innerPanel.Location = point;
            point.Y += 315;
            innerPanel.BackColor = Color.Azure;
            innerPanel.BorderStyle = BorderStyle.Fixed3D;

            return innerPanel;
        }

        private TextBox GetTextBox(Point point, string text, string item)
        {
            TextBox box = new TextBox();
            box.Size = new Size(360, 35);
            box.Multiline = true;
            box.Location = point;
            box.ReadOnly = true;
            box.BackColor = Color.AliceBlue;
            box.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            box.ForeColor = Color.FromArgb(36, 0, 18);
            box.Text = text + item;

            return box;
        }

        private void PrintGoods(Client client, Good good, ref Panel innerPanel)
        {

            TextBox clientName = GetTextBox(new Point(15, 50), "ПІБ клієнта: ", client.NameClient);
            TextBox goodName = GetTextBox(new Point(15, 90), "Назва товару: ", good.NameGood);
            TextBox goodCost = GetTextBox(new Point(15, 130), "Оціночна вартість: ", good.Cost.ToString());
            TextBox goodDateGet = GetTextBox(new Point(15, 170), "Дата здачі: ", good.DateGet.ToString("yyyy-MM-dd"));
            TextBox goodTerm = GetTextBox(new Point(15, 210), "Залишилось днів: ", good.CountDaysAfter.ToString());     
            
            Button sell = new Button();
            sell.Name = lombard.Clients.IndexOf(client) + "and" + client.GoodsInLombard.IndexOf(good);
            sell.Size = new Size(735, 35);
            sell.Location = new Point(15, 250);
            sell.BackColor = Color.AliceBlue;
            sell.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            sell.ForeColor = Color.FromArgb(36, 0, 18);
            sell.Text = "Продати назад власнику";

            MainPanel.Controls.Add(innerPanel);
            innerPanel.Controls.Add(clientName);
            innerPanel.Controls.Add(goodName);
            innerPanel.Controls.Add(goodCost);
            innerPanel.Controls.Add(goodTerm);
            innerPanel.Controls.Add(goodDateGet);
            innerPanel.Controls.Add(sell);

            sell.Click += Sell_CLick;
                       
        }

        private void Sell_CLick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ви точно хочете видалити товар?",
                "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string name = ((Button)sender).Name;
                int idClient = Convert.ToInt32(name.Substring(0, name.IndexOf('a')));
                int idGood = Convert.ToInt32(name.Substring(name.IndexOf('d') + 1));
                lombard.Profit(idClient, idGood);
                SaveLombard();
                new Goods().Show();
                this.Hide();
            }
        }

        private Label GetLabel(string item)
        {
            Label type = new Label();
            type.Size = new Size(735, 35);
            type.Location = new Point(15, 10);
            type.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            type.ForeColor = Color.FromArgb(36, 0, 18);
            type.Text = "Тип товару: "+item;

            return type;
        }

        private void PrintApartment(ref Point point, Client client, Apartment app)
        {
            Panel innerPanel = GetPanel(ref point);
            PrintGoods(client, app, ref innerPanel);

            Label type = GetLabel("приміщення");
            TextBox Adress = GetTextBox(new Point(390, 50), "Адреса: ", app.Adress);          
            TextBox TechnicalPass = GetTextBox(new Point(390, 90), "Техпаспорт: ", app.TechnicalPass);
            TextBox Owner = GetTextBox(new Point(390, 130), "Власник: ", app.Owner);
            TextBox Square = GetTextBox(new Point(390, 170), "Площа: ", app.Square.ToString());
            TextBox Rooms = GetTextBox(new Point(390, 210), "Кімнати: ", app.Rooms.ToString());
            TextBox Floor = GetTextBox(new Point(390, 250), "Поверх: ", app.Floor.ToString());    
            
            innerPanel.Controls.Add(type);
            innerPanel.Controls.Add(Adress);
            innerPanel.Controls.Add(TechnicalPass);
            innerPanel.Controls.Add(Owner);
            innerPanel.Controls.Add(Square);
            innerPanel.Controls.Add(Rooms);
            innerPanel.Controls.Add(Floor);

        }

        private void PrintClothes(ref Point point, Client client, Clothes clothes)
        {
            Panel innerPanel = GetPanel(ref point);


            PrintGoods(client, clothes, ref innerPanel);

            Label type = GetLabel("речі");
            TextBox Size = GetTextBox(new Point(390, 50), "Розмір: ", clothes.Size.ToString());
            TextBox Height = GetTextBox(new Point(390, 90), "Зріст: ", clothes.Height.ToString());
            TextBox Fabric = GetTextBox(new Point(390, 130), "Марка: ", clothes.Fabric);
          
            innerPanel.Controls.Add(type);
            innerPanel.Controls.Add(Size);
            innerPanel.Controls.Add(Height);
            innerPanel.Controls.Add(Fabric);          

        }


        private void PrintDomesticAppl(ref Point point, Client client, DomesticAppl appl)
        {
            Panel innerPanel = GetPanel(ref point);


            PrintGoods(client, appl, ref innerPanel);

            Label type = GetLabel("побутова техніка");
            TextBox Producer = GetTextBox(new Point(390, 50), "Виробник: ", appl.Producer);
            TextBox Model = GetTextBox(new Point(390, 90), "Модель: ", appl.Model);
            TextBox Power = GetTextBox(new Point(390, 130), "Потужність: ", appl.Power.ToString());        

            innerPanel.Controls.Add(type);
            innerPanel.Controls.Add(Producer);
            innerPanel.Controls.Add(Model);
            innerPanel.Controls.Add(Power);


        }

        private void PrintJewelry(ref Point point, Client client, Jewelry jewelry)
        {
            Panel innerPanel = GetPanel(ref point);


            PrintGoods(client, jewelry, ref innerPanel);

            Label type = GetLabel("ювелірні вироби");

            TextBox Weight = GetTextBox(new Point(390, 50), "Вага: ", jewelry.Weight.ToString());
            TextBox Purity = GetTextBox(new Point(390, 90), "Проба: ", jewelry.Purity.ToString());    

            innerPanel.Controls.Add(type);
            innerPanel.Controls.Add(Weight);
            innerPanel.Controls.Add(Purity);


        }

        private void PrintMobilePhones(ref Point point, Client client, MobilePhones mobile)
        {
            Panel innerPanel = GetPanel(ref point);


            PrintGoods(client, mobile, ref innerPanel);

            Label type = GetLabel("мобільні пристрої");

            TextBox Producer = GetTextBox(new Point(390, 50), "Виробник: ", mobile.Producer);
            TextBox Model = GetTextBox(new Point(390, 90), "Модель: ", mobile.Model);
            TextBox SerialNumber = GetTextBox(new Point(390, 130), "Серійний номер: ", mobile.SerialNumber);
            TextBox Imei = GetTextBox(new Point(390, 170), "Imei: ", mobile.Imei.ToString());
        

            innerPanel.Controls.Add(type);
            innerPanel.Controls.Add(Producer);
            innerPanel.Controls.Add(Model);
            innerPanel.Controls.Add(SerialNumber);
            innerPanel.Controls.Add(Imei);


        }

    }
}
