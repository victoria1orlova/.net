using System;

namespace StarLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-= STAR LINE =-");
            Console.Write("Write the number of asterisks '*' --> ");
            int userInput = int.Parse(Console.ReadLine());

            int count = 0;
            while (count < userInput)
            {
                count++;
                Console.WriteLine("*");
            }
            //var lenght = int.Parse(userInput);
            //for (int i = 0; i < lenght; i++)
            //{
            //    Console.WriteLine("*");
            //}
        }
    }
}