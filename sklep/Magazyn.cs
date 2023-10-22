using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class Magazyn
    {
        // Właściwości (wszystkie defaltowo private czyli dostępne tylko dla metod klasy) z odwołaniami do innych obiektów klas
        Produkt[] produkty { get; set; }
        Adres adres { get; set; }
        public string Adres
        {
            get
            {
                return adres.Adress;
            }
            set { }
        }

        // Metoda zajmuje sie pobieraniem danych i edytowaniem ich
        public void Edit()
        {
            Console.WriteLine("------Edytowanie-magazynu------");
            // ...
        }

        // Konstruktor
        public Magazyn(Produkt[] produkty, Adres adres)
        {
            this.produkty = produkty;
            this.adres = adres;
        }

        // Usuwanie poprzez usuwanie z listy
    }
}
