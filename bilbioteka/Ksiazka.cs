using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilbioteka
{
    internal class Ksiazka : Zasoby
    {
        public int LiczbaStron { get; set; }

        public Ksiazka(string tytul, string autor, int rokWydania, int numerKatalogowy, string typ, bool czyWypozyczone, float ocena, int ilosc, string kategoria, int liczbaStron)
            : base(tytul, autor, rokWydania, numerKatalogowy, typ, czyWypozyczone, ocena, ilosc, kategoria)

        {
            LiczbaStron = liczbaStron;
        }
    }
}
