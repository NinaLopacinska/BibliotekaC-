using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class MainPracownikForm : Form
    {
        private string login;
        public MainPracownikForm(string imie, string login)
        {
            InitializeComponent();
            this.login = login;
            label1.Text = imie;
            this.Load += new EventHandler(Form1_Load);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zostałeś pomyślnie wylogowany. Do zobaczenia!");

            this.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Tytul, Autor, RokWydania as Rok, NumerKatalogowy as 'Nr. kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Ilosc > 0 AND StanZasobu = 'Aktywny'"; // Filtrujemy tylko dostępne zasoby
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    //dataGridView1.Columns["Id"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania danych: " + ex.Message);
            }
        }

        private void SearchData()
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać kryterium wyszukiwania.");
                return;
            }

            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = string.Empty;
            string searchValue = textBox1.Text;
            int rokWydania = 0;
            decimal ocena = 0;
            int ilosc = 0;
            // Ustal zapytanie w zależności od wybranego kryterium
            switch (comboBox1.SelectedItem.ToString())
            {
                case "   ":
                    query = "SELECT * FROM zasoby ";
                    break;
                case "Tytuł":
                    query = "SELECT * FROM zasoby WHERE Tytul LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Autor":
                    query = "SELECT * FROM zasoby WHERE Autor LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Rok wydania":
                    // Sprawdzenie, czy searchValue jest liczbą
                    if (!int.TryParse(searchValue, out rokWydania))
                    {
                        MessageBox.Show("Proszę wpisać poprawny rok wydania.");
                        return;
                    }
                    query = "SELECT * FROM zasoby WHERE RokWydania = @rokWydania AND StanZasobu = 'Aktywny'";
                    break;
                case "Numer katalogowy":
                    query = "SELECT * FROM zasoby WHERE NumerKatalogowy LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Typ produktu":
                    query = "SELECT * FROM zasoby WHERE Typ LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Ocena":
                    // Sprawdzenie, czy searchValue jest liczbą
                    if (!decimal.TryParse(searchValue, out ocena))
                    {
                        MessageBox.Show("Proszę wpisać poprawną ocenę.");
                        return;
                    }
                    query = "SELECT * FROM zasoby WHERE Ocena = @ocena AND StanZasobu = 'Aktywny'";
                    break;
                case "Ilość":

                    if (!int.TryParse(searchValue, out ilosc))
                    {
                        MessageBox.Show("Proszę wpisać poprawną ilość.");
                        return;
                    }
                    query = "SELECT * FROM zasoby WHERE Ilosc = @ilosc AND StanZasobu = 'Aktywny'";
                    break;
                case "Kategoria":
                    query = "SELECT * FROM zasoby WHERE Kategoria LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                default:
                    MessageBox.Show("Proszę wybrać kryterium wyszukiwania.");
                    return;

                case "Wydawnictwo":
                    query = "SELECT * FROM zasoby WHERE Wydawnictwo LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;

            }

            // Tworzenie połączenia z bazą
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Dodaj parametr w zależności od wybranego kryterium
                    switch (comboBox1.SelectedItem.ToString())
                    {
                        case "Tytuł":
                        case "Autor":
                        case "Numer katalogowy":
                        case "Typ produktu":
                        case "Wydawnictwo":
                        case "Kategoria":
                            cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
                            break;
                        case "Rok wydania":
                            cmd.Parameters.AddWithValue("@rokWydania", rokWydania);
                            break;
                        case "Ocena":
                            cmd.Parameters.AddWithValue("@ocena", ocena);
                            break;
                        case "Ilość":
                            cmd.Parameters.AddWithValue("@ilosc", ilosc);
                            break;
                    }

                    // Wypełnij DataTable i przypisz do DataGridView
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void buttonWypozycz_Click(object sender, EventArgs e)
        {
            WypozyczeniePracownikForm wypozyczeniePracownik = new WypozyczeniePracownikForm();
            wypozyczeniePracownik.ShowDialog();
        }

        private void buttonEdytujKontoUzytkownika_Click(object sender, EventArgs e)
        {
            UzytkownicyPracownik usunUzytkownikaPracownik = new UzytkownicyPracownik();
            usunUzytkownikaPracownik.ShowDialog();
        }

        private void buttonEdytujSwojeKonto_Click(object sender, EventArgs e)
        {
            EdycjaUzytkownikaPracownik edycjaUzytkownikaPracownik = new EdycjaUzytkownikaPracownik(login);
            edycjaUzytkownikaPracownik.Show();
        }

        private void btnStatystyki_Click(object sender, EventArgs e)
        {
            StatystykiPracownik statystykiPracownik = new StatystykiPracownik();
            statystykiPracownik.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdzyskiwanieHasloPracownik odzyskiwanieHasloPracownik = new OdzyskiwanieHasloPracownik();
            odzyskiwanieHasloPracownik.ShowDialog(this);
        }

        private void buttonPrzyjmijOplate_Click(object sender, EventArgs e)
        {
            KaraPracownik2 karaPracownik2 = new KaraPracownik2();
            karaPracownik2.Show();
        }
    }
}
