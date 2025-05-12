
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Vil du spille? (Y/N)");
            string playGame = Console.ReadLine();

            if (playGame.ToUpper() == "Y")
            {
                Console.WriteLine("Flott! La oss spille!");
            }
            else if (playGame.ToUpper() == "N")
            {
                Console.WriteLine("Ok, ha en fin dag!");
                return;
            }
            else
            {
                Console.WriteLine("Ugyldig valg!");
                return;
            }

            Console.WriteLine("Skriv ett tall mellom 1 og 7 foor å få ukedagen:");
            Console.WriteLine("1. Mandag");
            Console.WriteLine("2. Tirsdag");
            Console.WriteLine("3. Onsdag");
            Console.WriteLine("4. Torsdag");
            Console.WriteLine("5. Fredag");
            Console.WriteLine("6. Lordag");
            Console.WriteLine("7. Sondag");

            string imputChoice = Console.ReadLine();

            if (imputChoice == "1")
            { Console.WriteLine("Mandag"); }
            else if (imputChoice == "2")
            { Console.WriteLine("Tirsdag"); }
            else if (imputChoice == "3")
            { Console.WriteLine("Onsdag"); }
            else if (imputChoice == "4")
            { Console.WriteLine("Torsdag"); }
            else if (imputChoice == "5")
            { Console.WriteLine("Fredag"); }
            else if (imputChoice == "6")
            { Console.WriteLine("Lordag"); }
            else if (imputChoice == "7")
            { Console.WriteLine("Sondag"); }
            else
            {
                Console.WriteLine("Ugyldig valg!");
            }

            Console.WriteLine("Vil du spille igjen? (Y/N)");
            string playAgain = Console.ReadLine();

            if (playAgain.ToUpper() == "Y")
            {
                Console.WriteLine("Flott! La oss spille!");
                continue; // restartuje grę od początku pętli
            }
            else if (playAgain.ToUpper() == "N")
            {
                Console.WriteLine("Ok, ha en fin dag!");
                break; // kończy pętlę i program
            }
            else
            {
                Console.WriteLine("Ugyldig valg!");
                break;
            }
        }
    }
}
