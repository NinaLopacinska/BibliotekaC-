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
    public partial class UzytkownicyPracownik : Form
    {
        public UzytkownicyPracownik()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            //this.Load += new EventHandler(UzytkownicyPracownik_Load);
        }
        
        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close();
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
            string query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, KodPocztowy, Ulica, NrPosesji, NrLokalu  FROM uzytkownicy WHERE IdOsoby = 1";

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

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            // Pobierz dane z TextBoxów
            string login = textBoxLogin.Text;
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;

            // Utwórz zapytanie do sprawdzenia, czy użytkownik istnieje
            string query = "SELECT COUNT(*) FROM uzytkownicy WHERE Login = @Login AND Imie = @Imie AND Nazwisko = @Nazwisko";

            // Użyj connection stringa z klasy PolaczenieBazyDanych
            using (SqlConnection connection = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Dodaj parametry do zapytania
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Imie", imie);
                        command.Parameters.AddWithValue("@Nazwisko", nazwisko);

                        // Wykonaj zapytanie
                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // Użytkownik istnieje, wyświetl potwierdzenie usunięcia
                            DialogResult result = MessageBox.Show(
                                $"Czy na pewno chcesz usunąć użytkownika: {login}?",
                                "Potwierdzenie usunięcia",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );

                            if (result == DialogResult.Yes)
                            {
                                // Jeśli potwierdzono, usuń użytkownika
                                string deleteQuery = "DELETE FROM uzytkownicy WHERE Login = @Login AND Imie = @Imie AND Nazwisko = @Nazwisko";
                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@Login", login);
                                    deleteCommand.Parameters.AddWithValue("@Imie", imie);
                                    deleteCommand.Parameters.AddWithValue("@Nazwisko", nazwisko);
                                    
                                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Użytkownik został pomyślnie usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie udało się usunąć użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Użytkownik o podanych danych nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Sprawdź, czy w DataGridView jest zaznaczony jakiś wiersz
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz zaznaczony wiersz
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Sprawdź, czy kolumna "Tytul" istnieje i przypisz wartość do textBoxTytul
                if (selectedRow.Cells["Imie"] != null && selectedRow.Cells["Imie"].Value != null)
                {
                    textBoxImie.Text = selectedRow.Cells["Imie"].Value.ToString();
                }
                else
                {
                    textBoxImie.Text = string.Empty; // Wyczyść pole, jeśli brak wartości
                }
                // Sprawdź, czy kolumna "Tytul" istnieje i przypisz wartość do textBoxTytul
                if (selectedRow.Cells["Nazwisko"] != null && selectedRow.Cells["Nazwisko"].Value != null)
                {
                    textBoxNazwisko.Text = selectedRow.Cells["Nazwisko"].Value.ToString();
                }
                else
                {
                    textBoxNazwisko.Text = string.Empty; // Wyczyść pole, jeśli brak wartości
                }
                // Sprawdź, czy kolumna "Tytul" istnieje i przypisz wartość do textBoxTytul
                if (selectedRow.Cells["Login"] != null && selectedRow.Cells["Login"].Value != null)
                {
                    textBoxLogin.Text = selectedRow.Cells["Login"].Value.ToString();
                }
                else
                {
                    textBoxLogin.Text = string.Empty; // Wyczyść pole, jeśli brak wartości
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Upewnij się, że kliknięto wiersz, a nie nagłówek
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells["Imie"] != null && selectedRow.Cells["Imie"].Value != null)
                {
                    textBoxImie.Text = selectedRow.Cells["Imie"].Value.ToString();
                }
                else
                {
                    textBoxImie.Text = string.Empty; // Wyczyść pole, jeśli brak wartości
                }
                // Sprawdź, czy kolumna "Tytul" istnieje i przypisz wartość do textBoxTytul
                if (selectedRow.Cells["Nazwisko"] != null && selectedRow.Cells["Nazwisko"].Value != null)
                {
                    textBoxNazwisko.Text = selectedRow.Cells["Nazwisko"].Value.ToString();
                }
                else
                {
                    textBoxNazwisko.Text = string.Empty; // Wyczyść pole, jeśli brak wartości
                }
                // Sprawdź, czy kolumna "Tytul" istnieje i przypisz wartość do textBoxTytul
                if (selectedRow.Cells["Login"] != null && selectedRow.Cells["Login"].Value != null)
                {
                    textBoxLogin.Text = selectedRow.Cells["Login"].Value.ToString();
                }
                else
                {
                    textBoxLogin.Text = string.Empty; // Wyczyść pole, jeśli brak wartości
                }
            }
        }

        private void SearchData()
        {

            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = string.Empty;
            string searchValue = textBox1.Text;

            // Ustal zapytanie w zależności od wybranego kryterium
            switch (comboBox1.SelectedItem?.ToString())
            {
                case null:
                case "":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, KodPocztowy, Ulica, NrPosesji, NrLokalu FROM uzytkownicy";
                    break;
                case "Imie":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, KodPocztowy, Ulica, NrPosesji, NrLokalu FROM uzytkownicy WHERE Imie LIKE @searchValue";
                    break;
                case "Nazwisko":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, KodPocztowy, Ulica, NrPosesji, NrLokalu FROM uzytkownicy WHERE Nazwisko LIKE @searchValue";
                    break;
                case "Numer Telefonu":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, KodPocztowy, Ulica, NrPosesji, NrLokalu FROM uzytkownicy WHERE NumerTelefonu = @numerTelefonu";
                    break;
                case "Login":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, KodPocztowy, Ulica, NrPosesji, NrLokalu FROM uzytkownicy WHERE Login LIKE @searchValue";
                    break;
                case "Email":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, KodPocztowy, Ulica, NrPosesji, NrLokalu FROM uzytkownicy WHERE Email LIKE @searchValue";
                    break;
                case "Pesel":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, KodPocztowy, Ulica, NrPosesji, NrLokalu FROM uzytkownicy WHERE Pesel = @pesel";
                    break;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Dodaj parametry w zależności od kryterium
                        switch (comboBox1.SelectedItem?.ToString())
                        {
                            case "Imie":
                            case "Nazwisko":
                            case "Login":
                            case "Email":
                                cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
                                break;
                            case "Numer Telefonu":
                                if (int.TryParse(searchValue, out int numerTelefonu))
                                {
                                    cmd.Parameters.AddWithValue("@numerTelefonu", numerTelefonu);
                                }
                                else
                                {
                                    MessageBox.Show("Proszę wpisać poprawny numer telefonu.");
                                    return;
                                }
                                break;
                            case "Pesel":
                                if (long.TryParse(searchValue, out long pesel))
                                {
                                    cmd.Parameters.AddWithValue("@pesel", pesel);
                                }
                                else
                                {
                                    MessageBox.Show("Proszę wpisać poprawny PESEL.");
                                    return;
                                }
                                break;
                        }

                        // Wypełnij DataTable i przypisz do DataGridView
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
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

    }
}
