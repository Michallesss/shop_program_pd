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
        public Adres adres { get; set; }

        // Konstruktor
        Magazyn(Produkt[] produkty, Adres adres)
        {
            this.produkty = produkty;
            this.adres = adres;
        }

        // Usuwanie poprzez usuwanie z listy
    }
}
