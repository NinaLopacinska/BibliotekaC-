using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        public List<string> GenerujRaport(DateTime dataOd, DateTime dataDo)
        {
            List<string> raportList = new List<string>
            {
                $"RAPORT: {_nazwaRaportu.ToUpper()}\n",
                $"Opis: {_opisRaportu}\n",
                $"Zakres dat: od {dataOd:yyyy-MM-dd} do {dataDo:yyyy-MM-dd}\n",
                new string('-', 50) + "\n"
            };

            try
            {
                
                raportList.Add(PobierzNajczesciejWypozyczanaPozycjeWMiesiacu(dataOd, dataDo));
                raportList.Add(PobierzSredniaLiczbeWypozyczenWMiesiacu(dataOd, dataDo));
                raportList.Add(PobierzStatystykiZasobow());
                raportList.Add(PobierzNajczestszeWydawnictwo(dataOd, dataDo));
                raportList.Add(PobierzZasobyWBibliotece());
                raportList.Add(PobierzLiczbeUzytkownikow());
                raportList.Add(PobierzLiczbeDluznikow());
                raportList.Add(PobierzLiczbePracownikow());
            }
            catch (Exception ex)
            {
                raportList.Add($"Wystąpił błąd podczas generowania raportu: {ex.Message}\n");
            }

            return raportList;
        }

        private string PobierzNajczesciejWypozyczanaPozycje(DateTime dataOd, DateTime dataDo)
        {
            const string query = @"
                SELECT TOP 1 z.Tytul, z.Typ, z.Autor, COUNT(h.Id) AS LiczbaWypozyczen
                FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                WHERE h.DataWypozyczenia BETWEEN @DataOd AND @DataDo
                GROUP BY z.Tytul, z.Typ, z.Autor
                ORDER BY LiczbaWypozyczen DESC";

            return WykonajZapytanieSQL(query, reader =>
            {
                string typ = reader["Typ"].ToString();
                string tytul = reader["Tytul"].ToString();
                string autor = reader["Autor"].ToString();
                int liczbaWypozyczen = Convert.ToInt32(reader["LiczbaWypozyczen"]);

                return $"Najczęściej wypożyczany zasób: {typ} '{tytul}' autorstwa {autor}. Liczba wypożyczeń: {liczbaWypozyczen}.\n";
            }, dataOd, dataDo);
        }

        private string PobierzNajczesciejWypozyczanaPozycjeWMiesiacu(DateTime dataOd, DateTime dataDo)
        {
            const string query = @"
                SELECT TOP 1 z.Tytul, z.Autor, z.Typ, COUNT(h.Id) AS Wypozyczenia
                FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                WHERE h.DataWypozyczenia BETWEEN @DataOd AND @DataDo
                GROUP BY z.Tytul, z.Autor, z.Typ
                ORDER BY Wypozyczenia DESC";

            return WykonajZapytanieSQL(query, reader =>
            {
                string typ = reader["Typ"].ToString();
                string tytul = reader["Tytul"].ToString();
                string autor = reader["Autor"].ToString();
                int liczbaWypozyczen = Convert.ToInt32(reader["Wypozyczenia"]);

                return $"Najczęściej wypożyczany w podanym okresie: {typ} '{tytul}' autorstwa {autor}. Liczba wypożyczeń: {liczbaWypozyczen}.\n";
            }, dataOd, dataDo);
        }

        private string PobierzSredniaLiczbeWypozyczenWMiesiacu(DateTime dataOd, DateTime dataDo)
        {
            const string query = @"
                WITH WypozyczeniaNaMiesiac AS (
                    SELECT YEAR(DataWypozyczenia) AS Rok, MONTH(DataWypozyczenia) AS Miesiac, COUNT(Id) AS LiczbaWypozyczen
                    FROM HistoriaWypozyczen
                    WHERE DataWypozyczenia BETWEEN @DataOd AND @DataDo
                    GROUP BY YEAR(DataWypozyczenia), MONTH(DataWypozyczenia)
                )
                SELECT AVG(LiczbaWypozyczen) AS SredniaWypozyczenWMiesiacu
                FROM WypozyczeniaNaMiesiac";

            return WykonajZapytanieSQL(query, reader =>
            {
                double srednia = Convert.ToDouble(reader["SredniaWypozyczenWMiesiacu"]);
                return $"Średnia liczba wypożyczeń w miesiącu: {srednia:F2}.\n";
            }, dataOd, dataDo);
        }

        private string PobierzStatystykiZasobow()
        {
            const string query = @"
                SELECT 
                    COUNT(CASE WHEN Typ LIKE 'Książka' THEN 1 END) AS LiczbaKsiazek,
                    COUNT(CASE WHEN Typ LIKE 'Film' THEN 1 END) AS LiczbaFilmow,
                    COUNT(CASE WHEN Typ LIKE 'Album' THEN 1 END) AS LiczbaAlbumow,
                    COUNT(Id) AS LiczbaZasobow
                FROM [biblioteka].[dbo].[zasoby]
                WHERE StanZasobu = 'Aktywny'";

            return WykonajZapytanieSQL(query, reader =>
            {
                int ksiazki = Convert.ToInt32(reader["LiczbaKsiazek"]);
                int filmy = Convert.ToInt32(reader["LiczbaFilmow"]);
                int albumy = Convert.ToInt32(reader["LiczbaAlbumow"]);
                int zasoby = Convert.ToInt32(reader["LiczbaZasobow"]);

                return $"Statystyki zasobów: \nLiczba książek: {ksiazki} \nLiczba filmów: {filmy} \nLiczba albumów: {albumy} \nŁączna liczba zasobów: {zasoby} \n";
            });
        }

        private string PobierzZasobyWBibliotece()
        {
            const string query = @"
                SELECT COUNT(h.Id) AS LiczbaPozaBiblio
                FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                WHERE StatusZwrotu = 'Nie zwrócono'";

            return WykonajZapytanieSQL(query, reader =>
            {
                int liczbaWypozyczen = Convert.ToInt32(reader["LiczbaPozaBiblio"]);
                return $"Liczba obecnie wypożyczonych pozycji wynosi: {liczbaWypozyczen}. \n";
            });
        }

        private string PobierzNajczestszeWydawnictwo(DateTime dataOd, DateTime dataDo)
        {
            const string query = @"
        SELECT TOP 1 z.Wydawnictwo, COUNT(h.Id) AS LiczbaWypozyczen
        FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
        JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
        WHERE h.DataWypozyczenia BETWEEN @DataOd AND @DataDo
        GROUP BY z.Wydawnictwo
        ORDER BY LiczbaWypozyczen DESC";

            return WykonajZapytanieSQL(query, reader =>
            {
                string wydawnictwo = reader["Wydawnictwo"].ToString();
                int liczbaWypozyczen = Convert.ToInt32(reader["LiczbaWypozyczen"]);

                return $"Najczęściej wypożyczane wydawnictwo: {wydawnictwo}. \nLiczba wypożyczeń: {liczbaWypozyczen}. \n";
            }, dataOd, dataDo);
        }


        private string PobierzLiczbeUzytkownikow()
        {
            const string query = @"
                SELECT COUNT(Id) AS LiczbaUzytkownikow
                FROM [biblioteka].[dbo].[uzytkownicy]
                WHERE IdOsoby = 1 AND Stan = 'Aktywny'";

            return WykonajZapytanieSQL(query, reader =>
            {
                int liczbaUzytkownikow = Convert.ToInt32(reader["LiczbaUzytkownikow"]);
                return $"Liczba zarejestrowanych użytkowników wynosi: {liczbaUzytkownikow}. \n";
            });
        }

        private string PobierzLiczbeDluznikow()
        {
            const string query = @"
                SELECT COUNT(Id) AS LiczbaDluznikow
                FROM [biblioteka].[dbo].[kary]
                WHERE StatusKary = 'KARA'";

            return WykonajZapytanieSQL(query, reader =>
            {
                int liczbaDluznikow = Convert.ToInt32(reader["LiczbaDluznikow"]);
                return $"Liczba dłużników biblioteki wynosi: {liczbaDluznikow}. \n";
            });
        }

        private string PobierzLiczbePracownikow()
        {
            const string query = @"
                SELECT COUNT(Id) AS LiczbaPracownikow
                FROM [biblioteka].[dbo].[uzytkownicy]
                WHERE IdOsoby = 2 AND Stan = 'Aktywny'";

            return WykonajZapytanieSQL(query, reader =>
            {
                int liczbaPracownikow = Convert.ToInt32(reader["LiczbaPracownikow"]);
                return $"Liczba zatrudnionych pracowników biblioteki wynosi: {liczbaPracownikow}. \n";
            });
        }

        private string WykonajZapytanieSQL(string query, Func<SqlDataReader, string> processRow, DateTime dataOd = default, DateTime dataDo = default)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (dataOd != default && dataDo != default)
                        {
                            command.Parameters.AddWithValue("@DataOd", dataOd);
                            command.Parameters.AddWithValue("@DataDo", dataDo);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return processRow(reader);
                            }
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
