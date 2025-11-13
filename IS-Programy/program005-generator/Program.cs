string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Generátor **********************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Adam Erben ******************");
    Console.WriteLine("************** 6.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("===============================================");
    Console.WriteLine($"počet čísel: {n}, dolní mez: {lowerBound}, horní mez: {upperBound}");
    Console.WriteLine("===============================================");
    Console.WriteLine();

    // deklarace pole (array)

    int[] myRandNumbs = new int[n];

    Random myRandNumb = new Random();

    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeros = 0;

    int evenNumbs = 0;
    int oddNumbs = 0;

    Console.WriteLine();
    Console.WriteLine("Nahodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound) + 1;
        if (myRandNumbs[i] < 0)
        {
            negativeNumbs++;
        }
        else if (myRandNumbs[i] > 0)
        {
            positiveNumbs++;
        }
        else
        {
            zeros++;
        }
        if (myRandNumbs[i] % 2 == 0)
        {
            evenNumbs++;
        }
        else
        {
            oddNumbs++;
        }
        Console.Write($"{myRandNumbs[i]} ");
    }

    Console.WriteLine();
    Console.WriteLine("===============================================");
    Console.WriteLine("===============================================");
    Console.WriteLine($"Počet záporných čísel: {negativeNumbs}");
    Console.WriteLine($"Počet kladných čísel: {positiveNumbs}");
    Console.WriteLine($"Počet nul: {zeros}");
    Console.WriteLine("===============================================");
    Console.WriteLine("===============================================");
    Console.WriteLine($"Počet sudých čísel: {evenNumbs}");
    Console.WriteLine($"Počet lichých čísel: {oddNumbs}");
    Console.WriteLine("===============================================");
    Console.WriteLine("===============================================");


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}