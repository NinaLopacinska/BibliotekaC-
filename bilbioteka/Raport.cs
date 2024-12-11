using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilbioteka
{
    internal class Raport
    {
        private string sciezkaPliku;
        private string _query;
        private string _connectionString;

        public Raport(string sciezka, string query, string connectionString)
        {
            this.sciezkaPliku = sciezka;
            _query = query;
            _connectionString = connectionString;
        }

        public void SetSciezkaPliku(string nowaSciezka)
        {
            sciezkaPliku = nowaSciezka;
        }

        public List<string> GenerujRaport()
        {
            try
            {
                List<string> raportDane = PobierzDaneZBazy();
                if (raportDane == null || raportDane.Count == 0)
                {
                    throw new InvalidOperationException("Raport nie zawiera danych.");
                }
                // Zapisz dane do pliku tekstowego (jeśli konieczne)
                // File.WriteAllText(sciezkaPliku, string.Join("\n", raportDane));

                return raportDane; // Zwróć dane raportu
            }
            catch (UnauthorizedAccessException)
            {
                throw new InvalidOperationException("Brak uprawnień do zapisu pliku w lokalizacji " + sciezkaPliku);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Wystąpił błąd: {ex.Message}");
            }
        }

        private List<string> PobierzDaneZBazy()
        {
            List<string> raportList = new List<string>();
            raportList.Add("RAPORT BIBLIOTEKI: \n\nSTATYSTYKI \nDotychczasową najczęściej wypożyczaną pozycją jest ") ;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                SELECT TOP 1
                    z.Tytul, 
                    z.Typ,
                    z.Autor,
                    COUNT(h.Id) AS LiczbaWypozyczen
                FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                GROUP BY z.Tytul, z.Typ, z.Autor
                ORDER BY LiczbaWypozyczen DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string typ = reader["Typ"].ToString();
                            string tytul = reader["Tytul"].ToString();
                            string autor = reader["Autor"].ToString();
                            int liczbaWypozyczen = Convert.ToInt32(reader["LiczbaWypozyczen"]);

                            // Dodajemy dane do raportu
                            raportList.Add($"{typ} o tytule {tytul} autorstwa {autor}.");
                            raportList.Add($"Liczba wypożyczeń tej pozycji wynosi: {liczbaWypozyczen}.\n");

                        }
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
               SELECT  TOP 1
                            z.Tytul, z.Autor, z.Typ,
                            COUNT(h.Id) AS 'Wypozyczenia'
                        FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                        JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                        WHERE MONTH(h.DataWypozyczenia) = MONTH(GETDATE())
                        GROUP BY z.Tytul, z.Autor, z.Typ
                        ORDER BY Wypozyczenia DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string typ2 = reader["Typ"].ToString();
                            string tytul2 = reader["Tytul"].ToString();
                            string autor2 = reader["Autor"].ToString();
                            int liczbaWypozyczen2 = Convert.ToInt32(reader["Wypozyczenia"]);


                            // Dodajemy dane do raportu
                            raportList.Add("Najczęściej wypożyczaną pozycją w tym miesiącu jest ");
                            raportList.Add($" {typ2}");
                            raportList.Add($" o tytule {tytul2}");
                            raportList.Add($" autorstwa {autor2}.\n");

                            raportList.Add($"Liczba wypożyczeń tej pozycji wynosi: {liczbaWypozyczen2}.\n\n");

                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                          WITH WypozyczeniaNaMiesiac AS (
                            SELECT
                            YEAR(DataWypozyczenia) AS Rok,
                            MONTH(DataWypozyczenia) AS Miesiac,
                            COUNT(Id) AS LiczbaWypozyczen
                            FROM HistoriaWypozyczen
                            GROUP BY YEAR(DataWypozyczenia), MONTH(DataWypozyczenia)
                            )
                            SELECT 
                            AVG(LiczbaWypozyczen) AS SredniaWypozyczenWMiesiacu
                            FROM WypozyczeniaNaMiesiac;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            double sredniaOcena = reader["SredniaWypozyczenWMiesiacu"] != DBNull.Value
                            ? Convert.ToDouble(reader["SredniaWypozyczenWMiesiacu"])
                            : 0.0;


                            // Dodajemy dane do raportu
                            raportList.Add("Średnia liczba wypożyczeń w miesiącu wynosi: ");
                            raportList.Add($"{sredniaOcena:F2}. \n\n");
                            raportList.Add("DANE DOTYCZĄCE ILOSCI ZASOBÓW\n");

                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
               SELECT  
                         COUNT(z.Typ) AS 'IloscKsiazek'
                        FROM [biblioteka].[dbo].[zasoby] z
                        WHERE Typ LIKE 'Książka'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int liczbaKsiazek = Convert.ToInt32(reader["IloscKsiazek"]);

                            raportList.Add($"Liczba książek w bibliotece wynosi: {liczbaKsiazek}.\n");

                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
               SELECT  
                         COUNT(z.Typ) AS 'IloscFilmow'
                        FROM [biblioteka].[dbo].[zasoby] z
                        WHERE Typ LIKE 'Film'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int liczbaFilmow = Convert.ToInt32(reader["IloscFilmow"]);

                            raportList.Add($"Liczba filmów na płycie CD w bibliotece wynosi: {liczbaFilmow}.\n");

                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
               SELECT  
                         COUNT(z.Typ) AS 'IloscAlbumow'
                        FROM [biblioteka].[dbo].[zasoby] z
                        WHERE Typ LIKE 'Album'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int liczbaAlbumow = Convert.ToInt32(reader["IloscAlbumow"]);

                            raportList.Add($"Liczba albumów fotograficznych w bibliotece wynosi: {liczbaAlbumow}.\n\n");
                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
               SELECT  
                         COUNT(Id) AS 'IloscZasobow'
                        FROM [biblioteka].[dbo].[zasoby] z";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int liczbaZasobow = Convert.ToInt32(reader["IloscZasobow"]);

                            raportList.Add($"Liczba wszystkich zasobów biblioteki wynosi: {liczbaZasobow}.\n\n");

                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
               SELECT TOP 1 
                         z.Ilosc AS 'MAX', 
                         z.Tytul, z.Autor, z.Typ
                        FROM [biblioteka].[dbo].[zasoby] z
                        WHERE Ilosc = (SELECT MAX(Ilosc) FROM zasoby)
                        GROUP BY z.Tytul, z.Autor, z.Typ, z.Ilosc
                        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int max = Convert.ToInt32(reader["MAX"]);


                            string typ3 = reader["Typ"].ToString();
                            string tytul3 = reader["Tytul"].ToString();
                            string autor3 = reader["Autor"].ToString();

                            raportList.Add($"Zasobem, które w bibliotece jest najwięcej, czyli {max} jest to {typ3} o tytule {tytul3} autorstwa {autor3}.\n");


                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
               SELECT TOP 1 
                         z.Ilosc AS 'MIN', 
                         z.Tytul, z.Autor, z.Typ
                        FROM [biblioteka].[dbo].[zasoby] z
                        WHERE Ilosc = (SELECT MIN(Ilosc) FROM zasoby)
                        GROUP BY z.Tytul, z.Autor, z.Typ, z.Ilosc
                        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int min = Convert.ToInt32(reader["MIN"]);

                            string typ4 = reader["Typ"].ToString();
                            string tytul4 = reader["Tytul"].ToString();
                            string autor4 = reader["Autor"].ToString();

                            raportList.Add($"Zasobem, które w bibliotece jest najmniej, czyli {min} jest to {typ4} o tytule {tytul4} autorstwa {autor4}.\n\n");

                        }
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
               SELECT  TOP 1
              z.Wydawnictwo, 
              COUNT(z.Id) AS 'Wypozyczenia'
          FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
          JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
          GROUP BY z.Wydawnictwo
          ORDER BY Wypozyczenia DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string wydawnictwo = reader["Wydawnictwo"].ToString();

                            int liczbaWypozyczen3 = Convert.ToInt32(reader["Wypozyczenia"]);


                            // Dodajemy dane do raportu
                            raportList.Add("Wydawnictwer, z którego pozycje są najczęściej wypożyczane jest ");
                            raportList.Add($" {wydawnictwo}. \n");
                            raportList.Add($" Ilośc wypożyczonych z niego pozycji wynosi {liczbaWypozyczen3}. \n");

                        }
                    }
                }
            }
            return raportList;
        }
    }
    
}
