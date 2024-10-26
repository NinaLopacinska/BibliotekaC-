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
        
        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            // Pobieranie danych z pól formularza
            string tytul = textBoxTytul.Text;
            string autor = textBoxAutor.Text;
            int rokWydania;
            decimal ocena;
            int ilosc;
            string kategoria = comboBox2.SelectedItem?.ToString();
            string typ = comboBox1.SelectedItem?.ToString();
            string numerKatalogowy = textBoxNrKatagolowy.Text;

            // Walidacja pól wymaganych
            if (string.IsNullOrWhiteSpace(tytul) || string.IsNullOrWhiteSpace(autor) ||
                !int.TryParse(textBoxRokWydania.Text, out rokWydania) ||
                !decimal.TryParse(textBoxOcena.Text, out ocena) || ocena < 1.00m || ocena > 10.00m ||
                !int.TryParse(textBoxIlosc.Text, out ilosc) || ilosc <= 0 ||
                string.IsNullOrWhiteSpace(kategoria) || string.IsNullOrWhiteSpace(typ) ||
                string.IsNullOrWhiteSpace(numerKatalogowy))
            {
                MessageBox.Show("Wprowadź poprawne dane we wszystkich wymaganych polach.");
                return;
            }
            if (rokWydania < 1500 || rokWydania >= 2025)
            {
                MessageBox.Show("Podaj poprawny rok wydania.");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
                {
                    connection.Open();

                    // Sprawdzanie unikalności NumeruKatalogowego i kombinacji Tytuł, Autor, Typ
                    string queryDuplicate = @"SELECT COUNT(*) FROM zasoby 
                                              WHERE NumerKatalogowy = @NumerKatalogowy 
                                              OR (Tytul = @Tytul AND Autor = @Autor AND Typ = @Typ)";
                    using (SqlCommand commandDuplicate = new SqlCommand(queryDuplicate, connection))
                    {
                        commandDuplicate.Parameters.AddWithValue("@NumerKatalogowy", numerKatalogowy);
                        commandDuplicate.Parameters.AddWithValue("@Tytul", tytul);
                        commandDuplicate.Parameters.AddWithValue("@Autor", autor);
                        commandDuplicate.Parameters.AddWithValue("@Typ", typ);

                        int duplicateCount = (int)commandDuplicate.ExecuteScalar();
                        if (duplicateCount > 0)
                        {
                            MessageBox.Show("Produkt o tym numerze katalogowym lub tej samej kombinacji (tytuł, autor, typ) już istnieje.");
                            return;
                        }
                    }
                    // Generowanie nowego ID
                    string queryId = "SELECT ISNULL(MAX(Id), 0) + 1 FROM zasoby"; // Zmienna ID
                    int newId;
                    using (SqlCommand commandId = new SqlCommand(queryId, connection))
                    {
                        newId = (int)commandId.ExecuteScalar();
                    }

                    // Wstawianie nowego rekordu
                    string queryInsert = @"INSERT INTO zasoby (Tytul, Autor, RokWydania, NumerKatalogowy, Typ, CzyWypozyczone, Ocena, Ilosc, Kategoria) 
                                           VALUES (@Tytul, @Autor, @RokWydania, @NumerKatalogowy, @Typ, 0, @Ocena, @Ilosc, @Kategoria)";
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

            this.Close();
        }
    }
}
