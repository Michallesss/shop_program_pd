using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class Adres
    {
        // Właściwości
        string ulica;
        // Takie utworzenie dodatkowej właściwości Ulica pozwala dać dostęp tylko do odczytywania właściwości ulica
        string kodPocztowy;
        string miejscowosc;
        string numerPosesji;
        string numerLokalu;
        // zamiast tworzyć publiczną włąściwość dla każdego (ulica, numerPosesji, ...) stworzyłem jedną zwracającą od razu sformatowany adres
        public string Adress
        {
            get
            {
                return ulica + " " + numerPosesji + "/" + numerLokalu + ", " + miejscowosc;
            }
            set { }
        }

        // Konstruktor z defaultowymi wartościami
        public Adres(string ulica = "", string kodPocztowy = "", string miejscowosc = "", string numerPosesji = "", string numerLokalu = "")
        {
            this.ulica = ulica;
            this.kodPocztowy= kodPocztowy;
            this.miejscowosc= miejscowosc;
            this.numerPosesji= numerPosesji;
            this.numerLokalu= numerLokalu;
        }
    }
}
