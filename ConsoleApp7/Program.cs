List<Artikli> artikli = new();
List<string> ime = new List<string>()
    {"Hleb", "Zejtin", "Mleko", "Krem", "Coca Cola"};
bool izlaz = false;

do
{
    StampajMeni();
    Console.Write("Izbor? ");
    string odabir = ime.ToString();

    string izb = Console.ReadLine();

    switch (izb)
    {
        case "1":
            Artikl();
            break;

        case "2":
            Ispis();
            Console.ReadKey();
            break;

        case "3":
            Brisanje();
            break;

        case "4":
            Console.WriteLine("Vozdra");
            izlaz = true;
            break;

        default:
            Console.WriteLine("Jok :/");
            break;
    }
   

    switch (odabir)
    {
        case "1":
            Console.WriteLine(ime.ElementAt(0));
            Console.ReadKey();
            break;
    }
    

    
} while (!izlaz);

void StampajMeni()
{
    Console.WriteLine("*********************");
    Console.WriteLine("1. Artikl");
    Console.WriteLine("2. Prikaz artikala");
    Console.WriteLine("3. Brisanje");
    Console.WriteLine("4. Izlaz");
    Console.WriteLine("*********************");
}

void Artikl()
{
    artikli.Add(new());
    
    int dex = 0;

    foreach (string s in ime)
    {
        Console.WriteLine($"{++dex}. {s}");
    }

    Console.Write("Unesi ime artikla: ");
    artikli.Last()._artikl = Console.ReadLine();
}

void Ispis()
{
    int dex = 0;
    foreach (Artikli a in artikli)
    {
        Console.WriteLine($"{++dex}. {a._artikl}");
    }
}

void Brisanje()
{
    Console.Write("Unesite indeks: ");
    int i = int.Parse(Console.ReadLine()) - 1;

    if (i >= 0 && i < artikli.Count)
    {
        artikli.RemoveAt(i);
    }
    else
    {
        Console.WriteLine("Jooook");
        Console.ReadKey();
    }
}
public class Artikli
{
    public string _artikl;
}