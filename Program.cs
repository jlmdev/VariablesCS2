using System;

namespace VariablesCS2
{
    class Program
    {
        static string InputName(string enteredName)
        {
            if (enteredName == "Alice")
            {
                return $"Hi, {enteredName}! Welcome Back!";

            }
            else
            {
                return $"Hello, {enteredName}.";
            }
        }
        static void Main(string[] args)
        {
            // Number of Cups of Coffee
            int numberOfCupsOfCoffee = 4;
            Console.WriteLine(numberOfCupsOfCoffee);

            // Full Name
            string fullName = "Josh Mann";
            Console.WriteLine(fullName);

            // Today
            string today = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(today);

            // Get entered name and return a response
            Console.Write("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine(InputName(userName));
        }
    }
}
