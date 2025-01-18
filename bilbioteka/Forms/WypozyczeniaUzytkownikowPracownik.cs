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
    public partial class WypozyczeniaUzytkownikowPracownik : Form
    {
        public WypozyczeniaUzytkownikowPracownik()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = "SELECT LoginUzytkownika AS 'Login', TytulPozycji AS 'Tytul', TypProduktu AS 'Typ', DataWypozyczenia AS 'Wypożyczenie', DataZwrotu AS 'Zwrot',  StatusZwrotu AS 'Status' FROM HistoriaWypozyczen  ";

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

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchData()
        {

            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = string.Empty;
            string searchValue = textBox1.Text;

            // Ustal zapytanie w zależności od wybranego kryterium
            switch (comboBox1.SelectedItem?.ToString())
            {
                case null:
                case "":
                    query = "SELECT LoginUzytkownika AS 'Login', TytulPozycji AS 'Tytul', TypProduktu AS 'Typ', DataWypozyczenia AS 'Wypożyczenie', DataZwrotu AS 'Zwrot',  StatusZwrotu AS 'Status' FROM HistoriaWypozyczen ";
                    break;
                case "Login":
                    query = "SELECT LoginUzytkownika AS 'Login', TytulPozycji AS 'Tytul', TypProduktu AS 'Typ', DataWypozyczenia AS 'Wypożyczenie', DataZwrotu AS 'Zwrot',  StatusZwrotu AS 'Status' FROM HistoriaWypozyczen WHERE LoginUzytkownika LIKE @searchValue";
                    break;
                case "Tytul":
                    query = "SELECT LoginUzytkownika AS 'Login', TytulPozycji AS 'Tytul', TypProduktu AS 'Typ', DataWypozyczenia AS 'Wypożyczenie', DataZwrotu AS 'Zwrot',  StatusZwrotu AS 'Status' FROM HistoriaWypozyczen WHERE TytulPozycji LIKE @searchValue ";
                    break;
                case "Status":
                    query = "SELECT LoginUzytkownika AS 'Login', TytulPozycji AS 'Tytul', TypProduktu AS 'Typ', DataWypozyczenia AS 'Wypożyczenie', DataZwrotu AS 'Zwrot',  StatusZwrotu AS 'Status' FROM HistoriaWypozyczen WHERE StatusZwrotu LIKE @searchValue";
                    break;

            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Dodaj parametry w zależności od kryterium
                        switch (comboBox1.SelectedItem?.ToString())
                        {

                            case "Login":
                                cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
                                break;
                            case "Tytul":
                                cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
                                break;
                            case "Status":
                                cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
                                break;

                        }

                        // Wypełnij DataTable i przypisz do DataGridView
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }


        private void buttonSzukaj_Click_1(object sender, EventArgs e)
        {
            SearchData();
        }

    }
}
