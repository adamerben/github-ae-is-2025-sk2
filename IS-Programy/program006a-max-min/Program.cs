string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Generátor **********************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Adam Erben ******************");
    Console.WriteLine("************** 13.11.2025 *******************");
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
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write($"{myRandNumbs[i]} ");
    }


    // hledaní maxima, pozice maxima, minima, pozice minima

    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;

    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("======================================");
    Console.WriteLine($"Maximum: {max}, pozice maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}, pozice minima: {posMin}");
    Console.WriteLine("======================================");


    // vykreslovani presypacich hodin
    if (max >= 3)
    {
        Console.WriteLine();
        Console.WriteLine("=============================");
        Console.WriteLine();
        Console.WriteLine($"Přespací hodiny o velikosti {max}");
        Console.WriteLine();


        // tento cyklus se stara o to aby se vykreslil správný počet řádků
        for (int i = 0; i < max; i++)
        {
            int spaces, stars;

            if (i < max / 2)
            {
             spaces = i;
             stars = max - 2 * i;   
            } else
            {
                spaces = max - i - 1;
                if (max % 2 == 1)
                {
                    stars = 2 * (i - max / 2) + 1;
                } else
                {
                    stars = 2 * (i - max / 2) + 2;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            // vykresleni mezer pro kazdy radek
            for (int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }
            // vykresleni hvezdicek pro kazdy radek
            for (int st = 0; st < stars; st++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    } else
    {
        Console.WriteLine("Maximum je menší než 3 => obrazec se nebude vykreslovat");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}