using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class MainAdminstratorForm : Form
    {
        private Raport raport;

        public MainAdminstratorForm(string imie)
        {
            InitializeComponent();
            label1.Text = imie;
            string connectionString = PolaczenieBazyDanych.StringPolaczeniowy();
            raport = new Raport("", "", connectionString);
        }

        private void buttonGenerujRaport_Click(object sender, EventArgs e)
        {
            try
            {
                // Wyświetlenie okna dialogowego wyboru ścieżki i nazwy pliku
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Zapisz raport jako";
                    saveFileDialog.FileName = "Raport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaExcel = saveFileDialog.FileName;

                        // Pobierz dane z klasy Raport
                        List<string> raportDane = raport.GenerujRaport();

                        // Sprawdź, czy raport zawiera dane
                        if (raportDane == null || raportDane.Count == 0)
                        {
                            MessageBox.Show("Raport nie zawiera danych do wygenerowania.",
                                            "Błąd",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return;
                        }

                        // Tworzenie pliku Excel
                        GenerujExcel(sciezkaExcel, raportDane);

                        MessageBox.Show($"Raport został pomyślnie wygenerowany i zapisany w lokalizacji: {sciezkaExcel}.",
                                        "Sukces",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}",
                                "Błąd",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void GenerujExcel(string sciezkaExcel, List<string> raportDane)
        {
            try
            {
                Console.WriteLine($"Ścieżka Excel: {sciezkaExcel}");

                // Tworzenie nowego pliku Excel
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.AddWorksheet("Raport");

                    // Dodanie tytułu
                    worksheet.Cell(1, 1).Value = "Raport Biblioteki";
                    worksheet.Cell(1, 1).Style.Font.Bold = true;
                    worksheet.Cell(1, 1).Style.Font.FontSize = 16;
                    worksheet.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    worksheet.Range(1, 1, 1, 5).Merge();

                    // Dodanie daty generacji raportu
                    string dataRaportu = $"Data: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                    worksheet.Cell(2, 1).Value = dataRaportu;
                    worksheet.Cell(2, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);
                    worksheet.Cell(2, 1).Style.Font.FontSize = 12;

                    // Dodanie zawartości raportu
                    if (raportDane != null && raportDane.Count > 0)
                    {
                        int row = 3;
                        foreach (string linia in raportDane)
                        {
                            worksheet.Cell(row, 1).Value = linia;
                            worksheet.Cell(row, 1).Style.Font.FontSize = 12;
                            worksheet.Cell(row, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                            row++;
                        }
                    }
                    else
                    {
                        // Jeśli brak danych
                        worksheet.Cell(3, 1).Value = "Brak danych do wyświetlenia.";
                        worksheet.Cell(3, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    }

                    // Zapisanie pliku Excel
                    workbook.SaveAs(sciezkaExcel);
                }

                // Informacja o sukcesie
                MessageBox.Show("Plik Excel został wygenerowany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Wyświetlenie błędu w MessageBox
                MessageBox.Show($"Wystąpił błąd przy generowaniu pliku Excel: {ex.Message}\n{ex.StackTrace}",
                                "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUsunPracownika_Click(object sender, EventArgs e)
        {
            PracownicyAdministrator usunPracownikaAdministrator = new PracownicyAdministrator();
            usunPracownikaAdministrator.Show();
        }

        private void buttonEdycjaZbioru_Click(object sender, EventArgs e)
        {
            EdycjaProduktowAdminForm edycjaIlosciProduktowAdminForm = new EdycjaProduktowAdminForm();
            edycjaIlosciProduktowAdminForm.Show();
        }

        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            DodajPracownikaForm dodajPracownika = new DodajPracownikaForm();
            dodajPracownika.Show();
        }

        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {
            DodajNwoyProduktAdminForm dodajNwoyProduktAdmin = new DodajNwoyProduktAdminForm();
            dodajNwoyProduktAdmin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EdytujCennikAdmin edytujCennikAdmin = new EdytujCennikAdmin();
            edytujCennikAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zostałeś pomyślnie wylogowany. Do zobaczenia!");
            this.Close();
        }
    }
}
