using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pujcovna
{
    public abstract class Disk
    {
        //trida Disk s konstruktorem pro snadnou inicializaci objektu od ktere budou dedit CD a DVD
        public string Nazev { get; set; }
        public string Zanr { get; set; }
        public int CenaVypujcky { get; set; }
        public Disk(string nazev, string zanr, int cenaVypujcky)
        {
            Nazev = nazev;
            Zanr = zanr;
            CenaVypujcky = cenaVypujcky;
        }

    }
    public class CD : Disk
    {
        //trida CD dedena z Disku se specifickým atributem Interpret
        public string Interpret { get; set; }
        public CD(string nazev, string interpret, string zanr, int cenaVypujcky) :
         base(nazev, zanr, cenaVypujcky)
        {
            Interpret = Interpret;
        }
    }
    public class Dvd : Disk
    {
        //trida DVD dedena z Disku se specifickými atributy Reziser a Pristupny
        public string Reziser { get; set; }
        public bool Pristupny { get; set; }
        public Dvd(string nazev, string reziser, string zanr, int cenaVypujcky,
        bool pristupny = true) : base(nazev, zanr, cenaVypujcky)
        {
            Reziser = reziser;
            Pristupny = pristupny;
        }
    }
}
