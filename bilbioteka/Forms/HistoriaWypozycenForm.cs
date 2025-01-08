using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class HistoriaWypozycenForm : Form
    {
        private string login;
       

        public HistoriaWypozycenForm(string login)
        {
            InitializeComponent();
            this.login = login;
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
    k.KwotaKary AS 'kara [zł]'
FROM
    HistoriaWypozyczen AS h
JOIN
    kary AS k
ON
    h.LoginUzytkownika = k.Login AND h.TytulPozycji = k.Tytul
WHERE
    h.LoginUzytkownika = @loginUzytkownika";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@loginUzytkownika", login);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Przypisz dane do dataGridView1
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania historii wypożyczeń: " + ex.Message);
            }
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
