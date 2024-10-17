using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilbioteka
{
    internal class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int NumerTelefonu { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string KodPocztowy { get; set; }
        public string Ulica { get; set; }
        public string NrPosesji { get; set; }
        public string NrLokalu { get; set; }
        public string Pesel { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Email { get; set; }

        
        public Osoba(
            string imie, string nazwisko, int numerTelefonu, string login, string haslo, string kodPocztowy, string ulica, string nrPosesji, string pesel, DateTime dataUrodzenia, string email, string nrLokalu = "") 
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NumerTelefonu = numerTelefonu;
            Login = login;
            Haslo = haslo;
            KodPocztowy = kodPocztowy;
            Ulica = ulica;
            NrPosesji = nrPosesji;
            Pesel = pesel;
            DataUrodzenia = dataUrodzenia;
            Email = email;
            NrLokalu = nrLokalu; 
        }
    }
}
