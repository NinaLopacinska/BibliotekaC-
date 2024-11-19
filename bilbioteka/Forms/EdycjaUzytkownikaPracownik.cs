using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class EdycjaUzytkownikaPracownik : Form
    {
        private string zalogowanyLogin;

        public EdycjaUzytkownikaPracownik(string zalogowanyLogin)
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
                    textBoxImie1.Text = reader["Imie"].ToString();
                    textBoxNazwisko.Text = reader["Nazwisko"].ToString();
                    textBoxKodPocztowy.Text = reader["KodPocztowy"].ToString();
                    textBoxUlica.Text = reader["Ulica"].ToString();
                    textBoxNrPosesji.Text = reader["NrPosesji"].ToString();
                    textBoxNrLokalu.Text = reader["NrLokalu"].ToString();
                    textBoxPesel.Text = reader["Pesel"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["DataUrodzenia"]);
                    textBoxEmail.Text = reader["Email"].ToString();
                    textBoxNrTelefonu.Text = reader["NumerTelefonu"].ToString();


                }
                conn.Close();
            }
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            Close();
        }



        private bool WalidacjaDanych()
        {
            if (string.IsNullOrWhiteSpace(textBoxImie1.Text) || string.IsNullOrWhiteSpace(textBoxNazwisko.Text) ||
                string.IsNullOrWhiteSpace(textBoxKodPocztowy.Text) || string.IsNullOrWhiteSpace(textBoxUlica.Text) ||
                string.IsNullOrWhiteSpace(textBoxNrPosesji.Text) || string.IsNullOrWhiteSpace(textBoxPesel.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxNrTelefonu.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione (poza numerem lokalu).", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(textBoxKodPocztowy.Text, @"^\d{2}-\d{3}$"))
            {
                MessageBox.Show("Kod pocztowy musi być w formacie 00-000.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(textBoxNrTelefonu.Text, @"^\d{9}$"))
            {
                MessageBox.Show("Numer telefonu musi składać się z 9 cyfr.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(textBoxPesel.Text, @"^\d{11}$"))
            {
                MessageBox.Show("PESEL musi składać się z 11 cyfr.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!textBoxEmail.Text.Contains("@") || !textBoxEmail.Text.Contains("."))
            {
                MessageBox.Show("Email musi zawierać '@' oraz '.'", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool SprawdzIZmienHaslo(List<string> zmienioneKolumny, Dictionary<string, object> parametry)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNoweHaslo.Text))
            {
                if (string.IsNullOrWhiteSpace(textBoxStareHaslo.Text))
                {
                    MessageBox.Show("Podaj swoje stare hasło, aby zmienić hasło.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                using (SqlConnection conn = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
                {
                    string query = "SELECT Haslo FROM uzytkownicy WHERE Login = @Login";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Login", zalogowanyLogin);
                        conn.Open();

                        string aktualneHaslo = cmd.ExecuteScalar()?.ToString();

                        if (aktualneHaslo == null || aktualneHaslo != textBoxStareHaslo.Text)
                        {
                            MessageBox.Show("Podane stare hasło jest nieprawidłowe.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

                if (textBoxNoweHaslo.Text.Length < 5 || !Regex.IsMatch(textBoxNoweHaslo.Text, @"^(?=.*[0-9]).+$"))
                {
                    MessageBox.Show("Nowe hasło musi mieć przynajmniej 5 znaków i zawierać co najmniej jedną cyfrę.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                zmienioneKolumny.Add("Haslo = @NoweHaslo");
                parametry.Add("@NoweHaslo", textBoxNoweHaslo.Text.Trim());
            }
            return true;
        }

        private void DodajZmianyDanych(List<string> zmienioneKolumny, Dictionary<string, object> parametry)
        {
            void DodajKolumne(string nazwaKolumny, string nazwaParametru, object wartosc)
            {
                if (wartosc != null && !(wartosc is string str && string.IsNullOrWhiteSpace(str)))
                {
                    zmienioneKolumny.Add($"{nazwaKolumny} = @{nazwaParametru}");
                    parametry.Add($"@{nazwaParametru}", wartosc);
                }
            }

            DodajKolumne("Imie", "Imie", textBoxImie1.Text.Trim());
            DodajKolumne("Nazwisko", "Nazwisko", textBoxNazwisko.Text.Trim());
            DodajKolumne("KodPocztowy", "KodPocztowy", textBoxKodPocztowy.Text.Trim());
            DodajKolumne("Ulica", "Ulica", textBoxUlica.Text.Trim());
            DodajKolumne("NrPosesji", "NrPosesji", textBoxNrPosesji.Text.Trim());
            DodajKolumne("NrLokalu", "NrLokalu", textBoxNrLokalu.Text.Trim());
            DodajKolumne("Pesel", "Pesel", textBoxPesel.Text.Trim());
            DodajKolumne("DataUrodzenia", "DataUrodzenia", dateTimePicker1.Value);
            DodajKolumne("Email", "Email", textBoxEmail.Text.Trim());
            DodajKolumne("NumerTelefonu", "NumerTelefonu", textBoxNrTelefonu.Text.Trim());
        }

        private void AktualizujDaneWBazie(List<string> zmienioneKolumny, Dictionary<string, object> parametry)
        {
            using (SqlConnection conn = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
            {
                string query = $"UPDATE uzytkownicy SET {string.Join(", ", zmienioneKolumny)} WHERE Login = @Login";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    foreach (var param in parametry)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    cmd.Parameters.AddWithValue("@Login", zalogowanyLogin);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void buttonZapisz_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!WalidacjaDanych())
                    return;

                List<string> zmienioneKolumny = new List<string>();
                Dictionary<string, object> parametry = new Dictionary<string, object>();

                if (SprawdzIZmienHaslo(zmienioneKolumny, parametry))
                {
                    DodajZmianyDanych(zmienioneKolumny, parametry);

                    if (zmienioneKolumny.Count > 0)
                    {
                        AktualizujDaneWBazie(zmienioneKolumny, parametry);
                        MessageBox.Show("Dane zostały zaktualizowane pomyślnie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nie wprowadzono żadnych zmian.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas zapisu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonZalogujRej_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Zamknięcie formularza
        }
    }
}
