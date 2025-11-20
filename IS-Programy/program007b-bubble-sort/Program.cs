using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Generátor **********************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Adam Erben ******************");
    Console.WriteLine("************** 6.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("===============================================");
    Console.WriteLine($"počet čísel: {n}, dolní mez: {lowerBound}, horní mez: {upperBound}");
    Console.WriteLine("===============================================");
    Console.WriteLine();

    // deklarace pole (array)

    int[] myRandNumbs = new int[n];

    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("Nahodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound) + 1;
        Console.Write($"{myRandNumbs[i]} ");
    }

    Stopwatch myStopwatch = new Stopwatch();

    int compare = 0;
    int change = 0;

    myStopwatch.Start();
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            compare++;
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j+1];
                myRandNumbs[j+1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;
                change++;
            }
        }
    }
    myStopwatch.Stop();
    
    int secondMaxNumber = 0;
    
    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i + 1] > myRandNumbs[i + 2])
        {
            secondMaxNumber = myRandNumbs[i + 1];
            break;
        }
        
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Seřazená čísla:");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0} ", myRandNumbs[i]);
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet prohozů: {change}");
    Console.WriteLine($"Doba běhu: {myStopwatch.Elapsed.TotalMilliseconds} ms");
    Console.WriteLine($"Druhé největší číslo: {secondMaxNumber}");


    for (int i = 0; i < secondMaxNumber; i++)
    {
        for (int j = 0; j < secondMaxNumber; j++)
        {
            if (j == 0 || j == secondMaxNumber - 1)
            {
                Console.Write("*");

            } else
            {
                if (i == 0 || i == 1 || i == secondMaxNumber - 1 || i == secondMaxNumber - 2)
                {
                    Console.Write("*");
                } else
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}