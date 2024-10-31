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

            // Sprawdź, czy ID użytkownika jest liczbą
            if (!int.TryParse(textBox1.Text, out userId))
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
                    reader.Close(); // Zamknij reader przed ponownym otwarciem połączenia

                    string updateQuery = "UPDATE zasoby SET Ilosc = Ilosc - 1 WHERE Id = @zasobId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@zasobId", zasobId);
                    updateCommand.ExecuteNonQuery();

                    // Dodanie rekordu do Historii wypożyczeń
                    DateTime dataWypozyczenia = DateTime.Now;
                    DateTime dataZwrotu = dataWypozyczenia.AddMonths(1); // Przykładowa data zwrotu

                    string insertQuery = "INSERT INTO HistoriaWypozyczen (UzytkownikId, ZasobId, DataWypozyczenia, DataZwrotu) " +
                                         "VALUES (@uzytkownikId, @zasobId, @dataWypozyczenia, @dataZwrotu)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@uzytkownikId", userId);
                    insertCommand.Parameters.AddWithValue("@zasobId", zasobId);
                    insertCommand.Parameters.AddWithValue("@dataWypozyczenia", dataWypozyczenia);
                    insertCommand.Parameters.AddWithValue("@dataZwrotu", dataZwrotu);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Pomyślnie wypożyczono zasób.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wypożyczania: " + ex.Message);
            }
        }
    }
}
