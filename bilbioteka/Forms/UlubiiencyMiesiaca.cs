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
    public partial class UlubiiencyMiesiaca : Form
    {
        public UlubiiencyMiesiaca()
        {
            InitializeComponent();
            WyswietlNajczesciejWypozyczaneWMiesiacu();
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WyswietlNajczesciejWypozyczaneWMiesiacu()
        {
            try
            {
                string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT  
                            z.Tytul, z.Autor, z.Typ,
                            COUNT(h.Id) AS 'Wypozyczenia',
                            AVG(z.Ocena) AS 'SredniaOcena'
                        FROM [biblioteka].[dbo].[HistoriaWypozyczen] h
                        JOIN [biblioteka].[dbo].[zasoby] z ON h.ZasobId = z.Id
                        WHERE MONTH(h.DataWypozyczenia) = MONTH(GETDATE())
                        GROUP BY z.Tytul, z.Autor, z.Typ
                        ORDER BY Wypozyczenia DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            dataGridViewPozycja.DataSource = dataTable;
                        }
                        foreach (DataGridViewRow row in dataGridViewPozycja.Rows)
                        {
                            if (row.Cells["SredniaOcena"].Value != DBNull.Value)
                            {
                                // Formatuj średnią ocenę do dwóch miejsc po przecinku
                                row.Cells["SredniaOcena"].Value = string.Format("{0:F2}", row.Cells["SredniaOcena"].Value);
                            }
                        }

                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Błąd bazy danych: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas ładowania danych: {ex.Message}");
            }
        }

    }
}
