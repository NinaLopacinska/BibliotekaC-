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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zostałeś pomyślnie wylogowany. Do zobaczenia!");
            this.Close();
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
    }
}
