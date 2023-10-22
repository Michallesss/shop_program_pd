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
        public void Edit(List<Produkt> listaProduktow, List<Adres> listaAdresow)
        {
            Console.WriteLine("------Edytowanie-magazynu------");
            Console.WriteLine("Dodawanie produktów od nowa:");
            Console.WriteLine("-2.Nie edytuj");
            Console.WriteLine("-1.Skończ dodawanie");
            Produkt[] produktyMagazynowe = { };
            int i = 0;
            foreach (Produkt p in listaProduktow)
            {
                Console.WriteLine(i + ". " + p.NazwaProduktu);
                i++;
            }
            Console.WriteLine("-------------------------------");
            for (int j = 0; ; j++)
            {
                Console.Write("Produkt do dodania: ");
                int produktMagazynu = -2;
                try { produktMagazynu = Convert.ToInt32(Console.ReadLine()); }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Podano zły index..");
                    Console.ReadLine();
                    break;
                }
                if (produktMagazynu < -2 || produktMagazynu > listaProduktow.Count)
                {
                    Console.Clear();
                    Console.WriteLine("Podano zły index..");
                    Console.ReadLine();
                    break;
                }
                if (produktMagazynu == -1)
                    break;
                else
                    produkty[j] = listaProduktow[produktMagazynu];
            }

            Console.WriteLine("Dodanie adresu (" + adres.Adress + "):");
            int q = -1;
            foreach (Adres a in listaAdresow)
            {
                Console.WriteLine(i + ". " + a.Adress);
                i++;
            }
            Console.WriteLine("-------------------------------");
            Console.Write("Adres do zastąpienia: ");
            int adresMagazynu = -1;
            try { adresMagazynu = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.Clear();
                Console.WriteLine("Podano zły index..");
                Console.ReadLine();
            }
            if (adresMagazynu < -2 || adresMagazynu > listaAdresow.Count)
            {
                Console.Clear();
                Console.WriteLine("Podano zły index..");
                Console.ReadLine();
            }
            adres = listaAdresow[adresMagazynu];

            Console.Write("Zaktualizowano..");
            Console.ReadLine();
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
