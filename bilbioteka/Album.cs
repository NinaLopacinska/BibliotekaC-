using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilbioteka
{
    internal class Album : Zasoby
    {
        public int LiczbaZdjec { get; set; }

        public Album(string tytul, string autor, int rokWydania, int numerKatalogowy, string typ, bool czyWypozyczone, float ocena, int ilosc, string kategoria, int liczbaZdjec)
            : base(tytul, autor, rokWydania, numerKatalogowy, typ, czyWypozyczone, ocena, ilosc, kategoria)

        {
            LiczbaZdjec = liczbaZdjec;
        }
    }
}
