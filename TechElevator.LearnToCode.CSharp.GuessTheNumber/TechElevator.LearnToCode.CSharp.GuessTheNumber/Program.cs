using System;

namespace TechElevator.LearnToCode.CSharp.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            int userNumber = 0;

            while (userNumber != secretNumber)
            {
                // Get User Input
                Console.WriteLine("Enter a Number");

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
            }
        }
    }
}
