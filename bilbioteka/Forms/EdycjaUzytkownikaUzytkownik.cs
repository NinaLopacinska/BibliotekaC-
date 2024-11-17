using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class EdycjaUzytkownikaUzytkownik : Form
    {
        private readonly string zalogowanyLogin;

        public EdycjaUzytkownikaUzytkownik(string login) // Konstruktor przyjmuje login
        {
            InitializeComponent();
            textBoxNoweHaslo.PasswordChar = '*';
            textBoxStareHaslo.PasswordChar = '*';
            zalogowanyLogin = login; // Przypisanie loginu zalogowanego użytkownika
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close(); // Zamknięcie formularza
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pobranie aktualnego hasła użytkownika
                    string aktualneHaslo = PobierzAktualneHaslo(connection, zalogowanyLogin);
                    if (aktualneHaslo == null)
                    {
                        MessageBox.Show("Nie znaleziono użytkownika!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Przygotowanie do aktualizacji
                    StringBuilder updateQuery = new StringBuilder("UPDATE uzytkownicy SET ");
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    // Dodanie wypełnionych pól do aktualizacji
                    DodajPoleDoAktualizacji(textBoxImie, "Imie", parameters, updateQuery);
                    DodajPoleDoAktualizacji(textBoxNazwisko, "Nazwisko", parameters, updateQuery);
                    DodajPoleDoAktualizacji(textBoxKodPocztowy, "KodPocztowy", parameters, updateQuery);
                    DodajPoleDoAktualizacji(textBoxUlica, "Ulica", parameters, updateQuery);
                    DodajPoleDoAktualizacji(textBoxNrPosesji, "NrPosesji", parameters, updateQuery);
                    DodajPoleDoAktualizacji(textBoxNrLokalu, "NrLokalu", parameters, updateQuery);
                    DodajPoleDoAktualizacji(textBoxPesel, "Pesel", parameters, updateQuery);
                    DodajPoleDoAktualizacji(textBoxEmail, "Email", parameters, updateQuery);
                    DodajPoleDoAktualizacji(textBoxNrTelefonu, "NumerTelefonu", parameters, updateQuery);

                    // Obsługa zmiany hasła
                    if (!string.IsNullOrWhiteSpace(textBoxStareHaslo.Text) && !string.IsNullOrWhiteSpace(textBoxNoweHaslo.Text))
                    {
                        if (textBoxStareHaslo.Text.Trim() == aktualneHaslo)
                        {
                            updateQuery.Append("Haslo = @Haslo, ");
                            parameters.Add(new SqlParameter("@Haslo", textBoxNoweHaslo.Text.Trim()));
                        }
                        else
                        {
                            MessageBox.Show("Podane stare hasło jest nieprawidłowe.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Finalizacja zapytania
                    if (parameters.Count > 0)
                    {
                        updateQuery.Length -= 2; // Usunięcie ostatniego przecinka i spacji
                        updateQuery.Append(" WHERE Login = @Login");
                        parameters.Add(new SqlParameter("@Login", zalogowanyLogin));

                        using (SqlCommand command = new SqlCommand(updateQuery.ToString(), connection))
                        {
                            command.Parameters.AddRange(parameters.ToArray());
                            command.ExecuteNonQuery();

                            MessageBox.Show("Dane zostały zaktualizowane pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie wprowadzono żadnych zmian.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string PobierzAktualneHaslo(SqlConnection connection, string login)
        {
            string query = "SELECT Haslo FROM uzytkownicy WHERE Login = @Login";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Login", login);
                return command.ExecuteScalar()?.ToString();
            }
        }

        private void DodajPoleDoAktualizacji(TextBox textBox, string kolumna, List<SqlParameter> parameters, StringBuilder query)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                query.Append($"{kolumna} = @{kolumna}, ");
                parameters.Add(new SqlParameter($"@{kolumna}", textBox.Text.Trim()));
            }
        }
    }
}
