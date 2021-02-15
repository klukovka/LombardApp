using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LombardApp.Views
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            AddClient client = new AddClient();
            client.Show();
            foreach (Form form in Application.OpenForms)
            {
                if (!(form is AddClient))
                    form.Hide();
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            AddGood addGood = new AddGood();
            addGood.Show();
            foreach (Form form in Application.OpenForms)
            {
                if (!(form is AddGood))
                    form.Hide();
            }
        }
    }
}
