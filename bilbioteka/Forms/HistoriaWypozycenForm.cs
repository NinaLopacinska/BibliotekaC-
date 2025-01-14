using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class HistoriaWypozycenForm : Form
    {
        private readonly string login; // Dodano readonly, ponieważ wartość login nie powinna się zmieniać po przypisaniu

        public HistoriaWypozycenForm(string login)
        {
            InitializeComponent();
            this.login = login ?? throw new ArgumentNullException(nameof(login), "Login użytkownika nie może być pusty."); // Sprawdzenie, czy login jest null
            LoadData(); // Załaduj dane po utworzeniu formularza
        }

        // Metoda ładująca historię wypożyczeń dla zalogowanego użytkownika
        private void LoadData()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL, które wybiera wszystkie kolumny z tabeli HistoriaWypozyczen dla konkretnego użytkownika
                    string query = @"SELECT 
                                        h.DataWypozyczenia AS 'Wypożyczenie', 
                                        h.DataZwrotu AS 'Zwrot', 
                                        h.TytulPozycji AS 'Tytuł', 
                                        h.TypProduktu AS 'Typ', 
                                        h.StatusZwrotu AS 'Status', 
                                        COALESCE(k.KwotaKary, 0) AS 'Kara [zł]'
                                    FROM
                                        HistoriaWypozyczen AS h
                                    LEFT JOIN
                                        kary AS k
                                    ON
                                        h.LoginUzytkownika = k.Login AND h.TytulPozycji = k.Tytul
                                    WHERE
                                        h.LoginUzytkownika = @loginUzytkownika;
                                    ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@loginUzytkownika", SqlDbType.NVarChar).Value = login; // Uniknięcie AddWithValue

                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable; // Przypisz dane do dataGridView1
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Wystąpił błąd bazy danych: " + sqlEx.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania historii wypożyczeń: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close(); // Zamknij formularz po kliknięciu
        }
    }
}

