using System;
using System.Threading;

namespace StarLineApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-= STAR LINE =-");
            int l;
            do
            {
                Console.Write("Write the number of asterisks '*' --> ");
            } while (!int.TryParse(Console.ReadLine(), out l));

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



            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("For EXIT press 'Q'");
            }
        }
    }
}