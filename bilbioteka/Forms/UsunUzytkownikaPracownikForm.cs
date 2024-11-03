using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class UsunUzytkownikaPracownikForm : Form
    {
        public UsunUzytkownikaPracownikForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Pobieranie connection string z klasy PolaczenieBazyDanych
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

            // Zapytanie SQL, które wybiera dane z tabeli 'zasoby'
            string query = "SELECT * FROM uzytkownicy WHERE IdOsoby = 1";

            // Tworzenie obiektu SqlConnection z connection string
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Otwórz połączenie
                    conn.Open();

                    // Utwórz obiekt SqlDataAdapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    // Utwórz DataTable, do której załadujemy dane
                    DataTable dataTable = new DataTable();

                    // Załaduj dane z SQL do DataTable
                    dataAdapter.Fill(dataTable);

                    // Ustaw DataGridView1 jako źródło danych dla DataTable
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Obsługa błędów
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            // Pobierz dane z TextBoxów
            string login = textBoxLogin.Text;
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;

            // Utwórz zapytanie do sprawdzenia, czy użytkownik istnieje
            string query = "SELECT COUNT(*) FROM uzytkownicy WHERE Login = @Login AND Imie = @Imie AND Nazwisko = @Nazwisko";

            // Użyj connection stringa z klasy PolaczenieBazyDanych
            using (SqlConnection connection = new SqlConnection(PolaczenieBazyDanych.StringPolaczeniowy()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Dodaj parametry do zapytania
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Imie", imie);
                        command.Parameters.AddWithValue("@Nazwisko", nazwisko);

                        // Wykonaj zapytanie
                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // Użytkownik istnieje, wyświetl potwierdzenie usunięcia
                            DialogResult result = MessageBox.Show(
                                $"Czy na pewno chcesz usunąć użytkownika: {login}?",
                                "Potwierdzenie usunięcia",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );

                            if (result == DialogResult.Yes)
                            {
                                // Jeśli potwierdzono, usuń użytkownika
                                string deleteQuery = "DELETE FROM uzytkownicy WHERE Login = @Login AND Imie = @Imie AND Nazwisko = @Nazwisko";
                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@Login", login);
                                    deleteCommand.Parameters.AddWithValue("@Imie", imie);
                                    deleteCommand.Parameters.AddWithValue("@Nazwisko", nazwisko);
                                    
                                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Użytkownik został pomyślnie usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie udało się usunąć użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Użytkownik o podanych danych nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
