using System;

namespace VariablesCS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 0;

            string fullName = "Josh Mann";

            DateTime today = DateTime.Now;


            Console.WriteLine($"Coffee cups/day = {numberOfCupsOfCoffee}");
            Console.WriteLine($"Name = {fullName}");
            Console.WriteLine($"Today = {today}");
            Console.WriteLine("Press any key to end");
            Console.ReadLine();

        }
    }
}
