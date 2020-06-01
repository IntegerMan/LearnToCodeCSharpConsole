using System;

namespace TechElevator.LearnToCode.CSharp.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get a random number as the secret number
            Random randomizer = new Random();
            int secretNumber = randomizer.Next(1, 100);

            // Set up variables we'll use in the loop
            int userNumber = 0;
            int numGuesses = 0;

            // Allow the user to continue guessing until they find the number
            while (userNumber != secretNumber)
            {
                // Get User Input
                Console.WriteLine("Enter a Number between 1 and 100");

                string userNumberText = Console.ReadLine();
                userNumber = int.Parse(userNumberText);

                Console.WriteLine("You entered: " + userNumber);

                // Check to see if the user guessed the number
                if (userNumber == secretNumber) // Exactly the number
                {
                    Console.WriteLine("That was the number I was thinking of! Amazing!");
                }
                else if (userNumber < secretNumber) // Guessed lower than the number
                {
                    Console.WriteLine("Nope. The number I'm thinking of is greater than that");
                }
                else // Since not lower and not exact, must be greater than the number
                {
                    Console.WriteLine("Nope. The number I'm thinking of is less than that");
                }

                Console.WriteLine();

                // Increase the number of guesses the user has made
                numGuesses++;
            }

            // Tell the user how they did
            Console.WriteLine("You guessed the number after " + numGuesses + " guesses! Good job!");

            // Once the program reaches the next line, the console application will stop
        }
    }
}
