using System;

namespace TechElevator.LearnToCode.CSharp.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetingText = "Hello Variables";

            Console.WriteLine(greetingText);

            Console.WriteLine();

            // Integer Variables
            int num1 = 2;
            int num2 = 2;
            int result = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + result);

            // Get User Input
            Console.WriteLine("Enter a Number");

            string userNumberText = Console.ReadLine();
            int userNumber = int.Parse(userNumberText);

            Console.WriteLine("You entered: " + userNumber);
        }
    }
}
