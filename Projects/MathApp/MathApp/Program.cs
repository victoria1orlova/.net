using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MathApp!");

            Console.Write("Enter here number 'a': ");
            string numA = Console.ReadLine();
            int a = int.Parse(numA);

            Console.Write("Enter here number 'b': ");
            string numB = Console.ReadLine();
            int b = int.Parse(numB);

            Console.WriteLine($"a={a}  b={b}");
            Console.WriteLine($"{a}+{b}={a + b}");

            Console.WriteLine($"{a}-{b}={a - b}");

            Console.WriteLine($"{a}x{b}={a * b}");

            Console.WriteLine($"{a}÷{b}={a / b}");

            if (a > b)
            {
                Console.WriteLine($"Number {a} biggest than number {b}");
            }
            else
            {
                Console.WriteLine($"Number {b} biggest than number {a}");
            }
        }
    }
}
