using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class WypozyczeniePracownikForm : Form
    {
        public WypozyczeniePracownikForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void buttonWypozycz_Click_1(object sender, EventArgs e)
        {
            string tytul = textBoxTytul.Text;
            string login = textBoxLogin.Text;
            string typ = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Proszę wpisać login użytkownika.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tytul))
            {
                MessageBox.Show("Proszę wpisać tytuł zasobu.");
                return;
            }

            if (string.IsNullOrWhiteSpace(typ))
            {
                MessageBox.Show("Proszę wybrać typ zasobu.");
                return;
            }

            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Sprawdź, czy login użytkownika istnieje w bazie i czy ma IdOsoby = 1
                    string loginQuery = "SELECT Id, IdOsoby FROM uzytkownicy WHERE Login = @login";
                    SqlCommand loginCommand = new SqlCommand(loginQuery, connection);
                    loginCommand.Parameters.AddWithValue("@login", login);

                    int uzytkownikId;
                    int idOsoby;

                    using (SqlDataReader reader = loginCommand.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Użytkownik o podanym loginie nie istnieje.");
                            return;
                        }

                        uzytkownikId = reader.GetInt32(0);
                        idOsoby = reader.GetInt32(1);

                        // Jeśli IdOsoby jest różne od 1, wyświetl komunikat o braku uprawnień do wypożyczenia
                        if (idOsoby != 1)
                        {
                            MessageBox.Show("Podana osoba jest Pracownikiem lub Administratorem i nie można jej wypożyczyć produktu.");
                            return;
                        }
                    }

                    // Sprawdź, czy zasób o podanym tytule i typie jest dostępny
                    string zasobQuery = "SELECT Id, Ilosc FROM zasoby WHERE Tytul = @tytul AND Typ = @typ AND Ilosc > 0";
                    SqlCommand zasobCommand = new SqlCommand(zasobQuery, connection);
                    zasobCommand.Parameters.AddWithValue("@tytul", tytul);
                    zasobCommand.Parameters.AddWithValue("@typ", typ);

                    int zasobId;

                    using (SqlDataReader zasobReader = zasobCommand.ExecuteReader())
                    {
                        if (!zasobReader.Read())
                        {
                            MessageBox.Show("Zasób o podanym tytule i typie jest niedostępny.");
                            return;
                        }

                        zasobId = zasobReader.GetInt32(0);
                        // Można usunąć nieużywaną zmienną `ilosc`
                    }

                    // Zmniejszenie ilości dostępnych zasobów
                    string updateQuery = "UPDATE zasoby SET Ilosc = Ilosc - 1 WHERE Id = @zasobId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@zasobId", zasobId);
                    updateCommand.ExecuteNonQuery();

                    // Dodanie rekordu do tabeli HistoriaWypozyczen
                    DateTime dataWypozyczenia = DateTime.Now;
                    DateTime dataZwrotu = dataWypozyczenia.AddMonths(1);

                    string insertQuery = "INSERT INTO HistoriaWypozyczen (UzytkownikId, ZasobId, DataWypozyczenia, DataZwrotu, LoginUzytkownika, TytulPozycji, TypProduktu) " +
                                         "VALUES (@uzytkownikId, @zasobId, @dataWypozyczenia, @dataZwrotu, @loginUzytkownika, @tytulPozycji, @typProduktu)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@uzytkownikId", uzytkownikId);
                    insertCommand.Parameters.AddWithValue("@zasobId", zasobId);
                    insertCommand.Parameters.AddWithValue("@dataWypozyczenia", dataWypozyczenia);
                    insertCommand.Parameters.AddWithValue("@dataZwrotu", dataZwrotu);
                    insertCommand.Parameters.AddWithValue("@loginUzytkownika", login);
                    insertCommand.Parameters.AddWithValue("@tytulPozycji", tytul);
                    insertCommand.Parameters.AddWithValue("@typProduktu", typ);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Pomyślnie wypożyczono zasób.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Wystąpił błąd w bazie danych: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }
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
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = "SELECT * FROM HistoriaWypozyczen";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Wystąpił błąd w bazie danych: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }

        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
