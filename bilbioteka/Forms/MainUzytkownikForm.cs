using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class MainUzytkownikForm : Form
    {
        private int userId;  // Id zalogowanego użytkownika
        private string userName; // Imię zalogowanego użytkownika

        public MainUzytkownikForm(int userId, string imie)
        {
            InitializeComponent();
            this.userId = userId; // Ustaw userId
            this.userName = imie; // Ustaw imię użytkownika
            label1.Text = userName; // Wyświetla imię użytkownika
            LoadData();
        }

        // Metoda pobiera dane zalogowanego użytkownika
        private void PobierzDaneUzytkownika()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie pobierające dane użytkownika na podstawie userId
                    string query = "SELECT Id, Imie FROM Uzytkownicy WHERE Id = @userId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                        userName = reader.GetString(1);
                        label1.Text = userName; // Wyświetla imię użytkownika
                    }
                    else
                    {
                        MessageBox.Show("Błąd podczas pobierania danych użytkownika.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania danych użytkownika: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM zasoby WHERE Ilosc > 0"; // Filtrujemy tylko dostępne zasoby
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["CzyWypozyczone"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania danych: " + ex.Message);
            }
        }



        private bool UserIdExists(int userId)
        {
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Uzytkownicy WHERE Id = @userId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();
                return (int)command.ExecuteScalar() > 0; // Zwróci true, jeśli użytkownik istnieje
            }
        }

        private void wypożycz_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 5)
            {
                MessageBox.Show("Możesz wypożyczyć maksymalnie 5 pozycji.");
                return;
            }

            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Sprawdzenie, czy userId istnieje
                    if (!UserIdExists(userId))
                    {
                        MessageBox.Show("Zalogowany użytkownik nie istnieje w bazie danych.");
                        return;
                    }

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int zasobId = (int)row.Cells["Id"].Value;

                        SqlCommand updateZasobyCommand = new SqlCommand(
                            "UPDATE zasoby SET Ilosc = Ilosc - 1 WHERE Id = @zasobId AND Ilosc > 0", connection);
                        updateZasobyCommand.Parameters.AddWithValue("@zasobId", zasobId);
                        int rowsAffected = updateZasobyCommand.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show($"Zasób {row.Cells["Tytul"].Value} jest niedostępny.");
                            continue;
                        }

                        DateTime dataZwrotu = DateTime.Now.AddMonths(1);

                        SqlCommand insertHistoriaCommand = new SqlCommand(
                            "INSERT INTO HistoriaWypozyczen (UzytkownikId, ZasobId, DataWypozyczenia, DataZwrotu) " +
                            "VALUES (@uzytkownikId, @zasobId, @dataWypozyczenia, @dataZwrotu)", connection);
                        insertHistoriaCommand.Parameters.AddWithValue("@uzytkownikId", userId);
                        insertHistoriaCommand.Parameters.AddWithValue("@zasobId", zasobId);
                        insertHistoriaCommand.Parameters.AddWithValue("@dataWypozyczenia", DateTime.Now);
                        insertHistoriaCommand.Parameters.AddWithValue("@dataZwrotu", dataZwrotu);

                        int historiaRowsAffected = insertHistoriaCommand.ExecuteNonQuery();
                        if (historiaRowsAffected == 0)
                        {
                            MessageBox.Show("Wystąpił błąd podczas dodawania do historii wypożyczeń.");
                        }
                    }

                    MessageBox.Show("Pomyślnie wypożyczono zaznaczone pozycje.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wypożyczania: " + ex.Message);
            }

            LoadData();
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
                    query = "SELECT * FROM zasoby WHERE Tytul LIKE @searchValue";
                    break;
                case "Autor":
                    query = "SELECT * FROM zasoby WHERE Autor LIKE @searchValue";
                    break;
                case "Rok wydania":
                    // Sprawdzenie, czy searchValue jest liczbą
                    if (!int.TryParse(searchValue, out rokWydania))
                    {
                        MessageBox.Show("Proszę wpisać poprawny rok wydania.");
                        return;
                    }
                    query = "SELECT * FROM zasoby WHERE RokWydania = @rokWydania";
                    break;
                case "Numer katalogowy":
                    query = "SELECT * FROM zasoby WHERE NumerKatalogowy LIKE @searchValue";
                    break;
                case "Typ produktu":
                    query = "SELECT * FROM zasoby WHERE Typ LIKE @searchValue";
                    break;
                case "Ocena":
                    // Sprawdzenie, czy searchValue jest liczbą
                    if (!decimal.TryParse(searchValue, out ocena))
                    {
                        MessageBox.Show("Proszę wpisać poprawną ocenę.");
                        return;
                    }
                    query = "SELECT * FROM zasoby WHERE Ocena = @ocena";
                    break;
                case "Ilość":

                    if (!int.TryParse(searchValue, out ilosc))
                    {
                        MessageBox.Show("Proszę wpisać poprawną ilość.");
                        return;
                    }
                    query = "SELECT * FROM zasoby WHERE Ilosc = @ilosc";
                    break;
                case "Kategoria":
                    query = "SELECT * FROM zasoby WHERE Kategoria LIKE @searchValue";
                    break;
                default:
                    MessageBox.Show("Proszę wybrać kryterium wyszukiwania.");
                    return;
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zostałeś pomyślnie wylogowany. Do zobaczenia!");
            this.Close();
        }
    }
}
