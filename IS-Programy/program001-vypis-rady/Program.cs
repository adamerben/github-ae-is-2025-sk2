string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("*********Výpis číselné řady****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("************Adam Erben*********************");
    Console.WriteLine("*************2.10.2025*********************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale ŠPATNĚ řešený
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, ale LÉPE řešený
    Console.Write("Zadejte první číslo řady (musí být celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Zadejte první číslo řady (musí být celé číslo): ");
    }

    Console.Write("Zadejte poslední číslo řady (musí být celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Zadejte poslední číslo řady (musí být celé číslo): ");
    }

    Console.Write("Zadejte diferenci číslo řady (musí být celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.Write("Zadejte diferenci číslo řady (musí být celé číslo): ");
    }

    // Výstup zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine("Zadali jste tyto hodnoty: ");
    Console.WriteLine("První číslo řady: {0}", first);
    Console.WriteLine("Poslední číslo řady: {0}", last);
    Console.WriteLine("Diference: {0}", step);
    Console.WriteLine("================================");
    Console.WriteLine("První číslo: {0}; Poslední číslo: {1}; Diference: {2}", first, last, step);
    Console.WriteLine("================================");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte 'a'");
    again = Console.ReadLine();
}
