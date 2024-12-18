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
    public partial class EdytujCennikAdmin : Form
    {
        public EdytujCennikAdmin()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadData()
        {
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = "SELECT Produkt, CenaZaDzien AS 'Cena za dzień [zł]', CenaZaNowe AS 'Cena za nowy [zł]' FROM Cennik ";

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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sprawdzanie, czy kliknięto prawidłowy wiersz (pomijając nagłówki)
            if (e.RowIndex >= 0)
            {
                // Pobierz aktualny wiersz
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Przenieś dane do odpowiednich TextBoxów
                textBoxProdukt.Text = selectedRow.Cells["Produkt"].Value?.ToString() ?? string.Empty;
                textBoxZaDzien.Text = selectedRow.Cells["Cena za dzień [zł]"].Value?.ToString() ?? string.Empty;
                textBoxNowe.Text = selectedRow.Cells["Cena za nowy [zł]"].Value?.ToString() ?? string.Empty;
            }
        }

        private void buttonZalogujRej_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            {
                // Walidacja pól
                if (string.IsNullOrWhiteSpace(textBoxProdukt.Text) ||
                    string.IsNullOrWhiteSpace(textBoxZaDzien.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNowe.Text))
                {
                    MessageBox.Show("Wszystkie pola muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textBoxZaDzien.Text, out int cena) || cena < 0)
                {
                    MessageBox.Show("Cena musi być większa od zera!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(textBoxNowe.Text, out int cena2) || cena2 < 0)
                {
                    MessageBox.Show("Cena musi być większa od zera!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string produkt = textBoxProdukt.Text;
                string cenaZaDzien = textBoxZaDzien.Text;
                string cenaZaNowe = textBoxNowe.Text;

                // Sprawdzanie czy tytuł i numer katalogowy istnieją w bazie danych
                using (SqlConnection connection = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
                {
                    connection.Open();

                    // Sprawdzanie zasobu
                    string query = "SELECT Produkt FROM Cennik WHERE produkt = @Produkt";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Produkt", produkt);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {


                            string updateQuery = "UPDATE Cennik SET cenaZaDzien = @CenaZaDzien, cenaZaNowe = @CenaZaNowe WHERE produkt = @Produkt";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@CenaZaDzien", cenaZaDzien);
                                updateCommand.Parameters.AddWithValue("@CenaZaNowe", cenaZaNowe);
                                updateCommand.Parameters.AddWithValue("@Produkt", produkt);
                                updateCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Cena została zaktualizowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Produkt nie znajduje się w cenniku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
