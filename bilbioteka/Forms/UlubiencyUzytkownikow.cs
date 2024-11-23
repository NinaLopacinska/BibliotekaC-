using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bilbioteka.Forms 
{
    public partial class UlubiencyUzytkownikow : Form
    {
        public UlubiencyUzytkownikow()
        {
            InitializeComponent();
            WyswietlNajczesciejWypozyczaneTytuly();
            WyswietlNajlepiejOceniane();
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WyswietlNajczesciejWypozyczaneTytuly()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT  
                            z.Tytul, 
                            z.Typ,
                            COUNT(h.Id) AS LiczbaWypozyczen,
                            AVG(z.Ocena) AS SredniaOcena
                        FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                        JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                        GROUP BY z.Tytul, z.Typ
                        ORDER BY LiczbaWypozyczen DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            dataGridViewPozycja.DataSource = dataTable;
                        }
                        // Zmiana nagłówków kolumn w DataGridView
                        dataGridViewPozycja.Columns["Tytul"].HeaderText = "Tytuł";
                        dataGridViewPozycja.Columns["LiczbaWypozyczen"].HeaderText = "Liczba Wypożyczeń";
                        dataGridViewPozycja.Columns["SredniaOcena"].HeaderText = "Średnia Ocena";

                        // Formatuj średnią ocenę do 2 miejsc po przecinku
                        foreach (DataGridViewRow row in dataGridViewPozycja.Rows)
                        {
                            if (row.Cells["SredniaOcena"].Value != DBNull.Value)
                            {
                                // Formatuj średnią ocenę do dwóch miejsc po przecinku
                                row.Cells["SredniaOcena"].Value = string.Format("{0:F2}", row.Cells["SredniaOcena"].Value);
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Błąd bazy danych: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania danych: {ex.Message}");
            }
        }

        private void WyswietlNajlepiejOceniane()
        {
            try
            {
                // Pobierz stany checkBoxów
                bool checkKsiazki = checkBoxKsiazki.Checked;
                bool checkFilmy = checkBoxFilmy.Checked;
                bool checkAlbumy = checkBoxAlbumy.Checked;

                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
                string query;

                // Określenie zapytania SQL na podstawie stanu checkBoxów
                if (checkKsiazki && !checkFilmy && !checkAlbumy)
                {
                    query = "SELECT Tytul, Autor, Typ, Kategoria, Ocena FROM Zasoby WHERE Typ = 'Książka' ORDER BY Ocena DESC";
                }
                else if (!checkKsiazki && checkFilmy && !checkAlbumy)
                {
                    query = "SELECT Tytul, Autor, Typ, Kategoria, Ocena FROM Zasoby WHERE Typ = 'Film' ORDER BY Ocena DESC";
                }
                else if (!checkKsiazki && !checkFilmy && checkAlbumy)
                {
                    query = "SELECT Tytul, Autor, Typ, Kategoria, Ocena FROM Zasoby WHERE Typ = 'Album' ORDER BY Ocena DESC";
                }
                else if (checkKsiazki && checkFilmy && !checkAlbumy)
                {
                    query = "SELECT Tytul, Autor, Typ, Kategoria, Ocena FROM Zasoby WHERE Typ = 'Książka' OR Typ = 'Film' ORDER BY Ocena DESC";
                }
                else if (checkKsiazki && !checkFilmy && checkAlbumy)
                {
                    query = "SELECT Tytul, Autor, Typ, Kategoria, Ocena FROM Zasoby WHERE Typ = 'Książka' OR Typ = 'Album' ORDER BY Ocena DESC";
                }
                else if (!checkKsiazki && checkFilmy && checkAlbumy)
                {
                    query = "SELECT Tytul, Autor, Typ, Kategoria, Ocena FROM Zasoby WHERE Typ = 'Film' OR Typ = 'Album' ORDER BY Ocena DESC";
                }
                else
                {
                    // Jeśli żaden checkBox nie jest zaznaczony lub więcej niż jeden
                    query = "SELECT Tytul, Autor, Typ, Kategoria, Ocena FROM Zasoby ORDER BY Ocena DESC";
                }

                // Wywołanie zapytania i wyświetlenie wyników
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridViewGatunki.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Błąd bazy danych: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania danych: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WyswietlNajlepiejOceniane();
        }
    }
}
