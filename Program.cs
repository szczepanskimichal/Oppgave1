
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Vil du spille? (Y/N)");
            string playGame = Console.ReadLine();

            /*
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
            */

            switch(playGame.ToUpper())
            {
                case "Y":
                    Console.WriteLine("Flott! La oss spille!");
                    break;
                case "N":
                    Console.WriteLine("Ok, ha en fin dag!");
                    return;
                default:
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

            /*
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
            */
            int dayNumber;

            bool isValidNumber = int.TryParse(imputChoice, out dayNumber); // Konverterer strengen til et heltall og sjekker om det er gyldig tall
            if (!isValidNumber)
            {
                Console.WriteLine("Det er ikke et gyldig tall! Vennligst skriv inn et tall mellom 1 og 7.");
                continue; // Går tilbake til starten av løkken!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }

            // 

            /*int dayNumber = Convert.ToInt32(imputChoice); // Konverterer strengen til et heltall*/

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lordag");
                    break;
                case 7:
                    Console.WriteLine("Sondag");
                    break;
                default:
                    Console.WriteLine("Ugyldig valg!Tall mellom 1 og 7!!!");
                    break;
            }

            if (!AskToPlayAgain())
            {
                Console.WriteLine("Ok, ha en fin dag!");
                break; // avslutter programmet
            }
            break;
        }
    }

/*Jeg skal også skrive en metode for å spille spillet på nytt snart, fordi denne koden ikke er veldig strukturert for meg*/
    static bool AskToPlayAgain()
    {
        Console.WriteLine("Vil du spille igjen? (Y/N)");
        string playAgain = Console.ReadLine();
        if (playAgain.ToUpper() == "Y")
        {
            return true;
        }
        else if (playAgain.ToUpper() == "N")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Ugyldig valg!");
            return false; // Avslutter programmet hvis det er et ugyldig valg
        }
    }


}
