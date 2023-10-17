// Implementacja sklepu czyli wszystkich dodatkowych klass
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
    int wybor = -1;
    try { wybor = Convert.ToInt32(Console.ReadLine()); } catch { }

    switch (wybor)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("------Produkty------");
            int i = 0;
            foreach (Produkt p in produkty)
            {
                Console.WriteLine(i + ". " + p.NazwaProduktu);
                i++;
            }
            Console.WriteLine("--------------------");
            Console.Write("Kliknij dowolny przycisk aby wrócić..");
            Console.ReadLine();
            break;
        
        case 2:
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
            try { cena = (float)Convert.ToDouble(Console.ReadLine()); } catch
            {
                Console.Clear();
                Console.WriteLine("Zły format ceny..");
                Console.ReadLine();
                break;
            }
            Console.Write("Opis: ");
            string opis = Console.ReadLine();
            produkty.Add(new Produkt(producent, produkt, kategoria, kod, cena, opis));
            Console.Write("Dodano..");
            Console.ReadLine();
            break;
        
        case 3: 
            Console.Clear();
            Console.WriteLine("------Edytowanie-produktu------");
            int j = 0;
            foreach (Produkt p in produkty)
            {
                Console.WriteLine(j + ". " + p.NazwaProduktu);
                j++;
            }
            Console.WriteLine("-------------------------------");
            Console.Write("Produkt do zedytowania: ");
            int edit = -1;
            try { edit = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.Clear();
                Console.WriteLine("Podano zły index..");
                Console.ReadLine();
                break;
            }
            if (edit < 0 || edit > produkty.Count-1)
            {
                Console.Clear();
                Console.WriteLine("Podano zły index..");
                Console.ReadLine();
                break;
            }
            produkty[edit].Edit();
            break;
        
        case 4:
            Console.Clear();
            Console.WriteLine("------Usuwanie-produktu------");
            int ij = 0;
            foreach (Produkt p in produkty)
            {
                Console.WriteLine(ij + ". " + p.NazwaProduktu);
                ij++;
            }
            Console.WriteLine("-----------------------------");
            Console.Write("Produkt do usunięcia: ");
            int delete = -1;
            try { delete = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.Clear();
                Console.WriteLine("Podano zły index..");
                Console.ReadLine();
                break;
            }
            if (delete < 0 || delete > produkty.Count - 1)
            {
                Console.Clear();
                Console.WriteLine("Podano zły index..");
                Console.ReadLine();
                break;
            }
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
    Console.WriteLine("5.Dodaj produkt do magazynu");
    Console.WriteLine("6.Usuń produkt z magazynu");
    Console.WriteLine("7.Wróc do menu");
    Console.WriteLine("---------------------------------");
    Console.Write("Twój wybór: ");
    int wybor = -1;
    try { wybor = Convert.ToInt32(Console.ReadLine()); } catch { }

    switch (wybor)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("------Magazyny------");
            int i = 0;
            foreach (Magazyn m in magazyny)
            {
                Console.WriteLine(i + ". " + m.adres);
                i++;
            }
            Console.WriteLine("--------------------");
            Console.Write("Kliknij dowolny przycisk aby wrócić..");
            Console.ReadLine();
            break;
        
        case 2: break;
        
        case 3: break;
        
        case 4: break;
        
        case 5: break;
        
        case 6: break;
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
            Console.WriteLine("------Adresy------");
            int i = 0;
            foreach (Adres a in adresy)
            {
                Console.WriteLine(i + ". " + a.Ulica + " " + a.NumerPosesji + "/" + a.NumerLokalu + ", " + a.Miejscowosc);
                i++;
            }
            Console.WriteLine("------------------");
            Console.Write("Kliknij dowolny przycisk aby wrócić..");
            Console.ReadLine();
            break;
        
        case 2: break;
        
        case 3: break;
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

    Console.Clear();
}