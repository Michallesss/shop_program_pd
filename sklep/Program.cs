using sklep;

List<Produkt> produkty = new List<Produkt>();
List<Magazyn> magazyny = new List<Magazyn>();
List<Adres> adresy = new List<Adres>();

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
        case 1: break;
        case 2: break;
        case 3: break;
        case 4: break;
        default: break;
    }
}

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
        case 1: break;
        case 2: break;
        case 3: break;
        case 4: break;
        case 5: break;
        case 6: break;
        default: break;
    }
}

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
        case 1: break;
        case 2: break;
        case 3: break;
        default: break;
    }
}

for ( ; ; )
{
    switch (Menu())
    {
        case 1:
            Produkty();
            break;
        case 2:
            Magazyny();
            break;
        case 3:
            Adresy();
            break;
        case 4:
            Environment.Exit(0);
            break;
        default: break;
    }

    Console.Clear();
}