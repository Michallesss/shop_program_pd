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
        public string Ulica
        {
            get { return ulica; }
            set { }
        }
        string kodPocztowy;
        public string KodPocztowy
        {
            get { return kodPocztowy; }
            set { }
        }
        string miejscowosc;
        public string Miejscowosc
        {
            get { return miejscowosc; }
            set { }
        }
        string numerPosesji;
        public string NumerPosesji
        {
            get { return numerPosesji; }
            set { }
        }
        string numerLokalu;
        public string NumerLokalu
        {
            get { return numerLokalu; }
            set { }
        }

        // Konstruktor z defaultowymi wartościami
        Adres(string ulica = "", string kodPocztowy = "", string miejscowosc = "", string numerPosesji = "", string numerLokalu = "")
        {
            this.ulica = ulica;
            this.kodPocztowy= kodPocztowy;
            this.miejscowosc= miejscowosc;
            this.numerPosesji= numerPosesji;
            this.numerLokalu= numerLokalu;
        }

        // Usuwanie poprzez usuwanie z listy
    }
}
