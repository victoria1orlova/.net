using System;

namespace MultiplicationTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
