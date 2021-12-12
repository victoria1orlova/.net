using System;

namespace MultiplicationTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //╔
            Console.Write($"{(char)9556}");
            //═
            for (int l = 0; l < 44; l++)
            {
                Console.Write($"{(char)9552}");
            }

            // ╗
            Console.Write($"{(char)9559}");
            Console.Write("\n");

            for (int i = 0; i < 15; i++)
            {
                // ║
                
            }
            
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"{(char)9553}");

                for (int d = 0; d < 44; d++)
                {
                    Console.Write(" ");
                }
                // ║
                Console.WriteLine($"{(char)9553}");
            }

            // ╚
            Console.Write($"{(char)9562}");
            //═
            for (int l = 0; l < 44; l++)
            {
                Console.Write($"{(char)9552}");
            }

            // ╝
            Console.Write($"{(char)9565}");

            return;

            for (int a = 2; a < 10; a++)
            {
                for (int i = 2; i < 10; i++)
                {
                    Console.WriteLine($"{a} * {i} = {a * i}");
                }
            }
        }
    }
}
