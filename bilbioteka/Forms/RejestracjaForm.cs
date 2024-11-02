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
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
            panel1.Visible = true ;
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

            // Sprawdzenie wieku i danych opiekuna
            string imieOpiekuna = null;
            string nazwiskoOpiekuna = null;
            string nrTelefonuOpiekuna = null;
            string emailOpiekuna = null;

            if (DateTime.Now < dataUrodzenia.AddYears(13))
            {
                imieOpiekuna = textBoxImieOpiekuna.Text.Trim();
                nazwiskoOpiekuna = textBoxNazwiskoOpiekuna.Text.Trim();
                nrTelefonuOpiekuna = textBoxNrTelefonuOpiekuna.Text.Trim();
                emailOpiekuna = textBoxEmailOpiekuna.Text.Trim();

                // Walidacja danych opiekuna
                if (string.IsNullOrEmpty(imieOpiekuna) || string.IsNullOrEmpty(nazwiskoOpiekuna) ||
                    string.IsNullOrEmpty(nrTelefonuOpiekuna) || string.IsNullOrEmpty(emailOpiekuna))
                {
                    MessageBox.Show("Wszystkie pola danych opiekuna muszą być wypełnione, jeśli użytkownik jest poniżej 13 lat.", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(nrTelefonuOpiekuna, @"^\d{9}$"))
                {
                    MessageBox.Show("Numer telefonu opiekuna musi składać się z 9 cyfr.", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!emailOpiekuna.Contains("@") || !emailOpiekuna.Contains("."))
                {
                    MessageBox.Show("Email opiekuna musi zawierać '@' i '.'", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Walidacja
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) || string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(haslo) || string.IsNullOrWhiteSpace(kodPocztowy) || string.IsNullOrWhiteSpace(ulica) ||
                string.IsNullOrWhiteSpace(nrPosesji) || string.IsNullOrWhiteSpace(pesel) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(numerTelefonu))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione (poza numerem lokalu).", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (login.Length < 5 || login.Length > 30)
            {
                MessageBox.Show("Login musi mieć od 5 do 30 znaków.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(haslo, @"^(?=.*[0-9]).{5,}$"))
            {
                MessageBox.Show("Hasło musi mieć przynajmniej 5 znaków i zawierać co najmniej jedną cyfrę.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(kodPocztowy, @"^9[0-4]-[0-9]{3}$"))
            {
                MessageBox.Show("Kod pocztowy musi być w formacie 90-001 do 94-413.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email musi zawierać znak '@' oraz '.'", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(numerTelefonu, @"^\d{9}$"))
            {
                MessageBox.Show("Numer telefonu musi składać się z 9 cyfr.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(pesel, @"^\d{11}$"))
            {
                MessageBox.Show("PESEL musi składać się z 11 cyfr.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie unikalności loginu i emaila
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkLoginEmailQuery = "SELECT COUNT(1) FROM uzytkownicy WHERE Login = @Login OR Email = @Email";
                using (SqlCommand command = new SqlCommand(checkLoginEmailQuery, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Email", email);
                    int exists = (int)command.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Login lub email już istnieje!", "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Pobranie ostatniego ID
                int newId = 1;
                string getMaxIdQuery = "SELECT ISNULL(MAX(Id), 0) + 1 FROM uzytkownicy";
                using (SqlCommand command = new SqlCommand(getMaxIdQuery, connection))
                {
                    newId = (int)command.ExecuteScalar();
                }

                // Dodanie nowego użytkownika
                string insertQuery = @"
                SET IDENTITY_INSERT uzytkownicy ON;
                INSERT INTO uzytkownicy 
                (Id, Imie, Nazwisko, NumerTelefonu, Login, Haslo, KodPocztowy, Ulica, NrPosesji, NrLokalu, Pesel, DataUrodzenia, Email, 
                ImieOpiekuna, NazwiskoOpiekuna, NumerTelefonuOpiekuna, EmailOpiekuna, IdOsoby) 
                VALUES 
                (@Id, @Imie, @Nazwisko, @NumerTelefonu, @Login, @Haslo, @KodPocztowy, @Ulica, @NrPosesji, @NrLokalu, @Pesel, @DataUrodzenia, 
                @Email, @ImieOpiekuna, @NazwiskoOpiekuna, @NumerTelefonuOpiekuna, @EmailOpiekuna, 1);
                SET IDENTITY_INSERT uzytkownicy OFF;";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", newId);
                    command.Parameters.AddWithValue("@Imie", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@NumerTelefonu", numerTelefonu);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Haslo", haslo);
                    command.Parameters.AddWithValue("@KodPocztowy", kodPocztowy);
                    command.Parameters.AddWithValue("@Ulica", ulica);
                    command.Parameters.AddWithValue("@NrPosesji", nrPosesji);
                    command.Parameters.AddWithValue("@NrLokalu", string.IsNullOrEmpty(nrLokalu) ? (object)DBNull.Value : nrLokalu);
                    command.Parameters.AddWithValue("@Pesel", pesel);
                    command.Parameters.AddWithValue("@DataUrodzenia", dataUrodzenia);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@ImieOpiekuna",  imieOpiekuna ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NazwiskoOpiekuna", nazwiskoOpiekuna ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NumerTelefonuOpiekuna", nrTelefonuOpiekuna ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@EmailOpiekuna", emailOpiekuna ?? (object)DBNull.Value);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Rejestracja zakończona pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainUzytkownikForm mainUzytkownikForm = new MainUzytkownikForm(newId, imie);
                    mainUzytkownikForm.Show();
                    this.Close();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataUrodzenia = dateTimePicker1.Value;
            // Jeśli użytkownik ma mniej niż 13 lat, pokaż panel1 z polami opiekuna
            if (DateTime.Now < dataUrodzenia.AddYears(13))
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }
    }
}
