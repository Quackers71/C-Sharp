using System;

namespace NumberGuesser 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {

                //int correctNumber = 7;

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("\nGuess a number between 1 and 10? ");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "Well done, you guessed the correct number...");

                ConsoleKey response;
                do
                {
                    Console.WriteLine("\nPlay Again? [Y or N] ");
                    response = Console.ReadKey(false).Key;

                    if (response == ConsoleKey.Y)
                    {
                        continue;
                    }
                    else if (response == ConsoleKey.N)
                    {
                        return;
                    }
                 }
                 while (response != ConsoleKey.Y && response != ConsoleKey.N);
            }

            /*Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();*/

        }

        static void GetAppInfo()
        {
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Quackers";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
        
        static void GreetUser()
        {
            Console.Write("What is your name? ");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game.", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}