using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Pujcovna
{
    public static class Databaze
    {
        //Aplikacni vrstva aplikace pro realizaci operace s jednotlivými datovými objekty
        public static BindingList<Zakaznik> Zakaznici { get; private set; } =
 new BindingList<Zakaznik>();
        public static BindingList<Disk> Sklad { get; private set; } = new BindingList<Disk>();
        static Databaze()
        {
            //inicializace nekolika konkretnich instanci 
            Zakaznici.Add(new Zakaznik("Pepa", "Novák", "Praha", 1980));
            Zakaznici.Add(new Zakaznik("Karel", "Vomáčka", "Kladno", 1990));
            Zakaznici.Add(new Zakaznik("František", "Dobrota", "Blízká Vesnice", 1995));
            Zakaznik z = new Zakaznik("Tomáš", "Marný", "Praha", 2002);
            Zakaznici.Add(z);
            z.Vypujcene.Add(new CD("Best of", "Ewa Farna", "pop", 25));
            Sklad.Add(new CD("Rosenrot", "Rammstein", "metal", 25));
            Sklad.Add(new CD("Black Ice", "AC/DC", "rock", 25));
            Sklad.Add(new CD("Plná taška", "Eva a Vašek", "psychedelický hardcore", 15));
            Sklad.Add(new Dvd("50 shades of grey", "Taylor Johnson", "erotický", 30,
            false));
            Sklad.Add(new Dvd("Fantastická zvířata a jak je najít", "David Yates",
            "fantasy", 25, true));
            Sklad.Add(new Dvd("Rogue One: A Star Wars Story", "Gareth Edwards", "Scifi",
            30, true));
        }

    }
}
