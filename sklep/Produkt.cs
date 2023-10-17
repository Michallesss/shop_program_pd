﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class Produkt
    {
        // Właściwości (wszystkie defaltowo private czyli dostępne tylko w klasie)
        string nazwaProducenta;
        string nazwaProduktu;
        // Takie utworzenie dodatkowej właściwości NazwaProduktu pozwala na wyświetlanie nazwy w całym kodzie bez możliwości edytowania tej właściwości
        public string NazwaProduktu
        {
            get { return nazwaProduktu; }
            set { }
        }
        string kategoria;
        string kodProduktu;
        float cena;
        string opis;

        // Metoda zajmuje sie pobieraniem danych i edytowaniem ich
        public void Edit()
        {
            Console.WriteLine("------Edycja-produktu------");
            Console.Write("Nazwa producenta (" + nazwaProducenta + "): ");
            string producent = Console.ReadLine();
            if (producent != "")
                nazwaProducenta = producent;

            Console.Write("Nazwa produktu (" + nazwaProduktu + "): ");
            string produkt = Console.ReadLine();
            if (produkt != "")
                nazwaProduktu = produkt;

            Console.Write("Kategoria (" + kategoria + "): ");
            string kat = Console.ReadLine();
            if (kat != "")
                kategoria = kat;

            Console.Write("Kod produktu (" + kodProduktu + "): ");
            string kod = Console.ReadLine();
            if (kod != "")
                kodProduktu = kod;

            Console.Write("Cena (" + cena + "): ");
            string cen = Console.ReadLine();
            if (cen != "")
            {
                try { cena = (float)Convert.ToDouble(cen); } catch
                {
                    Console.Clear();
                    Console.WriteLine("Zły format ceny..");
                    Console.ReadLine();
                    return;
                }
            }

            Console.Write("Opis (...): ");
            string opi = Console.ReadLine();
            if (opi != "")
                opis = opi;

            Console.Write("Zaktualizowano..");
            Console.ReadLine();
        }

        // Konstruktor z defaultowymi wartościami
        public Produkt(string nazwaProducenta = "", string nazwaProduktu = "", string kategoria = "", string kodProduktu = "", float cena = 0, string opis = "")
        {
            this.nazwaProducenta = nazwaProducenta;
            this.nazwaProduktu = nazwaProduktu;
            this.kategoria = kategoria;
            this.kodProduktu = kodProduktu;
            this.cena = cena;
            this.opis = opis;
        }
    }
}
