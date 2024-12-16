using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using PdfSharp.Drawing;


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


        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            DodajPracownikaForm dodajPracownikaForm = new DodajPracownikaForm();
            dodajPracownikaForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zostałeś pomyślnie wylogowany. Do zobaczenia!");
            this.Close();
        }

        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {
            DodajNwoyProduktAdminForm dodajNwoyProduktAdminForm = new DodajNwoyProduktAdminForm();
            dodajNwoyProduktAdminForm.Show();

        }

        private void buttonEdycjaZbioru_Click(object sender, EventArgs e)
        {
            EdycjaProduktowAdminForm edycjaProduktowAdminForm = new EdycjaProduktowAdminForm();
            edycjaProduktowAdminForm.Show();

        }

        private void buttonGenerujRaport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Wybierz miejsce zapisu raportu";
                    saveFileDialog.Filter = "Pliki PDF (*.pdf)|*.pdf|Wszystkie pliki (*.*)|*.*";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    saveFileDialog.FileName = "Raport.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaPDF = saveFileDialog.FileName;

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

                        // Sprawdź, czy ścieżka zapisu jest poprawna
                        if (string.IsNullOrEmpty(sciezkaPDF) || !Directory.Exists(Path.GetDirectoryName(sciezkaPDF)))
                        {
                            MessageBox.Show("Ścieżka do pliku jest nieprawidłowa lub katalog nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Tworzenie pliku PDF
                        GenerujPDF(sciezkaPDF, raportDane);

                        MessageBox.Show($"Raport został pomyślnie wygenerowany i zapisany w lokalizacji: {sciezkaPDF}.",
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

        private void GenerujPDF(string sciezkaPDF, List<string> raportDane)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(sciezkaPDF))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        iText.Layout.Document dokument = new iText.Layout.Document(pdf);

                        // Używamy czcionki z iText
                        PdfFont font = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA);
                        PdfFont headerFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);

                        // Rysowanie tytułu
                        dokument.Add(new Paragraph("Raport Biblioteki").SetFont(headerFont).SetFontSize(14));

                        // Dodawanie danych do PDF
                        foreach (string linia in raportDane)
                        {
                            dokument.Add(new Paragraph(linia).SetFont(font).SetFontSize(12));
                        }

                        dokument.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd przy generowaniu pliku PDF: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUsunPracownika_Click(object sender, EventArgs e)
        {
            PracownicyAdministrator usunPracownikaAdministrator = new PracownicyAdministrator();
            usunPracownikaAdministrator.Show();

        }
    }



}
