using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class DodajPracownikaForm : Form
    {
        private string imie;
        public DodajPracownikaForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            textBoxHaslo.PasswordChar = '*';
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            // Pobierz dane z pól tekstowych
            string imie = textBoxImie.Text.Trim();
            string nazwisko = textBoxNazwisko.Text.Trim();
            string login = textBoxLogin.Text.Trim();
            string haslo = textBoxHaslo.Text.Trim();
            string kodPocztowy = textBoxKodPocztowy.Text.Trim();
            string ulica = textBoxUlica.Text.Trim();
            string nrPosesji = textBoxNrPosesji.Text.Trim();
            string nrLokalu = textBoxNrLokalu.Text.Trim();
            string pesel = textBoxPesel.Text.Trim();
            DateTime dataUrodzenia = dateTimePicker1.Value;
            string email = textBoxEmail.Text.Trim();
            string numerTelefonu = textBoxNrTelefonu.Text.Trim();

            // Walidacja danych
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(haslo) ||
                string.IsNullOrWhiteSpace(kodPocztowy) || string.IsNullOrWhiteSpace(ulica) ||
                string.IsNullOrWhiteSpace(nrPosesji) || string.IsNullOrWhiteSpace(pesel) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(numerTelefonu))
            {
                MessageBox.Show("Wszystkie pola są wymagane!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (login.Length < 5 || login.Length > 30)
            {
                MessageBox.Show("Login pracownika musi mieć od 5 do 30 znaków!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (haslo.Length < 5 || !Regex.IsMatch(haslo, @"\d"))
            {
                MessageBox.Show("Hasło pracownika musi mieć minimum 5 znaków i przynajmniej jedną cyfrę!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(kodPocztowy, @"^\d{2}-\d{3}$") || kodPocztowy.CompareTo("90-001") < 0 || kodPocztowy.CompareTo("94-413") > 0)
            {
                MessageBox.Show("Kod pocztowy pracownika musi być z terenu Łodzi czyli od 90-001 do 94-413!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kodPocztowy.Length < 1 || !Regex.IsMatch(nrLokalu, @"\d"))
            {
                MessageBox.Show("Numer lokalu musi zawierać cyfry!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pesel.Length != 11 || !long.TryParse(pesel, out _))
            {
                MessageBox.Show("Pesel pracownika musi mieć 11 cyfr!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email pracownika musi zawierać znak '@' oraz '.'!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numerTelefonu.Length != 9 || !long.TryParse(numerTelefonu, out _))
            {
                MessageBox.Show("Numer telefonu pracownika musi mieć 9 cyfr!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DateTime.Now.Year - dataUrodzenia.Year < 16)
            {
                MessageBox.Show("Pracownik musi mieć cob najmniej 16 lat!", "Bład rejstracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Sprawdzenie unikalności loginu
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkLoginQuery = "SELECT COUNT(1) FROM uzytkownicy WHERE Login = @Login";
                using (SqlCommand command = new SqlCommand(checkLoginQuery, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    int exists = (int)command.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Login już istnieje!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                int newId = 1;
                string getMaxIdQuery = "SELECT ISNULL(MAX(Id), 0) + 1 FROM uzytkownicy";
                using (SqlCommand command = new SqlCommand(getMaxIdQuery, connection))
                {
                    newId = (int)command.ExecuteScalar();
                }

                // Dodanie nowego użytkownika
                string insertQuery = @"
                SET IDENTITY_INSERT uzytkownicy ON;
                INSERT INTO uzytkownicy 
                (Id, Imie, Nazwisko, NumerTelefonu, Login, Haslo, KodPocztowy, Ulica, NrPosesji, NrLokalu, Pesel, DataUrodzenia, Email, IdOsoby) 
                VALUES 
                (@Id, @Imie, @Nazwisko, @NumerTelefonu, @Login, @Haslo, @KodPocztowy, @Ulica, @NrPosesji, @NrLokalu, @Pesel, @DataUrodzenia, 
                @Email, 2);
                SET IDENTITY_INSERT uzytkownicy OFF;";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", newId);
                    command.Parameters.AddWithValue("@Imie", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@NumerTelefonu", numerTelefonu);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Haslo", haslo);
                    command.Parameters.AddWithValue("@KodPocztowy", kodPocztowy);
                    command.Parameters.AddWithValue("@Ulica", ulica);
                    command.Parameters.AddWithValue("@NrPosesji", nrPosesji);
                    command.Parameters.AddWithValue("@NrLokalu", string.IsNullOrEmpty(nrLokalu) ? (object)DBNull.Value : nrLokalu);
                    command.Parameters.AddWithValue("@Pesel", pesel);
                    command.Parameters.AddWithValue("@DataUrodzenia", dataUrodzenia);
                    command.Parameters.AddWithValue("@Email", email);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show(" Pracownik został dodany!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Pobieranie connection string z klasy PolaczenieBazyDanych
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

            // Zapytanie SQL, które wybiera dane z tabeli 'zasoby'
            string query = "SELECT * FROM uzytkownicy WHERE IdOsoby = 2";

            // Tworzenie obiektu SqlConnection z connection string
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Otwórz połączenie
                    conn.Open();

                    // Utwórz obiekt SqlDataAdapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    // Utwórz DataTable, do której załadujemy dane
                    DataTable dataTable = new DataTable();

                    // Załaduj dane z SQL do DataTable
                    dataAdapter.Fill(dataTable);

                    // Ustaw DataGridView1 jako źródło danych dla DataTable
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Obsługa błędów
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }

        private void ButtonOdswiez_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

        
    

