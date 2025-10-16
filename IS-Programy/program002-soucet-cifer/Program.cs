﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Název programu *****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Tomáš Žižka ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

   
    Console.Write("zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }

    int suma = 0;
    int numberBackup = number;
    int digit;

    // pokud je číslo záporné, uděláme z něj kladné
    if (number < 0)
    {
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10; // získání poslední cifry
        number = (number - digit) / 10; // odstranění poslední cifry
        Console.WriteLine("Hodnota zbytku: {0}", digit);
        suma = suma + digit; // přičtení cifry k součtu
    }

    Console.WriteLine("Poslední zbytek = {0}", number);

    suma = suma + number;

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

