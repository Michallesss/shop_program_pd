using sklep;

List<Produkt> produkty = new List<Produkt>();
List<Magazyn> magazyny = new List<Magazyn>();
List<Adres> adresy = new List<Adres>();

for ( ; ; )
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

    switch (wybor)
    {
        case 1: break;
        case 2: break;
        case 3: break;
        case 4:
            Environment.Exit(0);
            break;
        default: break;
    }

    Console.Clear();
}