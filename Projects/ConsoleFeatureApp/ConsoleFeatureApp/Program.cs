using System;
using System.Threading;

namespace StarLineApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write your id e-mail");
            var fakeId = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("wait...");
            var fakeWait = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                for (var i = 2; i > 0; i++)
                {
                    Console.Write("-");

                    for (int j = 2; j > 0; j++)
                    {
                        Console.Write("/");
                    }
                }


            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("For EXIT press 'Q'");
            }
        }
    }
}