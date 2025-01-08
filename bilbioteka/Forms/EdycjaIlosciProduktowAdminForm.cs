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
    public partial class EdycjaProduktowAdminForm : Form
    {
        public EdycjaProduktowAdminForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            {
                // Walidacja pól
                if (string.IsNullOrWhiteSpace(textBoxTytul.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNrKatalogowy.Text) ||
                    string.IsNullOrWhiteSpace(textBoxIlosc.Text))
                {
                    MessageBox.Show("Wszystkie pola muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textBoxIlosc.Text, out int ilosc) || ilosc <= 0)
                {
                    MessageBox.Show("Ilość musi być większa od zera!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tytul = textBoxTytul.Text;
                string nrKatalogowy = textBoxNrKatalogowy.Text;

                // Sprawdzanie czy tytuł i numer katalogowy istnieją w bazie danych
                using (SqlConnection connection = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
                {
                    connection.Open();

                    // Sprawdzanie zasobu
                    string query = "SELECT Ilosc FROM zasoby WHERE Tytul = @Tytul AND NumerKatalogowy = @NumerKatalogowy";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Tytul", tytul);
                        command.Parameters.AddWithValue("@NumerKatalogowy", nrKatalogowy);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // Jeśli zasób istnieje, zwiększamy ilość
                            int aktualnaIlosc = Convert.ToInt32(result);
                            int nowaIlosc = aktualnaIlosc + ilosc;

                            string updateQuery = "UPDATE zasoby SET Ilosc = @NowaIlosc WHERE Tytul = @Tytul AND NumerKatalogowy = @NumerKatalogowy";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@NowaIlosc", nowaIlosc);
                                updateCommand.Parameters.AddWithValue("@Tytul", tytul);
                                updateCommand.Parameters.AddWithValue("@NumerKatalogowy", nrKatalogowy);
                                updateCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Ilość zasobu została zaktualizowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tytuł lub numer katalogowy nie znajduje się w bazie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sprawdzanie, czy kliknięto prawidłowy wiersz (pomijając nagłówki)
            if (e.RowIndex >= 0)
            {
                // Pobierz aktualny wiersz
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Przenieś dane do odpowiednich TextBoxów
                textBoxTytul.Text = selectedRow.Cells["Tytul"].Value?.ToString() ?? string.Empty;
                textBoxNrKatalogowy.Text = selectedRow.Cells["NumerKatalogowy"].Value?.ToString() ?? string.Empty;
                textBoxIlosc.Text = selectedRow.Cells["Ilosc"].Value?.ToString() ?? string.Empty;
            }
        }
        private void buttonUsun_Click(object sender, EventArgs e)
        {
            // Walidacja pól
            if (string.IsNullOrWhiteSpace(textBoxTytul.Text) ||
                string.IsNullOrWhiteSpace(textBoxNrKatalogowy.Text) ||
                string.IsNullOrWhiteSpace(textBoxIlosc.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxIlosc.Text, out int ilosc) || ilosc <= 0)
            {
                MessageBox.Show("Ilość musi być większa od zera!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tytul = textBoxTytul.Text;
            string nrKatalogowy = textBoxNrKatalogowy.Text;

            // Sprawdzanie czy tytuł i numer katalogowy istnieją w bazie danych
            using (SqlConnection connection = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
            {
                connection.Open();

                // Sprawdzanie zasobu
                string query = "SELECT Ilosc FROM zasoby WHERE Tytul = @Tytul AND NumerKatalogowy = @NumerKatalogowy";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tytul", tytul);
                    command.Parameters.AddWithValue("@NumerKatalogowy", nrKatalogowy);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Jeśli zasób istnieje, sprawdzamy ilość
                        int aktualnaIlosc = Convert.ToInt32(result);

                        if (ilosc > aktualnaIlosc)
                        {
                            MessageBox.Show("Ilość do usunięcia nie może być większa niż dostępna ilość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int nowaIlosc = aktualnaIlosc - ilosc;

                        if (nowaIlosc == 0)
                        {
                            // Zapytanie o usunięcie produktu
                            var wynik = MessageBox.Show("Produkt osiągnął ilość 0. Czy chcesz go usunąć z bazy danych?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (wynik == DialogResult.Yes)
                            {
                                // Usuwanie produktu
                                string deleteQuery = "UPDATE zasoby SET StanZasobu = 'Nieaktywny' WHERE Tytul = @Tytul AND NumerKatalogowy = @NumerKatalogowy";
                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@Tytul", tytul);
                                    deleteCommand.Parameters.AddWithValue("@NumerKatalogowy", nrKatalogowy);
                                    deleteCommand.ExecuteNonQuery();
                                }

                                MessageBox.Show("Produkt został usunięty z bazy.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Aktualizacja ilości na 0
                                string updateQuery = "UPDATE zasoby SET Ilosc = 0 WHERE Tytul = @Tytul AND NumerKatalogowy = @NumerKatalogowy";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@Tytul", tytul);
                                    updateCommand.Parameters.AddWithValue("@NumerKatalogowy", nrKatalogowy);
                                    updateCommand.ExecuteNonQuery();
                                }

                                MessageBox.Show("Ilość produktu została ustawiona na 0, ale produkt pozostał w bazie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            // Aktualizacja ilości
                            string updateQuery = "UPDATE zasoby SET Ilosc = @NowaIlosc WHERE Tytul = @Tytul AND NumerKatalogowy = @NumerKatalogowy";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@NowaIlosc", nowaIlosc);
                                updateCommand.Parameters.AddWithValue("@Tytul", tytul);
                                updateCommand.Parameters.AddWithValue("@NumerKatalogowy", nrKatalogowy);
                                updateCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Ilość zasobu została zaktualizowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tytuł lub numer katalogowy nie znajduje się w bazie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
            string query = "SELECT Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE StanZasobu = 'Aktywny'";

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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchData()
        {
            if (comboBox2.SelectedItem == null)
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
            switch (comboBox2.SelectedItem.ToString())
            {
                case "   ":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE StanZasobu = 'Aktywny' ";
                    break;
                case "Tytuł":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Tytul LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Autor":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Autor LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Rok wydania":
                    query = "SELECT Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE RokWydania LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Numer katalogowy":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE NumerKatalogowy LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Typ produktu":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Typ LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Ocena":
                    // Sprawdzenie, czy searchValue jest liczbą
                    if (!decimal.TryParse(searchValue, out ocena))
                    {
                        MessageBox.Show("Proszę wpisać poprawną ocenę.");
                        return;
                    }
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Ocena = @ocena AND StanZasobu = 'Aktywny'";
                    break;
                case "Ilość":

                    if (!int.TryParse(searchValue, out ilosc))
                    {
                        MessageBox.Show("Proszę wpisać poprawną ilość.");
                        return;
                    }
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Ilosc = @ilosc AND StanZasobu = 'Aktywny'";
                    break;
                case "Kategoria":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Kategoria LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                default:
                    MessageBox.Show("Proszę wybrać kryterium wyszukiwania.");
                    return;

                case "Wydawnictwo":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Wydawnictwo LIKE @searchValue AND StanZasobu = 'Aktywny'";
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
                    switch (comboBox2.SelectedItem.ToString())
                    {
                        case "Tytuł":
                        case "Autor":
                        case "Numer katalogowy":
                        case "Typ produktu":
                        case "Wydawnictwo":
                        case "Kategoria":
                            cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
                            break;
                        case "Ocena":
                            cmd.Parameters.AddWithValue("@ocena", ocena);
                            break;
                        case "Rok wydania":
                            cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
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
    }
}
