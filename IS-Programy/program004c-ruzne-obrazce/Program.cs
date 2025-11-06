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


    Console.Write("Zadejte volbu obrazce (12, ): ");
    int obrazec;
    while (!int.TryParse(Console.ReadLine(), out obrazec))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte velikost znovu: ");
    }
    Console.Write("Zadejte velikost obrazce: ");
    int size;
    while (!int.TryParse(Console.ReadLine(), out size))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte velikost znovu: ");
    }

    switch (obrazec)
    {
        case 12: 
        // 12
        for (int j = 0; j < size; j++)
        {
                for (int i = 0; i < size; i++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
        }
        
            break;
    }

    


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}