using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace bilbioteka.Forms
{
    public partial class LogowanieForm : Form
    {
        public LogowanieForm()
        {
            InitializeComponent();
            textBoxHaslo.PasswordChar = '*';
        }

        private void buttonRejestrujLog_Click(object sender, EventArgs e)
        {
            RejestracjaForm rejestracjaForm = new RejestracjaForm();
            rejestracjaForm.ShowDialog();
            this.Close();
        }

        public string GetUserNameByLogin(string login)
        {
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string userName = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT Imie FROM dbo.uzytkownicy WHERE Login = @Login";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Ustaw parametry zapytania
                    command.Parameters.AddWithValue("@Login", login);

                    try
                    {
                        connection.Open();
                        // Wykonaj zapytanie i odbierz wynik
                        userName = (string)command.ExecuteScalar();
                    }
                    catch (SqlException e)
                    {
                        // W przypadku wystąpienia błędu SQL, obsłuż go tutaj
                        Console.WriteLine("Błąd SQL: " + e.Message);
                    }
                }
            }

            return userName;
        }


        private void buttonZaloguj_Click_1(object sender, EventArgs e)
        {
            // Pobierz dane wprowadzone przez użytkownika
            string login = textBoxLogin.Text;
            string haslo = textBoxHaslo.Text;

            // Zbuduj string połączeniowy
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

            // Zbuduj zapytanie SQL do sprawdzenia loginu, hasła oraz pobrania IdOsoby
            string query = "SELECT IdOsoby FROM uzytkownicy WHERE Login = @Login AND Haslo = @Haslo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Otwórz połączenie
                    connection.Open();

                    // Przygotuj zapytanie
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Haslo", haslo);

                    // Wykonaj zapytanie i pobierz IdOsoby
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int idOsoby = reader.GetInt32(0);  // Pobierz IdOsoby

                        // Pobierz imię użytkownika
                        string imie = GetUserNameByLogin(login);

                        // Jeśli dane są poprawne, otwórz odpowiedni formularz w zależności od IdOsoby
                        switch (idOsoby)
                        {
                            case 1:
                                MainUzytkownikForm mainUzytkownikForm = new MainUzytkownikForm(imie); 
                                mainUzytkownikForm.Show();
                                break;

                            case 2:
                                MainPracownikForm mainPracownikForm = new MainPracownikForm(imie); 
                                mainPracownikForm.Show();
                                break;

                            case 3:
                                MainAdminstratorForm mainAdministratorForm = new MainAdminstratorForm(imie); 
                                mainAdministratorForm.Show();
                                break;

                            default:
                                MessageBox.Show("Nieznana rola użytkownika!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        // Ukryj aktualny formularz
                        this.Hide();
                    }
                    else
                    {
                        // Jeśli dane są niepoprawne, wyświetl komunikat
                        MessageBox.Show("Błędny login lub hasło!", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Obsłuż wyjątki
                    MessageBox.Show("Błąd połączenia: " + ex.Message);
                }
            }
        }


    }
}
