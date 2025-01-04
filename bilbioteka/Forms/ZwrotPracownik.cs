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
    public partial class ZwrotPracownik : Form
    {
        public ZwrotPracownik()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            this.Load += new EventHandler(Form1_Load);
        }

        private void LoadData()
        {
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = "SELECT DataWypozyczenia AS 'Wypożyczono', DataZwrotu AS 'Zwrot', LoginUzytkownika, TytulPozycji , TypProduktu AS 'Typ', StatusZwrotu AS 'Status' FROM HistoriaWypozyczen";

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
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private string selectedLogin = string.Empty;
        private string selectedTytul = string.Empty;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Upewnij się, że kliknięto wiersz, a nie nagłówek
            {
                // Pobierz zaznaczony wiersz
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Pobierz wartości z odpowiednich kolumn
                selectedTytul = selectedRow.Cells["TytulPozycji"]?.Value?.ToString() ?? string.Empty;
                selectedLogin = selectedRow.Cells["LoginUzytkownika"]?.Value?.ToString() ?? string.Empty;

                // Wstaw wartości do odpowiednich pól tekstowych
                textBoxTyt.Text = selectedTytul;
                textBoxLog.Text = selectedLogin;
            }
        }

       

        private void buttonOdswiez_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonZwroc_Click_1(object sender, EventArgs e)
        {
            // Sprawdź, czy dane zostały poprawnie pobrane
            if (string.IsNullOrWhiteSpace(selectedLogin))
            {
                MessageBox.Show("Proszę wybrać wiersz zawierający Login użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedTytul))
            {
                MessageBox.Show("Proszę wybrać wiersz zawierający Tytuł zasobu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(selectedLogin) || string.IsNullOrWhiteSpace(selectedTytul))
            {
                MessageBox.Show("Dane wiersza są niekompletne. Upewnij się, że wiersz zawiera zarówno Login, jak i Tytuł.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sprawdzenie statusu zwrotu
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string statusZwrotu = dataGridView1.SelectedRows[0].Cells["Status"]?.Value?.ToString() ?? string.Empty;

                if ((statusZwrotu.Equals("Zwrócono", StringComparison.OrdinalIgnoreCase)) || (statusZwrotu.Equals("KARA", StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Nie można przedłużyć terminu dla zasobu o statusie 'Zwrócono' lub 'KARA'.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Zapytanie użytkownika o potwierdzenie zwrotu
            DialogResult result = MessageBox.Show(
                $"Czy na pewno chcesz zmienić status zasobu '{selectedTytul}' na 'Zwrócono' dla użytkownika '{selectedLogin}'?",
                "Potwierdzenie zwrotu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Połącz się z bazą danych
                    string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Utwórz zapytanie SQL
                        string query = "UPDATE [biblioteka].[dbo].[HistoriaWypozyczen] " +
                                       "SET StatusZwrotu = 'Zwrócono' " +
                                       "WHERE LoginUzytkownika = @LoginUzytkownika AND TytulPozycji = @TytulPozycji";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@LoginUzytkownika", selectedLogin);
                            command.Parameters.AddWithValue("@TytulPozycji", selectedTytul);

                            // Otwórz połączenie i wykonaj zapytanie
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Status zasobu został zmieniony na 'Zwrócono'.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData(); // Odśwież dane w DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Nie znaleziono zasobu do zaktualizowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonWydluzTermin_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć wiersz w DataGridView.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pobranie danych z zaznaczonego wiersza
            var selectedRow = dataGridView1.SelectedRows[0];
            string selectedLogin = selectedRow.Cells["LoginUzytkownika"]?.Value?.ToString() ?? string.Empty;
            string selectedTytul = selectedRow.Cells["TytulPozycji"]?.Value?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(selectedLogin) || string.IsNullOrWhiteSpace(selectedTytul))
            {
                MessageBox.Show("Dane wiersza są niekompletne. Upewnij się, że wiersz zawiera zarówno Login, jak i Tytuł.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sprawdzenie statusu zwrotu
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string statusZwrotu = dataGridView1.SelectedRows[0].Cells["Status"]?.Value?.ToString() ?? string.Empty;

                if ((statusZwrotu.Equals("Zwrócono", StringComparison.OrdinalIgnoreCase)) || (statusZwrotu.Equals("KARA", StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Nie można przedłużyć terminu dla zasobu o statusie 'Zwrócono' lub 'KARA'.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Zapytanie o potwierdzenie
            DialogResult result = MessageBox.Show(
                "Czy na pewno chcesz przedłużyć termin zwrotu o dodatkowy miesiąc?",
                "Potwierdzenie przedłużenia terminu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                MessageBox.Show("Przedłużenie terminu zwrotu zostało anulowane.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Wykonanie aktualizacji w bazie danych
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                UPDATE [biblioteka].[dbo].[HistoriaWypozyczen]
                SET DataZwrotu = DATEADD(MONTH, 1, DataZwrotu)
                WHERE LoginUzytkownika = @LoginUzytkownika AND TytulPozycji = @TytulPozycji";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LoginUzytkownika", selectedLogin);
                        command.Parameters.AddWithValue("@TytulPozycji", selectedTytul);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Termin zwrotu został przedłużony o dodatkowy miesiąc.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono rekordu do zaktualizowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // Odświeżenie danych
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
