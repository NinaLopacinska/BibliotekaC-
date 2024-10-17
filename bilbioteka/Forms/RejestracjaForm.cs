using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class RejestracjaForm : Form
    {
        public RejestracjaForm()
        {
            InitializeComponent();
            textBoxHaslo.PasswordChar = '*';
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            LogowanieForm logowanieForm = new LogowanieForm();
            logowanieForm.ShowDialog();
            this.Close();
        }
        

        private void buttonRejstracja_Click(object sender, EventArgs e)
        {
            // Pobierz dane z pól tekstowych
            string imie = textBoxImie.Text.Trim();
            string nazwisko = textBoxNazwisko.Text.Trim();
            string login = textBoxLogin.Text.Trim();
            string haslo = textBoxHaslo.Text.Trim();
            string kodPocztowy = textBoxKodPocztowy.Text.Trim();
            string ulica = textBoxUlica.Text.Trim();
            string nrPosesji = textBoxNrPosesji.Text.Trim();
            string nrLokalu = textBoxNrLokalu.Text.Trim();
            string pesel = textBoxPesel.Text.Trim();
            DateTime dataUrodzenia = dateTimePicker1.Value;
            string email = textBoxEmail.Text.Trim();
            string numerTelefonu = textBoxNrTelefonu.Text.Trim();

            // Walidacja danych
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(haslo) ||
                string.IsNullOrWhiteSpace(kodPocztowy) || string.IsNullOrWhiteSpace(ulica) ||
                string.IsNullOrWhiteSpace(nrPosesji) || string.IsNullOrWhiteSpace(pesel) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(numerTelefonu))
            {
                MessageBox.Show("Wszystkie pola są wymagane!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (login.Length < 5 || login.Length > 30)
            {
                MessageBox.Show("Login musi mieć od 5 do 30 znaków!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (haslo.Length < 5 || !Regex.IsMatch(haslo, @"\d"))
            {
                MessageBox.Show("Hasło musi mieć minimum 5 znaków i przynajmniej jedną cyfrę!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(kodPocztowy, @"^\d{2}-\d{3}$") || kodPocztowy.CompareTo("90-001") < 0 || kodPocztowy.CompareTo("94-413") > 0)
            {
                MessageBox.Show("Kod pocztowy musi być z terenu Łodzi czyli od 90-001 do 94-413!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pesel.Length != 11 || !long.TryParse(pesel, out _))
            {
                MessageBox.Show("Pesel musi mieć 11 cyfr!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email musi zawierać znak '@' oraz '.'!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numerTelefonu.Length != 9 || !long.TryParse(numerTelefonu, out _))
            {
                MessageBox.Show("Numer telefonu musi mieć 9 cyfr!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie wieku
            string imieOpiekuna = null;
            string nazwiskoOpiekuna = null;
            string nrTelefonuOpiekuna = null;
            string emailOpiekuna = null;

            if (DateTime.Now.Year - dataUrodzenia.Year < 13)
            {
                imieOpiekuna = textBoxImieOpiekuna.Text.Trim();
                nazwiskoOpiekuna = textBoxNazwiskoOpiekuna.Text.Trim();
                nrTelefonuOpiekuna = textBoxNrTelefonuOpiekuna.Text.Trim();
                emailOpiekuna = textBoxEmailOpiekuna.Text.Trim();

                // Walidacja danych opiekuna
                if (string.IsNullOrWhiteSpace(imieOpiekuna) || string.IsNullOrWhiteSpace(nazwiskoOpiekuna) ||
                    string.IsNullOrWhiteSpace(nrTelefonuOpiekuna) || string.IsNullOrWhiteSpace(emailOpiekuna))
                {
                    MessageBox.Show("Wszystkie pola opiekuna są wymagane!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nrTelefonuOpiekuna.Length != 9 || !long.TryParse(nrTelefonuOpiekuna, out _))
                {
                    MessageBox.Show("Numer telefonu opiekuna musi mieć 9 cyfr!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (emailOpiekuna.Length < 5 || !emailOpiekuna.Contains("@") || !emailOpiekuna.Contains("."))
                {
                    MessageBox.Show("Email opiekuna musi zawierać znak '@' oraz '.'!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Sprawdzenie unikalności loginu
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkLoginQuery = "SELECT COUNT(1) FROM uzytkownicy WHERE Login = @Login";
                using (SqlCommand command = new SqlCommand(checkLoginQuery, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    int exists = (int)command.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Login już istnieje!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Dodaj nowego użytkownika
                string insertQuery = @"
            INSERT INTO uzytkownicy 
            (Imie, Nazwisko, NumerTelefonu, Login, Haslo, KodPocztowy, Ulica, NrPosesji, NrLokalu, Pesel, DataUrodzenia, Email, 
            ImieOpiekuna, NazwiskoOpiekuna, NumerTelefonuOpiekuna, EmailOpiekuna) 
            VALUES 
            (@Imie, @Nazwisko, @NumerTelefonu, @Login, @Haslo, @KodPocztowy, @Ulica, @NrPosesji, @NrLokalu, @Pesel, @DataUrodzenia, 
            @Email, @ImieOpiekuna, @NazwiskoOpiekuna, @NumerTelefonuOpiekuna, @EmailOpiekuna);";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Imie", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@NumerTelefonu", numerTelefonu);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Haslo", haslo); // Użyj haszowania w produkcji
                    command.Parameters.AddWithValue("@KodPocztowy", kodPocztowy);
                    command.Parameters.AddWithValue("@Ulica", ulica);
                    command.Parameters.AddWithValue("@NrPosesji", nrPosesji);
                    command.Parameters.AddWithValue("@NrLokalu", string.IsNullOrEmpty(nrLokalu) ? (object)DBNull.Value : nrLokalu);
                    command.Parameters.AddWithValue("@Pesel", pesel);
                    command.Parameters.AddWithValue("@DataUrodzenia", dataUrodzenia);
                    command.Parameters.AddWithValue("@Email", email);

                    // Dodaj dane opiekuna, jeśli są wymagane
                    if (DateTime.Now.Year - dataUrodzenia.Year < 13)
                    {
                        command.Parameters.AddWithValue("@ImieOpiekuna", imieOpiekuna);
                        command.Parameters.AddWithValue("@NazwiskoOpiekuna", nazwiskoOpiekuna);
                        command.Parameters.AddWithValue("@NumerTelefonuOpiekuna", nrTelefonuOpiekuna);
                        command.Parameters.AddWithValue("@EmailOpiekuna", emailOpiekuna);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ImieOpiekuna", (object)DBNull.Value);
                        command.Parameters.AddWithValue("@NazwiskoOpiekuna", (object)DBNull.Value);
                        command.Parameters.AddWithValue("@NumerTelefonuOpiekuna", (object)DBNull.Value);
                        command.Parameters.AddWithValue("@EmailOpiekuna", (object)DBNull.Value);
                    }

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Rejestracja zakończona pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            MainUzytkownikForm mainUzytkownikForm = new MainUzytkownikForm();
            mainUzytkownikForm.Show();
            this.Hide();
        }
    }
}
