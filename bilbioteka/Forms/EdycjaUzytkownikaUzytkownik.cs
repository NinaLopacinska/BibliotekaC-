using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class EdycjaUzytkownikaUzytkownik : Form
    {
        private string zalogowanyLogin;

        public EdycjaUzytkownikaUzytkownik(string zalogowanyLogin)
        {
            InitializeComponent();
            this.zalogowanyLogin = zalogowanyLogin;

            textBoxNoweHaslo.PasswordChar = '*';
            textBoxStareHaslo.PasswordChar = '*';
            label2.Text = zalogowanyLogin;
            PobierzDaneUZBazy();
        }

        private void PobierzDaneUZBazy()
        {
            using (SqlConnection conn = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
            {
                string query = "SELECT * FROM uzytkownicy WHERE Login = @Login";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Login", zalogowanyLogin);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBoxImie.Text = reader["Imie"].ToString();
                    textBoxNazwisko.Text = reader["Nazwisko"].ToString();
                    textBoxKodPocztowy.Text = reader["KodPocztowy"].ToString();
                    textBoxUlica.Text = reader["Ulica"].ToString();
                    textBoxNrPosesji.Text = reader["NrPosesji"].ToString();
                    textBoxNrLokalu.Text = reader["NrLokalu"].ToString();
                    textBoxPesel.Text = reader["Pesel"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["DataUrodzenia"]);
                    textBoxEmail.Text = reader["Email"].ToString();
                    textBoxNrTelefonu.Text = reader["NumerTelefonu"].ToString();

                    int wiek = ObliczWiek(Convert.ToDateTime(reader["DataUrodzenia"]));
                    if (wiek > 13)
                    {
                        panel1.Visible = true; // Wyświetl panel dla danych opiekuna
                    }
                    else
                    {
                        panel1.Visible = false; // Ukryj panel dla danych opiekuna
                    }
                }
                conn.Close();
            }
        }
        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close(); // Zamknięcie formularza
        }

        private int ObliczWiek(DateTime dataUrodzenia)
        {
            int wiek = DateTime.Now.Year - dataUrodzenia.Year;
            if (dataUrodzenia > DateTime.Now.AddYears(-wiek)) wiek--;
            return wiek;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            List<string> zmienioneKolumny = new List<string>();
            Dictionary<string, object> parametry = new Dictionary<string, object>();

            // Sprawdzanie, czy użytkownik zmienia hasło
            if (!string.IsNullOrWhiteSpace(textBoxNoweHaslo.Text))
            {
                if (string.IsNullOrWhiteSpace(textBoxStareHaslo.Text))
                {
                    MessageBox.Show("Podaj swoje stare hasło, aby zmienić hasło.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Weryfikacja starego hasła
                using (SqlConnection conn = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
                {
                    string query = "SELECT Haslo FROM uzytkownicy WHERE Login = @Login";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Login", zalogowanyLogin);

                    conn.Open();
                    object wynik = cmd.ExecuteScalar();
                    conn.Close();

                    if (wynik == null || wynik.ToString() != textBoxStareHaslo.Text)
                    {
                        MessageBox.Show("Podane stare hasło jest nieprawidłowe.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Walidacja nowego hasła
                if (textBoxNoweHaslo.Text.Length < 5 || !Regex.IsMatch(textBoxNoweHaslo.Text, @"^(?=.*[0-9]).+$"))
                {
                    MessageBox.Show("Nowe hasło musi mieć przynajmniej 5 znaków i zawierać co najmniej jedną cyfrę.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Dodanie nowego hasła do listy zmian
                zmienioneKolumny.Add("Haslo = @NoweHaslo");
                parametry.Add("@NoweHaslo", textBoxNoweHaslo.Text.Trim());
            }
            // Walidacja danych użytkownika
            if (string.IsNullOrWhiteSpace(textBoxImie.Text) || string.IsNullOrWhiteSpace(textBoxNazwisko.Text) ||
                string.IsNullOrWhiteSpace(textBoxKodPocztowy.Text) || string.IsNullOrWhiteSpace(textBoxUlica.Text) ||
                string.IsNullOrWhiteSpace(textBoxNrPosesji.Text) || string.IsNullOrWhiteSpace(textBoxPesel.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxNrTelefonu.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione (poza numerem lokalu).", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(textBoxKodPocztowy.Text, @"^\d{2}-\d{3}$"))
            {
                MessageBox.Show("Kod pocztowy musi być w formacie 00-000.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(textBoxNrTelefonu.Text, @"^\d{9}$"))
            {
                MessageBox.Show("Numer telefonu musi składać się z 9 cyfr.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(textBoxPesel.Text, @"^\d{11}$"))
            {
                MessageBox.Show("PESEL musi składać się z 11 cyfr.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!textBoxEmail.Text.Contains("@") || !textBoxEmail.Text.Contains("."))
            {
                MessageBox.Show("Email musi zawierać '@' oraz '.'", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Walidacja danych opiekuna, jeśli wiek < 13
            if (!panel1.Visible)
            {
                if (string.IsNullOrEmpty(textBoxImieOpiekuna.Text) || string.IsNullOrEmpty(textBoxNazwiskoOpiekuna.Text) ||
                    string.IsNullOrEmpty(textBoxNrTelefonuOpiekuna.Text) || string.IsNullOrEmpty(textBoxEmailOpiekuna.Text))
                {
                    MessageBox.Show("Wszystkie pola danych opiekuna muszą być wypełnione, jeśli użytkownik ma mniej niż 13 lat.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(textBoxNrTelefonuOpiekuna.Text, @"^\d{9}$"))
                {
                    MessageBox.Show("Numer telefonu opiekuna musi składać się z 9 cyfr.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!textBoxEmailOpiekuna.Text.Contains("@") || !textBoxEmailOpiekuna.Text.Contains("."))
                {
                    MessageBox.Show("Email opiekuna musi zawierać '@' oraz '.'", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            
            void DodajKolumne(string nazwaKolumny, string nazwaParametru, object wartosc)
            {
                if (wartosc != null && !(wartosc is string str && string.IsNullOrWhiteSpace(str)))
                {
                    zmienioneKolumny.Add($"{nazwaKolumny} = @{nazwaParametru}");
                    parametry.Add($"@{nazwaParametru}", wartosc);
                }
            }

            // Dodawanie tylko wypełnionych pól
            DodajKolumne("Imie", "Imie", textBoxImie.Text.Trim());
            DodajKolumne("Nazwisko", "Nazwisko", textBoxNazwisko.Text.Trim());
            DodajKolumne("KodPocztowy", "KodPocztowy", textBoxKodPocztowy.Text.Trim());
            DodajKolumne("Ulica", "Ulica", textBoxUlica.Text.Trim());
            DodajKolumne("NrPosesji", "NrPosesji", textBoxNrPosesji.Text.Trim());
            DodajKolumne("NrLokalu", "NrLokalu", textBoxNrLokalu.Text.Trim());
            DodajKolumne("Pesel", "Pesel", textBoxPesel.Text.Trim());
            DodajKolumne("DataUrodzenia", "DataUrodzenia", dateTimePicker1.Value);
            DodajKolumne("Email", "Email", textBoxEmail.Text.Trim());
            DodajKolumne("NumerTelefonu", "NumerTelefonu", textBoxNrTelefonu.Text.Trim());

            if (panel1.Visible)
            {
                DodajKolumne("ImieOpiekuna", "ImieOpiekuna", textBoxImieOpiekuna.Text.Trim());
                DodajKolumne("NazwiskoOpiekuna", "NazwiskoOpiekuna", textBoxNazwiskoOpiekuna.Text.Trim());
                DodajKolumne("NumerTelefonuOpiekuna", "NumerTelefonuOpiekuna", textBoxNrTelefonuOpiekuna.Text.Trim());
                DodajKolumne("EmailOpiekuna", "EmailOpiekuna", textBoxEmailOpiekuna.Text.Trim());
            }

            if (zmienioneKolumny.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
                {
                    string query = $"UPDATE uzytkownicy SET {string.Join(", ", zmienioneKolumny)} WHERE Login = @Login";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    foreach (var param in parametry)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    cmd.Parameters.AddWithValue("@Login", zalogowanyLogin);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Dane zostały zaktualizowane pomyślnie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie wprowadzono żadnych zmian.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
