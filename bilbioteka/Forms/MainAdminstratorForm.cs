using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class MainAdminstratorForm : Form
    {
        public MainAdminstratorForm(string imie)
        {
            InitializeComponent();
            label1.Text = imie;
        }




        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            DodajPracownikaForm dodajPracownikaForm = new DodajPracownikaForm();
            dodajPracownikaForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zostałeś pomyślnie wylogowany. Do zobaczenia!");
            this.Close();
        }

        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {
            DodajNwoyProduktAdminForm dodajNwoyProduktAdminForm = new DodajNwoyProduktAdminForm();
            dodajNwoyProduktAdminForm.Show();
            
        }

        private void buttonEdycjaZbioru_Click(object sender, EventArgs e)
        {
            EdycjaProduktowAdminForm edycjaProduktowAdminForm = new EdycjaProduktowAdminForm();
            edycjaProduktowAdminForm.Show();
            
        }
    }
}
