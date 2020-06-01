using System;

namespace TechElevator.LearnToCode.CSharp.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int secretNumber = randomizer.Next(1, 100);
            int userNumber = 0;
            int numGuesses = 0;

            while (userNumber != secretNumber)
            {
                // Get User Input
                Console.WriteLine("Enter a Number between 1 and 100");

                string userNumberText = Console.ReadLine();
                userNumber = int.Parse(userNumberText);

                Console.WriteLine("You entered: " + userNumber);

                if (userNumber == secretNumber)
                {
                    Console.WriteLine("That was the number I was thinking of! Amazing!");
                }
                else if (userNumber < secretNumber)
                {
                    Console.WriteLine("Nope. The number I'm thinking of is greater than that");
                }
                else
                {
                    Console.WriteLine("Nope. The number I'm thinking of is less than that");
                }

                Console.WriteLine();

                numGuesses++;
            }

            Console.WriteLine("You guessed the number after " + numGuesses + " guesses! Good job!");
        }
    }
}
