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
        

        private void buttonZaloguj_Click_1(object sender, EventArgs e)
        {
            // Pobierz dane wprowadzone przez użytkownika
            string login = textBoxLogin.Text;
            string haslo = textBoxHaslo.Text;

            // Zbuduj string połączeniowy
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

            // Zbuduj zapytanie SQL do sprawdzenia loginu i hasła
            string query = "SELECT COUNT(1) FROM uzytkownicy WHERE Login = @Login AND Haslo = @Haslo";

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

                    // Wykonaj zapytanie
                    int count = (int)command.ExecuteScalar();

                    if (count == 1)
                    {
                        // Jeśli dane są poprawne, otwórz nowe okno
                        MessageBox.Show("Zalogowano pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainUzytkownikForm mainForm = new MainUzytkownikForm();
                        mainForm.Show();
                        this.Hide(); // Ukryj aktualny formularz
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
