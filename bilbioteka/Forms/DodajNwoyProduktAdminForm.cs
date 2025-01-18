using Microsoft.VisualBasic.Logging;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class DodajNwoyProduktAdminForm : Form
    {
        public DodajNwoyProduktAdminForm()
        {
            InitializeComponent();
        }
        private void buttonZalogujRej_Click(object sender, EventArgs e) { this.Close(); }


        private void buttonDodajProdukt_Click_1(object sender, EventArgs e)
        {
            // Pobieranie danych z pól formularza
            string tytul = textBoxTytul.Text;
            string autor = textBoxAutor.Text;
            int rokWydania;
            decimal ocena;
            int ilosc;
            string kategoria = comboBox2.SelectedItem?.ToString();
            string typ = textBoxTyp.Text;
            string numerKatalogowy = textBoxNrKatagolowy.Text;
            string wydawnictwo = textBoxWydawnictwo.Text;

            // Walidacja pól wymaganych
            if (string.IsNullOrWhiteSpace(tytul) || string.IsNullOrWhiteSpace(autor) ||
                string.IsNullOrWhiteSpace(numerKatalogowy) || string.IsNullOrWhiteSpace(typ) ||
                string.IsNullOrWhiteSpace(wydawnictwo) || string.IsNullOrWhiteSpace(kategoria))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }

            if (!int.TryParse(textBoxRokWydania.Text, out rokWydania) || rokWydania < 1500 || rokWydania > DateTime.Now.Year)
            {
                MessageBox.Show($"Rok wydania musi być liczbą w przedziale 1500 - {DateTime.Now.Year}.");
                return;
            }

            if (!decimal.TryParse(textBoxOcena.Text, out ocena) || ocena < 1.00m || ocena > 10.00m)
            {
                MessageBox.Show("Ocena musi być liczbą dziesiętną w przedziale 1.00 - 10.00.");
                return;
            }

            if (!int.TryParse(textBoxIlosc.Text, out ilosc) || ilosc <= 0)
            {
                MessageBox.Show("Ilość musi być liczbą całkowitą większą od 0.");
                return;
            }

            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Sprawdzanie unikalności numeru katalogowego
                    string queryCheckCatalogNumber = "SELECT COUNT(*) FROM zasoby WHERE NumerKatalogowy = @NumerKatalogowy";
                    using (SqlCommand commandCheckCatalogNumber = new SqlCommand(queryCheckCatalogNumber, connection))
                    {
                        commandCheckCatalogNumber.Parameters.AddWithValue("@NumerKatalogowy", numerKatalogowy);
                        int count = (int)commandCheckCatalogNumber.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Podany numer katalogowy już istnieje w bazie danych.");
                            return;
                        }
                    }

                    // Sprawdzanie istnienia produktu w tabeli Cennik
                    string query = "SELECT Produkt FROM Cennik WHERE Produkt = @produkt";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@produkt", typ);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Nie istnieje taki typ produktu w bazie.");
                                return;
                            }
                        }
                    }

                    // Sprawdzanie istnienia zasobu z taką oceną
                    string queryCheck = @"SELECT Ocena FROM zasoby WHERE Tytul = @Tytul AND Typ = @Typ";
                    using (SqlCommand commandCheck = new SqlCommand(queryCheck, connection))
                    {
                        commandCheck.Parameters.AddWithValue("@Tytul", tytul);
                        commandCheck.Parameters.AddWithValue("@Typ", typ);

                        object existingOcenaObj = commandCheck.ExecuteScalar();
                        if (existingOcenaObj != null)
                        {
                            decimal existingOcena = Convert.ToDecimal(existingOcenaObj);
                            if (existingOcena != ocena)
                            {
                                MessageBox.Show($"Pozycja o tytule '{tytul}' i typie '{typ}' już istnieje, ale z inną oceną ({existingOcena}).");
                                return;
                            }
                        }
                    }

                    // Wstawianie nowego rekordu
                    string queryInsert = @"INSERT INTO zasoby (Tytul, Autor, RokWydania, NumerKatalogowy, Typ, Ocena, Ilosc, Kategoria, Wydawnictwo) 
                           VALUES (@Tytul, @Autor, @RokWydania, @NumerKatalogowy, @Typ, @Ocena, @Ilosc, @Kategoria, @Wydawnictwo)";
                    using (SqlCommand commandInsert = new SqlCommand(queryInsert, connection))
                    {
                        commandInsert.Parameters.AddWithValue("@Tytul", tytul);
                        commandInsert.Parameters.AddWithValue("@Autor", autor);
                        commandInsert.Parameters.AddWithValue("@RokWydania", rokWydania);
                        commandInsert.Parameters.AddWithValue("@NumerKatalogowy", numerKatalogowy);
                        commandInsert.Parameters.AddWithValue("@Typ", typ);
                        commandInsert.Parameters.AddWithValue("@Ocena", ocena);
                        commandInsert.Parameters.AddWithValue("@Ilosc", ilosc);
                        commandInsert.Parameters.AddWithValue("@Kategoria", kategoria);
                        commandInsert.Parameters.AddWithValue("@Wydawnictwo", wydawnictwo);

                        int result = commandInsert.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Produkt został pomyślnie dodany.");
                        }
                        else
                        {
                            MessageBox.Show("Dodawanie produktu nie powiodło się.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }
    }

}

