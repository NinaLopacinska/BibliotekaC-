using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class MainAdminstratorForm : Form
    {
        private Raport raport;

        public MainAdminstratorForm(string imie)
        {
            InitializeComponent();
            label1.Text = imie;
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            raport = new Raport("", "", connectionString);
        }

        private void buttonGenerujRaport_Click(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm();
            dateForm.Show();
        }

        private void buttonUsunPracownika_Click(object sender, EventArgs e)
        {
            PracownicyAdministrator usunPracownikaAdministrator = new PracownicyAdministrator();
            usunPracownikaAdministrator.Show();
        }

        private void buttonEdycjaZbioru_Click(object sender, EventArgs e)
        {
            EdycjaProduktowAdminForm edycjaIlosciProduktowAdminForm = new EdycjaProduktowAdminForm();
            edycjaIlosciProduktowAdminForm.Show();
        }

        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            DodajPracownikaForm dodajPracownika = new DodajPracownikaForm();
            dodajPracownika.Show();
        }

        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {
            DodajNwoyProduktAdminForm dodajNwoyProduktAdmin = new DodajNwoyProduktAdminForm();
            dodajNwoyProduktAdmin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EdytujCennikAdmin edytujCennikAdmin = new EdytujCennikAdmin();
            edytujCennikAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zostałeś pomyślnie wylogowany. Do zobaczenia!");
            this.Close();
        }
    }
}
