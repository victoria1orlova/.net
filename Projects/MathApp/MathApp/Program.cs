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
            double b = double.Parse(numB);
            
            Console.WriteLine($"a={a}  b={b}");

            Console.WriteLine($"{a}+{b}={a + b}");
        }
    }
}
