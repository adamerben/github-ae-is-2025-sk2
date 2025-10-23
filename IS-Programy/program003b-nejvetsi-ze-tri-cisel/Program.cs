string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Tomáš Žižka ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


    Console.Write("zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    Console.Write("zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    Console.Write("zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    if (a >= b && a >= c)
    {
        Console.WriteLine();
        Console.WriteLine("================================================================");
        Console.WriteLine($"Největší číslo je: {a}");
        Console.WriteLine("================================================================");
    }
    else if (b >= a && b >= c)
    {
        Console.WriteLine();
        Console.WriteLine("================================================================");
        Console.WriteLine($"Největší číslo je: {b}");
        Console.WriteLine("================================================================");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("================================================================");
        Console.WriteLine($"Největší číslo je: {c}");
        Console.WriteLine("================================================================");
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}