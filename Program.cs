using System;

namespace VariablesCS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 0;

            string fullName = "Josh Mann";

            var today = DateTime.Now.ToString("dd/MM/yyyy");


            // Get input from user
            Console.WriteLine("What's your name?");
            fullName = Console.ReadLine();

            Console.Write("Enter first number");
            string firstNumberString = Console.ReadLine();
            Console.Write("Enter second number");
            string secondNumberString = Console.ReadLine();

            Console.WriteLine($"Coffee cups/day = {numberOfCupsOfCoffee}");
            Console.WriteLine($"Name = {fullName}");
            Console.WriteLine($"Today = {today}");
            Console.WriteLine("Press any key to end");
            Console.ReadLine();

        }
    }
}
