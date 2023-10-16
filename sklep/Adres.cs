using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class Adres
    {
        // Właściwości (wszystkie defaltowo private)
        string ulica;
        string kodPocztowy;
        string miejscowosc;
        string numerPosesji;
        string numerLokalu;

        // Konstruktor z defaultowymi wartościami
        Adres(string ulica = "", string kodPocztowy = "", string miejscowosc = "", string numerPosesji = "", string numerLokalu = "")
        {
            this.ulica = ulica;
            this.kodPocztowy= kodPocztowy;
            this.miejscowosc= miejscowosc;
            this.numerPosesji= numerPosesji;
            this.numerLokalu= numerLokalu;
        }

        // Usuwanie poprzez ustawianie w kodzie zmiennej w której trzymany jest obiekt na null
    }
}
