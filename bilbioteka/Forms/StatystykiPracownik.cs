using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class StatystykiPracownik : Form
    {
        public StatystykiPracownik()
        {
            InitializeComponent();
            WyswietlIloscUzytkownikow();  
            WyswietlIloscWypozyczen();    
            WyswietlNajaktywniejszegoUzytkownika(); 
            WyswietlNajczesciejWypozyczaneTytuly();
            WyswietlNajpopularniejszeGatunki();
        }

        private void WyswietlIloscUzytkownikow()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM [biblioteka].[dbo].[uzytkownicy]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int liczbaUzytkownikow = (int)command.ExecuteScalar();
                        labelIloscUzytkownikow.Text = $"{liczbaUzytkownikow}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania liczby użytkowników: {ex.Message}");
            }
        }

        private void WyswietlIloscWypozyczen()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM [biblioteka].[dbo].[HistoriaWypozyczen]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int liczbaWypozyczen = (int)command.ExecuteScalar();
                        labelIloscWypozyczen.Text = $"{liczbaWypozyczen}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania liczby wypożyczeń: {ex.Message}");
            }
        }

        private void WyswietlNajaktywniejszegoUzytkownika()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL do znalezienia użytkownika z największą liczbą wypożyczeń
                    string query = @"
                        SELECT TOP 1 
                            u.Imie, 
                            u.Nazwisko, 
                            COUNT(h.Id) AS LiczbaWypozyczen
                        FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                        JOIN [biblioteka].[dbo].[uzytkownicy] u ON h.UzytkownikId = u.Id
                        GROUP BY u.Imie, u.Nazwisko
                        ORDER BY LiczbaWypozyczen DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string imie = reader["Imie"].ToString();
                                string nazwisko = reader["Nazwisko"].ToString();
                                int liczbaWypozyczen = (int)reader["LiczbaWypozyczen"];

                                labelUzytkownik.Text = $"{imie} {nazwisko} ({liczbaWypozyczen} wypożyczeń)";
                            }
                            else
                            {
                                labelUzytkownik.Text = "Brak danych o wypożyczeniach.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania najaktywniejszego użytkownika: {ex.Message}");
            }
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

                    // Zapytanie SQL do znalezienia 5 najczęściej wypożyczanych tytułów wraz z oceną
                    string query = @"
                SELECT TOP 5 
                    z.Tytul, 
                    COUNT(h.Id) AS LiczbaWypozyczen,
                    AVG(z.Ocena) AS SredniaOcena
                FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                GROUP BY z.Tytul
                ORDER BY LiczbaWypozyczen DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridViewPozycja.DataSource = dataTable;

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

                        // Automatyczne dopasowanie kolumn
                        dataGridViewPozycja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Automatyczne dopasowanie wierszy
                        dataGridViewPozycja.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // Ustawienie stylu dla lepszej czytelności
                        dataGridViewPozycja.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania najczęściej wypożyczanych tytułów: {ex.Message}");
            }
        }



        private void WyswietlNajpopularniejszeGatunki()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL do znalezienia 5 najpopularniejszych kategorii/gatunków
                    string query = @"
                SELECT TOP 5 
                    z.Kategoria, 
                    COUNT(h.Id) AS LiczbaWypozyczen
                FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                GROUP BY z.Kategoria
                ORDER BY LiczbaWypozyczen DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridViewGatunki.DataSource = dataTable;

                        // Opcjonalnie: zmiana nagłówków kolumn w DataGridView
                        dataGridViewGatunki.Columns["Kategoria"].HeaderText = "Gatunek/Kategoria";
                        dataGridViewGatunki.Columns["LiczbaWypozyczen"].HeaderText = "Liczba Wypożyczeń";

                        // Automatyczne dopasowanie kolumn
                        dataGridViewGatunki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Automatyczne dopasowanie wierszy
                        dataGridViewGatunki.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania najpopularniejszych gatunków: {ex.Message}");
            }
        }


    }
}
