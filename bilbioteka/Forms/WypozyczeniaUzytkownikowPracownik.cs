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
            string query = "SELECT IloscDniKary AS 'Długość kary', KwotaKary AS 'Kwota [zł]', Login, Tytul , Typ, StatusKary FROM kary  ";

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
                    query = "SELECT IloscDniKary AS 'Długość kary', KwotaKary AS 'Kwota [zł]', Login, Tytul, Typ, StatusKary FROM kary ";
                    break;
                case "Login":
                    query = "SELECT IloscDniKary AS 'Długość kary', KwotaKary AS 'Kwota [zł]', Login, Tytul, Typ, StatusKary FROM kary WHERE Login LIKE @searchValue";
                    break;
                case "Tytul":
                    query = "SELECT IloscDniKary AS 'Długość kary', KwotaKary AS 'Kwota [zł]', Login, Tytul, Typ, StatusKary FROM kary WHERE Tytul LIKE @searchValue ";
                    break;
                case "StatusKary":
                    query = "SELECT IloscDniKary AS 'Długość kary', KwotaKary AS 'Kwota [zł]', Login, Tytul, Typ, StatusKary FROM kary WHERE StatusKary LIKE @searchValue";
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
                            case "StatusKary":
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
