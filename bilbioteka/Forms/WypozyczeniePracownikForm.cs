using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class WypozyczeniePracownikForm : Form
    {
        public WypozyczeniePracownikForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.Load += new EventHandler(Form2_Load);

            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void buttonWypozycz_Click_1(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string tytul = textBoxTytul.Text;
            string typ = textBoxTyp.Text;

            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Proszę wpisać login użytkownika.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tytul))
            {
                MessageBox.Show("Proszę wpisać tytuł zasobu.");
                return;
            }

            if (string.IsNullOrWhiteSpace(typ))
            {
                MessageBox.Show("Proszę wybrać typ zasobu.");
                return;
            }


            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Sprawdź, czy login użytkownika istnieje w bazie i czy ma IdOsoby = 1
                    string loginQuery = "SELECT Id, IdOsoby FROM uzytkownicy WHERE Login = @login";
                    SqlCommand loginCommand = new SqlCommand(loginQuery, connection);
                    loginCommand.Parameters.AddWithValue("@login", login);

                    int uzytkownikId;
                    int idOsoby;

                    using (SqlDataReader reader = loginCommand.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Użytkownik o podanym loginie nie istnieje.");
                            return;
                        }

                        uzytkownikId = reader.GetInt32(0);
                        idOsoby = reader.GetInt32(1);

                        // Jeśli IdOsoby jest różne od 1, wyświetl komunikat o braku uprawnień do wypożyczenia
                        if (idOsoby != 1)
                        {
                            MessageBox.Show("Podana osoba jest Pracownikiem lub Administratorem i nie można jej wypożyczyć produktu.");
                            return;
                        }
                    }

                    // Sprawdź, czy zasób o podanym tytule i typie jest dostępny
                    string zasobQuery = "SELECT Id, Ilosc FROM zasoby WHERE Tytul = @tytul AND Typ = @typ AND Ilosc > 0";
                    SqlCommand zasobCommand = new SqlCommand(zasobQuery, connection);
                    zasobCommand.Parameters.AddWithValue("@tytul", tytul);
                    zasobCommand.Parameters.AddWithValue("@typ", typ);

                    int zasobId;



                    using (SqlDataReader zasobReader = zasobCommand.ExecuteReader())
                    {
                        if (!zasobReader.Read())
                        {
                            MessageBox.Show("Zasób o podanym tytule i typie jest niedostępny.");
                            return;
                        }

                        zasobId = zasobReader.GetInt32(0);
                        // Można usunąć nieużywaną zmienną `ilosc`
                    }
                    // Sprawdź, czy użytkownik ma zaległość (status 'KARA')
                    string karaQuery = "SELECT COUNT(*) FROM HistoriaWypozyczen WHERE LoginUzytkownika = @login AND StatusZwrotu = 'KARA'";
                    SqlCommand karaCommand = new SqlCommand(karaQuery, connection);
                    karaCommand.Parameters.AddWithValue("@login", login);

                    int count = (int)karaCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Użytkownik ma na swoim koncie KARĘ, nie można mu wypożyczać zasobów, do czasu uregulowania należności.");
                        return;
                    }



                    // Zmniejszenie ilości dostępnych zasobów
                    string updateQuery = "UPDATE zasoby SET Ilosc = Ilosc - 1 WHERE Id = @zasobId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@zasobId", zasobId);
                    updateCommand.ExecuteNonQuery();

                    // Dodanie rekordu do tabeli HistoriaWypozyczen
                    DateTime dataWypozyczenia = DateTime.Now;
                    DateTime dataZwrotu = dataWypozyczenia.AddMonths(1);
                    // Pobierz ostatnie dostępne Id i zwiększ o 1


                    // Użyj zmiennej newId podczas dodawania rekordu do historii wypożyczeń
                    string insertQuery = "INSERT INTO HistoriaWypozyczen ( UzytkownikId, ZasobId, DataWypozyczenia, DataZwrotu, LoginUzytkownika, TytulPozycji, TypProduktu) " +
                                         "VALUES ( @uzytkownikId, @zasobId, @dataWypozyczenia, @dataZwrotu, @loginUzytkownika, @tytulPozycji, @typProduktu);";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    //insertCommand.Parameters.AddWithValue("@id", newId);
                    insertCommand.Parameters.AddWithValue("@uzytkownikId", uzytkownikId);
                    insertCommand.Parameters.AddWithValue("@zasobId", zasobId);
                    insertCommand.Parameters.AddWithValue("@dataWypozyczenia", dataWypozyczenia);
                    insertCommand.Parameters.AddWithValue("@dataZwrotu", dataZwrotu);
                    insertCommand.Parameters.AddWithValue("@loginUzytkownika", login);
                    insertCommand.Parameters.AddWithValue("@tytulPozycji", tytul);
                    insertCommand.Parameters.AddWithValue("@typProduktu", typ);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Pomyślnie wypożyczono zasób.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Wystąpił błąd w bazie danych: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }
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
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = "SELECT Imie , Nazwisko, Login, NumerTelefonu AS 'Telefon', Email, DataUrodzenia FROM uzytkownicy WHERE IdOsoby = 1 AND Stan = 'Aktywny'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Wystąpił błąd w bazie danych: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }


        private void SearchData()
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać kryterium wyszukiwania.");
                return;
            }

            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = string.Empty;
            string searchValue = textBox1.Text;
            int rokWydania = 0;
            decimal ocena = 0;
            int ilosc = 0;
            // Ustal zapytanie w zależności od wybranego kryterium
            switch (comboBox2.SelectedItem.ToString())
            {
                case "   ":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE StanZasobu = 'Aktywny' ";
                    break;
                case "Tytuł":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Tytul LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Autor":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Autor LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Rok wydania":
                    query = "SELECT Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE RokWydania LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Numer katalogowy":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE NumerKatalogowy LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Typ produktu":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Typ LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                case "Ocena":
                    // Sprawdzenie, czy searchValue jest liczbą
                    if (!decimal.TryParse(searchValue, out ocena))
                    {
                        MessageBox.Show("Proszę wpisać poprawną ocenę.");
                        return;
                    }
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Ocena = @ocena AND StanZasobu = 'Aktywny'";
                    break;
                case "Ilość":

                    if (!int.TryParse(searchValue, out ilosc))
                    {
                        MessageBox.Show("Proszę wpisać poprawną ilość.");
                        return;
                    }
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Ilosc = @ilosc AND StanZasobu = 'Aktywny'";
                    break;
                case "Kategoria":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Kategoria LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;
                default:
                    MessageBox.Show("Proszę wybrać kryterium wyszukiwania.");
                    return;

                case "Wydawnictwo":
                    query = "SELECT  Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE Wydawnictwo LIKE @searchValue AND StanZasobu = 'Aktywny'";
                    break;

            }

            // Tworzenie połączenia z bazą
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Dodaj parametr w zależności od wybranego kryterium
                    switch (comboBox2.SelectedItem.ToString())
                    {
                        case "Tytuł":
                        case "Autor":
                        case "Numer katalogowy":
                        case "Typ produktu":
                        case "Wydawnictwo":
                        case "Kategoria":
                            cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
                            break;
                        case "Ocena":
                            cmd.Parameters.AddWithValue("@ocena", ocena);
                            break;
                        case "Rok wydania":
                            cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
                            break;
                        
                        case "Ilość":
                            cmd.Parameters.AddWithValue("@ilosc", ilosc);
                            break;
                    }

                    // Wypełnij DataTable i przypisz do DataGridView
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
        private void buttonSzukaj_Click_1(object sender, EventArgs e)
        {
            SearchData();
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // Sprawdź, czy w DataGridView jest zaznaczony jakiś wiersz
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Pobierz zaznaczony wiersz
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Sprawdź, czy kolumna "Tytul" istnieje i przypisz wartość do textBoxTytul
                if (selectedRow.Cells["Tytul"] != null && selectedRow.Cells["Tytul"].Value != null)
                {
                    textBoxTytul.Text = selectedRow.Cells["Tytul"].Value.ToString();
                }
                else
                {
                    textBoxTytul.Text = string.Empty; // Wyczyść pole, jeśli brak wartości
                }

                if (selectedRow.Cells["Typ"] != null && selectedRow.Cells["Typ"].Value != null)
                {
                    textBoxTyp.Text = selectedRow.Cells["Typ"].Value.ToString();
                }
                else
                {
                    textBoxTyp.Text = string.Empty; // Wyczyść pole, jeśli brak wartości
                }
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Upewnij się, że kliknięto wiersz, a nie nagłówek
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                if (selectedRow.Cells["Tytul"] != null && selectedRow.Cells["Tytul"].Value != null)
                {
                    textBoxTytul.Text = selectedRow.Cells["Tytul"].Value.ToString();
                }
                else
                {
                    textBoxTytul.Text = string.Empty;
                }

                if (selectedRow.Cells["Typ"] != null && selectedRow.Cells["Typ"].Value != null)
                {
                    textBoxTyp.Text = selectedRow.Cells["Typ"].Value.ToString();
                }
                else
                {
                    textBoxTyp.Text = string.Empty;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData2();
        }
        private void LoadData2()
        {
            // Pobieranie connection string z klasy PolaczenieBazyDanych
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

            // Zapytanie SQL, które wybiera dane z tabeli 'zasoby'
            string query = "SELECT Tytul, Autor, RokWydania AS 'Rok', NumerKatalogowy AS 'Nr. Kat.', Typ, Ocena, Ilosc, Kategoria, Wydawnictwo FROM zasoby WHERE StanZasobu = 'Aktywny'";

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
                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Obsługa błędów
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }
        private string selectedLogin = string.Empty;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pobierz zaznaczony wiersz
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Pobierz wartości z odpowiednich kolumn
                selectedLogin = selectedRow.Cells["Login"]?.Value?.ToString() ?? string.Empty;

                // Wstaw wartości do odpowiednich pól tekstowych

                textBoxLogin.Text = selectedLogin;
            }
        }

        private void SearchData2()
        {

            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            string query = string.Empty;
            string searchValue = textBoxSzukanaWartosc.Text;

            // Ustal zapytanie w zależności od wybranego kryterium
            switch (comboBox1.SelectedItem?.ToString())
            {
                case null:
                case "":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, Ulica FROM uzytkownicy WHERE IdOsoby = 1 AND Stan = 'Aktywny'";
                    break;
                case "Imie":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, Ulica FROM uzytkownicy WHERE Imie LIKE @searchValue AND IdOsoby = 1 AND Stan = 'Aktywny'";
                    break;
                case "Nazwisko":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, Ulica FROM uzytkownicy WHERE Nazwisko LIKE @searchValue AND IdOsoby = 1 AND Stan = 'Aktywny'";
                    break;
                case "Numer telefonu":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, Ulica FROM uzytkownicy WHERE CAST(NumerTelefonu AS VARCHAR) LIKE @numerTelefonu AND IdOsoby = 1 AND Stan = 'Aktywny'";
                    break;
                case "Login":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, Ulica FROM uzytkownicy WHERE Login LIKE @searchValue AND IdOsoby = 1 AND Stan = 'Aktywny'";
                    break;
                case "Email":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, Ulica FROM uzytkownicy WHERE Email LIKE @searchValue AND IdOsoby = 1 AND Stan = 'Aktywny'";
                    break;
                case "Pesel":
                    query = "SELECT Imie, Nazwisko, NumerTelefonu as 'Telefon', Login, Pesel, Email, Ulica FROM uzytkownicy WHERE Pesel LIKE @pesel AND IdOsoby = 1 AND Stan = 'Aktywny'";
                    break;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Dodaj parametry w zależności od kryterium
                        switch (comboBox1.SelectedItem?.ToString())
                        {
                            case "Imie":
                            case "Nazwisko":
                            case "Login":
                            case "Email":
                                cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");
                                break;
                            case "Numer telefonu":
                                cmd.Parameters.AddWithValue("@numerTelefonu", $"%{searchValue}%");
                                break;
                            case "Pesel":
                                cmd.Parameters.AddWithValue("@pesel", $"%{searchValue}%");
                                break;
                        }

                        // Wypełnij DataTable i przypisz do DataGridView
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
        }

        private void buttonSzukaj2_Click_1(object sender, EventArgs e)
        {
            SearchData2();
        }


        

        
    }
}
