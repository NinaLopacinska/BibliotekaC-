using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Text;
using iText;


namespace bilbioteka
{
    internal class Raport
    {
        private readonly string _nazwaRaportu;
        private readonly string _opisRaportu;
        private readonly string _connectionString;

        public Raport(string nazwaRaportu, string opisRaportu, string connectionString)
        {
            _nazwaRaportu = nazwaRaportu;
            _opisRaportu = opisRaportu;
            _connectionString = connectionString;
        }

        public List<string> GenerujRaport()
        {
            List<string> raportList = new List<string>();
            raportList.Add($"RAPORT: {_nazwaRaportu.ToUpper()}\n");
            raportList.Add($"Opis: {_opisRaportu}\n");
            raportList.Add(new string('-', 50) + "\n");

            try
            {
                // Dodanie wyników z zapytań do raportu
                raportList.Add(PobierzNajczesciejWypozyczanaPozycje());
                raportList.Add(PobierzNajczesciejWypozyczanaPozycjeWMiesiacu());
                raportList.Add(PobierzSredniaLiczbeWypozyczenWMiesiacu());
                raportList.Add(PobierzStatystykiZasobow());
                raportList.Add(PobierzNajczestszeWydawnictwo());
            }
            catch (Exception ex)
            {
                raportList.Add($"Wystąpił błąd podczas generowania raportu: {ex.Message}\n");
            }

            return raportList;
        }

        private string PobierzNajczesciejWypozyczanaPozycje()
        {
            const string query = @"
                SELECT TOP 1 z.Tytul, z.Typ, z.Autor, COUNT(h.Id) AS LiczbaWypozyczen
                FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                GROUP BY z.Tytul, z.Typ, z.Autor
                ORDER BY LiczbaWypozyczen DESC";

            return WykonajZapytanieSQL(query, reader =>
            {
                string typ = reader["Typ"].ToString();
                string tytul = reader["Tytul"].ToString();
                string autor = reader["Autor"].ToString();
                int liczbaWypozyczen = Convert.ToInt32(reader["LiczbaWypozyczen"]);

                return $"Najczęściej wypożyczany zasób: {typ} '{tytul}' autorstwa {autor}. Liczba wypożyczeń: {liczbaWypozyczen}.\n";
            });
        }

        private string PobierzNajczesciejWypozyczanaPozycjeWMiesiacu()
        {
            const string query = @"
                SELECT TOP 1 z.Tytul, z.Autor, z.Typ, COUNT(h.Id) AS Wypozyczenia
                FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                WHERE MONTH(h.DataWypozyczenia) = MONTH(GETDATE())
                GROUP BY z.Tytul, z.Autor, z.Typ
                ORDER BY Wypozyczenia DESC";

            return WykonajZapytanieSQL(query, reader =>
            {
                string typ = reader["Typ"].ToString();
                string tytul = reader["Tytul"].ToString();
                string autor = reader["Autor"].ToString();
                int liczbaWypozyczen = Convert.ToInt32(reader["Wypozyczenia"]);

                return $"Najczęściej wypożyczany w tym miesiącu: {typ} '{tytul}' autorstwa {autor}. Liczba wypożyczeń: {liczbaWypozyczen}.\n";
            });
        }

        private string PobierzSredniaLiczbeWypozyczenWMiesiacu()
        {
            const string query = @"
                WITH WypozyczeniaNaMiesiac AS (
                    SELECT YEAR(DataWypozyczenia) AS Rok, MONTH(DataWypozyczenia) AS Miesiac, COUNT(Id) AS LiczbaWypozyczen
                    FROM HistoriaWypozyczen
                    GROUP BY YEAR(DataWypozyczenia), MONTH(DataWypozyczenia)
                )
                SELECT AVG(LiczbaWypozyczen) AS SredniaWypozyczenWMiesiacu
                FROM WypozyczeniaNaMiesiac";

            return WykonajZapytanieSQL(query, reader =>
            {
                double srednia = Convert.ToDouble(reader["SredniaWypozyczenWMiesiacu"]);
                return $"Średnia liczba wypożyczeń w miesiącu: {srednia:F2}\n";
            });
        }

        private string PobierzStatystykiZasobow()
        {
            const string query = @"
                SELECT 
                    COUNT(CASE WHEN Typ LIKE 'Książka' THEN 1 END) AS LiczbaKsiazek,
                    COUNT(CASE WHEN Typ LIKE 'Film' THEN 1 END) AS LiczbaFilmow,
                    COUNT(CASE WHEN Typ LIKE 'Album' THEN 1 END) AS LiczbaAlbumow,
                    COUNT(Id) AS LiczbaZasobow
                FROM [biblioteka].[dbo].[zasoby]";

            return WykonajZapytanieSQL(query, reader =>
            {
                int ksiazki = Convert.ToInt32(reader["LiczbaKsiazek"]);
                int filmy = Convert.ToInt32(reader["LiczbaFilmow"]);
                int albumy = Convert.ToInt32(reader["LiczbaAlbumow"]);
                int zasoby = Convert.ToInt32(reader["LiczbaZasobow"]);

                return $"Statystyki zasobów:\n" +
                       $"- Liczba książek: {ksiazki}\n" +
                       $"- Liczba filmów: {filmy}\n" +
                       $"- Liczba albumów: {albumy}\n" +
                       $"- Łączna liczba zasobów: {zasoby}\n";
            });
        }

        private string PobierzNajczestszeWydawnictwo()
        {
            const string query = @"
                SELECT TOP 1 z.Wydawnictwo, COUNT(h.Id) AS LiczbaWypozyczen
                FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                GROUP BY z.Wydawnictwo
                ORDER BY LiczbaWypozyczen DESC";

            return WykonajZapytanieSQL(query, reader =>
            {
                string wydawnictwo = reader["Wydawnictwo"].ToString();
                int liczbaWypozyczen = Convert.ToInt32(reader["LiczbaWypozyczen"]);

                return $"Najczęściej wypożyczane wydawnictwo: {wydawnictwo}. Liczba wypożyczeń: {liczbaWypozyczen}.\n";
            });
        }

        private string WykonajZapytanieSQL(string query, Func<SqlDataReader, string> processRow)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return processRow(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Błąd wykonania zapytania SQL: {ex.Message}\n";
            }

            return "Brak danych do wyświetlenia.\n";
        }
    }
}
