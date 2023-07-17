using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Pujcovna
{
    public class Zakaznik
    {
        //trida Zakaznik s konstruktorem pro snadnou inicializaci objektu
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Adresa { get; set; }
        public ushort RokNarozeni { get; set; }

        //list Vypujcene, ktery bude predstavovat kolekci aktualne vypujcenych polozek
        public BindingList<Disk> Vypujcene { get; private set; } = new BindingList<Disk>();
        public Zakaznik(string jmeno, string prijmeni, string adresa, ushort rokNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Adresa = adresa;
            RokNarozeni = rokNarozeni;
        }

    }
}
