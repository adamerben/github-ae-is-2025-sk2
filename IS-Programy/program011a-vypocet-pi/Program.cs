string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Konvergentní řady **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Adam Erben *******************");
    Console.WriteLine("************** 4.12.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte přesnost (celé číslo): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    double i = 1;
    double piCtvrt = 1;
    double znamenko = 1;

    while ((1/i) >= presnost)
    {
        i += 2;
        znamenko = -znamenko;
        piCtvrt += znamenko * (1/i); 
    }


    double pi = 0;
    pi = piCtvrt * 4;

    Console.WriteLine(pi);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}