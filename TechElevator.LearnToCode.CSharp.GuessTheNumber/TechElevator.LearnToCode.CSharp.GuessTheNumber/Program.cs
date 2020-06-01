using System;

namespace TechElevator.LearnToCode.CSharp.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get User Input
            Console.WriteLine("Enter a Number");

            string userNumberText = Console.ReadLine();
            int userNumber = int.Parse(userNumberText);

            Console.WriteLine("You entered: " + userNumber);
        }
    }
}
