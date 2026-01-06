string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Kombinovaná úloha **********************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Adam Erben ******************");
    Console.WriteLine("************** 6.1.2026 *******************");
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

    // Min, Max

    Console.WriteLine();

    int max = myRandNumbs[0];
    int min = myRandNumbs[0];

    for (int i = 0; i < n; i++)
    {
        if (max <= myRandNumbs[i])
        {
            max = myRandNumbs[i];
        }
        if (min >= myRandNumbs[i])
        {
            min = myRandNumbs[i];
        }
    }
    Console.WriteLine($" max je: {max}");
    Console.WriteLine($" min je: {min}");


    Console.WriteLine("----------------------");
    Console.Write($" max pozice jsou: ");
    for (int i = 0; i < n; i++)
    {
        if (max == myRandNumbs[i])
        {
            
            Console.Write($"{i}, ");
        }
    }
    Console.WriteLine();
    Console.Write($" min pozice jsou: ");
    for (int i = 0; i < n; i++)
    {
        if (min == myRandNumbs[i])
        {
            
            Console.Write($"{i}, ");
        }
    }
    
    Console.WriteLine();
    // Bubble Sort 

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j];
                myRandNumbs[j] = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = tmp;
            }
        }
    }

    Console.WriteLine($"pole po serazeni: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{myRandNumbs[i]}, ");
    }

    Console.WriteLine("-------------------");

    // Nejvetší čísla
    int uniqueNum = 0;
    int lastNum = int.MinValue;
    int second = 0; 
    int third = 0; 
    int fourth = 0;

    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] != lastNum)
        {
            uniqueNum++;
            lastNum = myRandNumbs[i];

            if (uniqueNum == 2)
            {
                second = lastNum;
            } 
            if (uniqueNum == 3)
            {
                third = lastNum;
            }
            if (uniqueNum == 4)
            {
                fourth = lastNum;
            }
        }
    }

    Console.WriteLine($"druhe nejvetsi cislo: {second}");
    Console.WriteLine($"treti nejvetsi cislo: {third}");
    Console.WriteLine($"ctvrte nejvetsi cislo: {fourth}");

    Console.WriteLine("-------------------------");

    // Median

    int median = n / 2;
    Console.WriteLine(myRandNumbs[median]);

    Console.WriteLine("-------------------------");

    // Prevod do binarni soustavy

    string bin = "";
    int x = fourth;
    while (x > 0)
    {
        bin += x % 2;
        x /= 2;
    }

    Console.WriteLine(bin);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}