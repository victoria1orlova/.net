using System;
using System.Threading;

namespace StarLineApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-= STAR LINE =-");
            Console.Write("Write the number of asterisks '*' --> ");
            var l = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.Write("Write the number of spaces ' ' --> ");
            var spaceLength = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                if (l > 1)
                {
                for (var i = 0; i < l; i++)
                {
                    Console.Write("*");

                    for (int j = 0; j < spaceLength; j++)
                    {
                        Console.Write(" ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error! Please change your number to biggest number");
            }
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("For EXIT press 'Q'");

            while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}