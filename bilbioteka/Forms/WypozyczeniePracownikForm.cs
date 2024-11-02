using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class WypozyczeniePracownikForm : Form
    {
        public WypozyczeniePracownikForm()
        {
            InitializeComponent();
        }

        private void buttonWypozycz_Click_1(object sender, EventArgs e)
        {
            int userId;
            string tytul = textBox2.Text;
            string loginUzytkownika = string.Empty;

            // Sprawdź, czy ID użytkownika jest liczbą
            if (!int.TryParse(textBoxLogin.Text, out userId))
            {
                MessageBox.Show("Proszę wpisać poprawne ID użytkownika.");
                return;
            }

            // Sprawdź, czy tytuł nie jest pusty
            if (string.IsNullOrWhiteSpace(tytul))
            {
                MessageBox.Show("Proszę wpisać tytuł zasobu.");
                return;
            }

            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pobierz login użytkownika o podanym ID
                    string loginQuery = "SELECT Login FROM uzytkownicy WHERE Id = @userId";
                    SqlCommand loginCommand = new SqlCommand(loginQuery, connection);
                    loginCommand.Parameters.AddWithValue("@userId", userId);

                    SqlDataReader loginReader = loginCommand.ExecuteReader();
                    if (loginReader.Read())
                    {
                        loginUzytkownika = loginReader.GetString(0);
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono użytkownika o podanym ID.");
                        return;
                    }
                    loginReader.Close();

                    // Sprawdź, czy zasób jest dostępny
                    string query = "SELECT Id, Ilosc FROM zasoby WHERE Tytul = @tytul AND Ilosc > 0";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tytul", tytul);

                    SqlDataReader reader = command.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Zasób o podanym tytule jest niedostępny.");
                        return;
                    }

                    int zasobId = reader.GetInt32(0);
                    int ilosc = reader.GetInt32(1);

                    // Odjęcie jednego zasobu od ilości
                    reader.Close();

                    string updateQuery = "UPDATE zasoby SET Ilosc = Ilosc - 1 WHERE Id = @zasobId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@zasobId", zasobId);
                    updateCommand.ExecuteNonQuery();

                    // Dodanie rekordu do Historii wypożyczeń
                    DateTime dataWypozyczenia = DateTime.Now;
                    DateTime dataZwrotu = dataWypozyczenia.AddMonths(1); // Przykładowa data zwrotu

                    string insertQuery = "INSERT INTO HistoriaWypozyczen (UzytkownikId, ZasobId, DataWypozyczenia, DataZwrotu, LoginUzytkownika, Tytul) " +
                                         "VALUES (@uzytkownikId, @zasobId, @dataWypozyczenia, @dataZwrotu, @loginUzytkownika, @tytulPozycji)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@uzytkownikId", userId);
                    insertCommand.Parameters.AddWithValue("@zasobId", zasobId);
                    insertCommand.Parameters.AddWithValue("@dataWypozyczenia", dataWypozyczenia);
                    insertCommand.Parameters.AddWithValue("@dataZwrotu", dataZwrotu);
                    insertCommand.Parameters.AddWithValue("@loginUzytkownika", loginUzytkownika);
                    insertCommand.Parameters.AddWithValue("@tytulPozycji", tytul);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Pomyślnie wypożyczono zasób.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wypożyczania: " + ex.Message);
            }
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
