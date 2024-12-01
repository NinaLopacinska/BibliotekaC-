using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class OdzyskiwanieHasloPracownik : Form
    {
        public OdzyskiwanieHasloPracownik()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);


            dataGridView1.SelectionChanged += dataGridView2_SelectionChanged;
            dataGridView1.CellClick += dataGridView2_CellClick;
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
            string query = "SELECT Imie, Nazwisko, Login, NumerTelefonu As 'Telefon', Email FROM uzytkownicy WHERE IdOsoby = 1";

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

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // Sprawdź, czy w DataGridView jest zaznaczony jakiś wiersz
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz zaznaczony wiersz
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Sprawdź, czy kolumna "Tytul" istnieje i przypisz wartość do textBoxTytul
                if (selectedRow.Cells["Login"] != null && selectedRow.Cells["Login"].Value != null)
                {
                    textBoxTytul.Text = selectedRow.Cells["Login"].Value.ToString();
                }
                else
                {
                    textBoxTytul.Text = string.Empty; // Wyczyść pole, jeśli brak wartości
                }
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Upewnij się, że kliknięto wiersz, a nie nagłówek
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells["Login"] != null && selectedRow.Cells["Login"].Value != null)
                {
                    textBoxTytul.Text = selectedRow.Cells["Login"].Value.ToString();
                }
                else
                {
                    textBoxTytul.Text = string.Empty;
                }
            }
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Funkcja generująca losowe hasło
            string GenerujHaslo()
            {
                const string litery = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string cyfry = "0123456789";
                Random random = new Random();

                // Losowanie jednej cyfry (gwarantuje, że hasło zawiera cyfrę)
                char losowaCyfra = cyfry[random.Next(cyfry.Length)];

                // Losowanie pozostałych znaków
                char[] haslo = new char[4];
                for (int i = 0; i < 4; i++)
                {
                    haslo[i] = litery[random.Next(litery.Length)];
                }

                // Łączenie cyfry z innymi znakami
                string pelneHaslo = new string(haslo) + losowaCyfra;

                // Mieszanie kolejności znaków w haśle
                return new string(pelneHaslo.OrderBy(_ => random.Next()).ToArray());
            }

            // Wygenerowanie hasła i przypisanie go do TextBoxa
            textBoxHaslo.Text = GenerujHaslo();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBoxTytul.Text.Trim();
                string haslo = textBoxHaslo.Text.Trim();

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo))
                {
                    MessageBox.Show("Login i hasło nie mogą być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Wywołanie metody aktualizującej dane
                AktualizujDaneWBazie(login, haslo);

                MessageBox.Show("Hasło zostało zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas zapisu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AktualizujDaneWBazie(string login, string haslo)
        {
            // Połączenie do bazy danych
            using (SqlConnection conn = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
            {
                // Zapytanie SQL do aktualizacji hasła
                string query = "UPDATE uzytkownicy SET Haslo = @Haslo WHERE Login = @Login";

                // Przygotowanie komendy SQL
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Dodanie parametrów do zapytania
                    cmd.Parameters.AddWithValue("@Login", login);
                    cmd.Parameters.AddWithValue("@Haslo", haslo);

                    conn.Open(); // Otwarcie połączenia
                    int rowsAffected = cmd.ExecuteNonQuery(); // Wykonanie zapytania

                    if (rowsAffected == 0)
                    {
                        // Obsługa przypadku, gdy nie znaleziono użytkownika
                        throw new Exception("Nie znaleziono użytkownika o podanym loginie.");
                    }
                }
            }
        }
    }
}
