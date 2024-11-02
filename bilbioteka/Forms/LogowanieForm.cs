using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                    command.Parameters.AddWithValue("@Login", login);

                    try
                    {
                        connection.Open();
                        userName = (string)command.ExecuteScalar();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Błąd SQL: " + e.Message);
                    }
                }
            }

            return userName;
        }

        private void buttonZaloguj_Click_1(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string haslo = textBoxHaslo.Text;

            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = "SELECT IdOsoby FROM uzytkownicy WHERE Login = @Login AND Haslo = @Haslo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Haslo", haslo);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int idOsoby = reader.GetInt32(0);
                        string imie = GetUserNameByLogin(login);

                        Form mainForm;
                        switch (idOsoby)
                        {
                            case 1:
                                mainForm = new MainUzytkownikForm(idOsoby, imie, login);
                                break;

                            case 2:
                                mainForm = new MainPracownikForm(imie);
                                break;

                            case 3:
                                mainForm = new MainAdminstratorForm(imie);
                                break;

                            default:
                                MessageBox.Show("Nieznana rola użytkownika!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        mainForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Błędny login lub hasło!", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia: " + ex.Message);
                }
            }
        }
    }
}
