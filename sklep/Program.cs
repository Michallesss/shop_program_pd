﻿// Implementacja sklepu czyli wszystkich dodatkowych klass
using sklep;

// Tworzenie List przechowywujących obiekty o typie danego obiektu
List<Produkt> produkty = new List<Produkt>();
List<Magazyn> magazyny = new List<Magazyn>();
List<Adres> adresy = new List<Adres>();

// Funkcja wyświetlająca menu i zwracająca wybraną przez użytkownika opcje
int Menu()
{
    Console.WriteLine("-----Menu-----");
    Console.WriteLine("1.Zarządzanie produktami");
    Console.WriteLine("2.Zarządzanie magazynami");
    Console.WriteLine("3.Zarządzanie adresami");
    Console.WriteLine("4.Wyjdź");
    Console.WriteLine("--------------");
    Console.Write("Twój wybór: ");
    int wybor = -1;
    try { wybor = Convert.ToInt32(Console.ReadLine()); } catch { }
    return wybor;
}

// Funkcja generująca liste i zwracająca wybrany element
int GenMenu<T>(string tytol, string zapytanie, List<T> lista)
{

    // Tworzenie nagłówka
    string naglowek = "------" + tytol.Replace(' ', '-') + "------";
    Console.WriteLine(naglowek);
    int i = 0;
    foreach (IKlasy o in lista)
    {
        Console.WriteLine(i + ". " + o.Data);
        i++;
    }
    // Tworzenie podgłówka
    string podglowek = "";
    foreach (char n in naglowek) podglowek += "-";
    Console.WriteLine(podglowek);
    if (zapytanie == null)
    {
        Console.Write("Kliknij dowolny przycisk aby wrócić..");
        // Czekanie na enter
        Console.ReadLine();
        return -1;
    } 
    else
    {
        Console.Write(zapytanie);
        int wybor = -1;
        try { wybor = Convert.ToInt32(Console.ReadLine()); }
        catch
        {
            Console.Clear();
            Console.WriteLine("Podano zły index..");
            Console.ReadLine();
            return -1;
        }
        if (wybor < 0 || wybor > lista.Count - 1)
        {
            Console.Clear();
            Console.WriteLine("Podano zły index..");
            Console.ReadLine();
            return -1;
        }
        return wybor;
    }
}

// Funkcja wyświetlająca submenu dla produktór i obsługująca nawigacje
void Produkty()
{
    Console.WriteLine("-----Zarządzanie-produktami------");
    Console.WriteLine("1.Wyświetl produkty");
    Console.WriteLine("2.Dodaj produkt");
    Console.WriteLine("3.Edytuj produkt");
    Console.WriteLine("4.Usuń produkt");
    Console.WriteLine("5.Wróc do menu");
    Console.WriteLine("---------------------------------");
    Console.Write("Twój wybór: ");
    // zmienna jest ustawiana już tutaj ponieważ gdyby ustawić ją  w try catch to była by ona dostępna tylko w bloku try catch
    int wybor = -1;
    try { wybor = Convert.ToInt32(Console.ReadLine()); } catch { }

    switch (wybor)
    {
        case 1:
            // Wyświetlanie wszystkich
            Console.Clear();
            GenMenu("Produkty", null, produkty);
            break;
        
        case 2:
            // Dodawanie nowego
            Console.Clear();
            Console.WriteLine("------Dodawanie-produktu------");
            Console.Write("Nazwa producenta: ");
            string producent = Console.ReadLine();
            Console.Write("Nazwa produktu: ");
            string produkt = Console.ReadLine();
            Console.Write("Kategoria: ");
            string kategoria = Console.ReadLine();
            Console.Write("Kod produktu: ");
            string kod = Console.ReadLine();
            Console.Write("Cena: ");
            float cena = -1;
            // sprawdzanie czy cene da sie przekonwertować z zwracanego przez RealLina stringa na double a co za tym idzie na 
            try { cena = (float)Convert.ToDouble(Console.ReadLine()); } catch
            {
                Console.Clear();
                Console.WriteLine("Zły format ceny..");
                Console.ReadLine();
                break;
            }
            Console.Write("Opis: ");
            string opis = Console.ReadLine();
            // Dodawanie do listy produktów nowego obiektu klasy Produkt
            produkty.Add(new Produkt(producent, produkt, kategoria, kod, cena, opis));
            Console.Write("Dodano..");
            Console.ReadLine();
            break;
        
        case 3: 
            // Edytowanie 
            Console.Clear();
            // Wywoływanie metody Edit() z indexu tablicy pod którym jest obiekt
            int edit = GenMenu("Edytowanie produktów", "Produkt do zedytowania: ", produkty);
            if (edit == -1) break;
            produkty[edit].Edit();
            break;
        
        case 4:
            // Usuwanie
            Console.Clear();
            // Usuwanie komórki w której zapisany jest obiekt
            int delete = GenMenu("Usuwanie produktu", "Produkt do usuniecia: ", produkty);
            if (delete == -1) break;
            produkty.RemoveAt(delete);
            Console.Write("Usunięto..");
            Console.ReadLine();
            break;
        default: break;
    }
}

// Funkcja wyświetlająca submenu dla magazynów i obsługująca nawigacje
void Magazyny()
{
    Console.WriteLine("-----Zarządzanie-magazynami------");
    Console.WriteLine("1.Wyświetl magazyny");
    Console.WriteLine("2.Dodaj magazyn");
    Console.WriteLine("3.Edytuj magazyn");
    Console.WriteLine("4.Usuń magazyn");
    Console.WriteLine("5.Wróc do menu");
    Console.WriteLine("---------------------------------");
    Console.Write("Twój wybór: ");
    int wybor = -1;
    try { wybor = Convert.ToInt32(Console.ReadLine()); } catch { }

    switch (wybor)
    {
        case 1:
            // Wyświetlanie wszystkich
            Console.Clear();
            GenMenu("Magazyny", null, magazyny);
            break;
        
        case 2:
            // Dodawanie nowego
            Console.Clear();
            Console.WriteLine("------Dodawanie-magazynu------");
            Console.WriteLine("Dodaj produkty:");
            Console.WriteLine("-1.Skończ dodawać");
            List<Produkt> produktyMagazynowe = new List<Produkt>() { };
            int i = 0;
            foreach (Produkt p in produkty)
            {
                Console.WriteLine(i + ". " + p.Data);
                i++;
            }
            Console.WriteLine("------------------------------");
            for ( ; ; )
            {
                Console.Write("Produkt do dodania: ");
                int produktMagazynu = -1;
                try { produktMagazynu = Convert.ToInt32(Console.ReadLine()); } catch
                {
                    Console.Clear();
                    Console.WriteLine("Podano zły index..");
                    Console.ReadLine();
                    break;
                }
                if (produktMagazynu < -1 || produktMagazynu > produkty.Count - 1)
                {
                    Console.Clear();
                    Console.WriteLine("Podano zły index..");
                    Console.ReadLine();
                    break;
                }
                if (produktMagazynu == -1)
                    break;
                else
                    produktyMagazynowe.Add(produkty[produktMagazynu]);
            }

            int adresMagazynu = GenMenu("Wybierz adres magazynu", "Adres magazynu: ", adresy);
            if (adresMagazynu == -1) break;

            magazyny.Add(new Magazyn(produktyMagazynowe, adresy[adresMagazynu]));
            Console.Write("Dodano..");
            Console.ReadLine();
            break;
        
        case 3:
            // Edytowanie
            Console.Clear();
            int edit = GenMenu("Edytuj magazyn", "Magazyn do zedytowania: ", magazyny);
            if (edit == -1) break;
            magazyny[edit].Edit(produkty, adresy);
            break;
        
        case 4:
            // Usuwanie
            int delete = GenMenu("Usuń magazyn", "Magazyn do usunięcia: ", magazyny);
            if (delete == -1) break;
            magazyny.RemoveAt(delete);
            Console.Write("Usunięto..");
            Console.ReadLine();
            break;
        default: break;
    }
}

// Funkcja wyświetlająca submenu dla adresów i obsługująca nawigacje
void Adresy()
{
    Console.WriteLine("-----Zarządzanie-adresami------");
    Console.WriteLine("1.Wyświetl adresy");
    Console.WriteLine("2.Dodaj adres");
    Console.WriteLine("3.Usuń adres");
    Console.WriteLine("4.Wróc do menu");
    Console.WriteLine("-------------------------------");
    Console.Write("Twój wybór: ");
    int wybor = -1;
    try { wybor = Convert.ToInt32(Console.ReadLine()); } catch { }

    switch (wybor)
    {
        case 1:
            Console.Clear();
            GenMenu("Adresy", null, adresy);
            break;
        
        case 2:
            Console.Clear();
            Console.WriteLine("------Dodawanie-adresu------");
            Console.Write("Ulica: ");
            string ulica = Console.ReadLine();
            Console.Write("Kod pocztowy: ");
            string kodPocztowy = Console.ReadLine();
            Console.Write("Miejscowosc: ");
            string miejscowosc = Console.ReadLine();
            Console.Write("Numer posesji: ");
            string numerPosesji = Console.ReadLine();
            Console.Write("Numer lokalu: ");
            string numerLokalu = Console.ReadLine();

            adresy.Add(new Adres(ulica, kodPocztowy, miejscowosc, numerPosesji, numerLokalu));
            Console.Write("Dodano..");
            Console.ReadLine();
            break;
        
        case 3:
            Console.Clear();
            int delete = GenMenu("Usuwanie adresu", "Adres do usunięcia: ", adresy);
            if (delete == -1) break;
            adresy.RemoveAt(delete);
            Console.Write("Usunięto..");
            Console.ReadLine();
            break;
        default: break;
    }
}

// Nieskończona pętla (puste for w przeciwieństwie do while true nie musi sprawdzać żadnego warunku)
for ( ; ; )
{
    switch (Menu())
    {
        case 1:
            Console.Clear();
            Produkty();
            break;
        case 2:
            Console.Clear();
            Magazyny();
            break;
        case 3:
            Console.Clear();
            Adresy();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Żegnaj..");
            // Wychodzenie z programu
            Environment.Exit(0);
            break;
        default: break;
    }

    // Koniec pętli wszystko zacznie sie od nowa więc czyszczenie konsoli
    Console.Clear();
}