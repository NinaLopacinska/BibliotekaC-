using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace bilbioteka
{
    internal class Dziecko : Osoba
    {
        public string ImieOpiekun {  get; set; }
        public string NazwiskoOpiekun { get; set;}
        public int NrTelefonuOpiekun { get; set;}
        public int PeselOpiekun { get; set;}
        public Dziecko (string imie, string nazwisko, int numerTelefonu, string login, string haslo, string kodPocztowy,
        string ulica, string nrPosesji, string pesel, DateTime dataUrodzenia, string email,
        string imieOpiekun, string nazwiskoOpiekun, int nrTelefonuOpiekun, int peselOpiekun,
        string nrLokalu = "")
            : base( imie,  nazwisko,  numerTelefonu,  login,  haslo,  kodPocztowy,  ulica,  nrPosesji,  pesel,  dataUrodzenia,  email,  nrLokalu = "")
        {
            ImieOpiekun = imieOpiekun;
            NazwiskoOpiekun = nazwiskoOpiekun;
            NrTelefonuOpiekun = nrTelefonuOpiekun;
            PeselOpiekun = peselOpiekun;
        }
    }
}
