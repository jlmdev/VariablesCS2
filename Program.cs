using System;

namespace VariablesCS2
{
    class Program
    {
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
        }
    }
}
