using System;

namespace StarLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-= STAR LINE =-");
            Console.Write("Write the number of asterisks '*' --> ");
            var userInput = Console.ReadLine();

            var lenght = int.Parse(userInput);
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}