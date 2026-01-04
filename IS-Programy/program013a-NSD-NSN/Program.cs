string again = "a";
while (again == "a")
{
    Console.Clear();
    
    razitko();

    ulong a = nactiCislo("Zadej prirozene cislo a: ");
    ulong b = nactiCislo("Zadej prirozene cislo b: ");

    ulong nsd = vypocitatNSD(a, b);

    zobrazitVysledky(a, b, nsd);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

static void razitko()
{
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Tomáš Žižka ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
}

static ulong nactiCislo(string zprava)
{
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste prirozene cislo. Zadejte prirozene cislo znovu: ");
    }

    return cislo;
}

static ulong vypocitatNSD(ulong a, ulong b)
{

    while (a != b)
    {
        if (a > b)
        {
            a -= b;
        } else
        {
            b -= a;
        }
    }

    return a;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine($"NSD čísel {a} a {b} je {nsd}");

    Console.ForegroundColor = ConsoleColor.White;
}