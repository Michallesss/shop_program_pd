using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class Produkt
    {
        // Właściwości (wszystkie defaltowo private)
        string nazwaProducenta
        {
            // funkcja właściwości która działa podczas odczytywania (np. Console.Write(adres.nazwaProducenta);) w tym przypadki zmiennej nazwaProducenta
            get { return nazwaProducenta; }
            // funkcja właściwości która działa podczas edytowania (np adres.nazwaProducenta="inprobud";) w tym przypadki zmiennej nazwaProducenta
            set { nazwaProducenta = value; }
        }
        string nazwaProduktu
        {
            get { return nazwaProduktu; }
            set { nazwaProduktu = value; }
        }
        string kategoria
        {
            get { return kategoria; }
            set { kategoria = value; }
        }
        string kodProduktu
        {
            get { return kodProduktu; }
            set { kodProduktu= value; }
        }
        float cena
        {
            get { return cena; }
            set { cena = value; }
        }
        string opis
        {
            get { return opis; }
            set { opis = value; }
        }

        // Konstruktor z defaultowymi wartościami
        Produkt(string nazwaProducenta = "", string nazwaProduktu = "", string kategoria = "", string kodProduktu = "", float cena = 0, string opis = "")
        {
            this.nazwaProducenta = nazwaProducenta;
            this.nazwaProduktu = nazwaProduktu;
            this.kategoria = kategoria;
            this.kodProduktu = kodProduktu;
            this.cena = cena;
            this.opis = opis;
        }

        // Usuwanie poprzez ustawianie w kodzie zmiennej w której trzymany jest obiekt na null
    }
}
