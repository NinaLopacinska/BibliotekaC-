using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilbioteka
{
    internal class Film : Zasoby
    {
        public int CzasTrwania { get; set; }

        public Film(string tytul, string autor, int rokWydania, int numerKatalogowy, string typ, bool czyWypozyczone, float ocena, int ilosc, string kategoria, int czasTrwania)
            : base(tytul, autor, rokWydania, numerKatalogowy, typ, czyWypozyczone, ocena, ilosc, kategoria)
        {
            CzasTrwania = czasTrwania;
        }
    }
}
