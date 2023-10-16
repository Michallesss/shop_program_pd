using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class Magazyn
    {
        // Właściwości (wszystkie defaltowo private) z odwołaniami do innych klas
        Produkt[] produkty;
        Adres adres;

        // Konstruktor
        Magazyn(Produkt[] produkty, Adres adres)
        {
            this.produkty = produkty;
            this.adres = adres;
        }

        // Usuwanie poprzez ustawianie w kodzie zmiennej w której trzymany jest obiekt na null
    }
}
