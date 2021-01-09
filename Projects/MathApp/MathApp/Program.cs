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
            var a = double.Parse(numA);

            Console.Write("Enter here number 'b': ");
            string numB = Console.ReadLine();
            var b = double.Parse(numB);

            Console.Write("Enter math operation: ");

            string o = Console.ReadLine();
            var c = 0.0;
            if (o == "+")
            {
                c = a + b;
            }
            else if (o == "-")
            {
                c = a - b;
            }
            if (o == "*")
            {
                c = a * b;
            }
            else if (o == "/")
            {
                c = a / b;
            }
            else
            {
                Console.WriteLine($"Error! Not correct math operation");
            }

            Console.WriteLine($"{a}{o}{b}={c}");

            if (a > b)
            {
                Console.WriteLine($"Number {a} biggest than number {b}");
            }
            else if(b > a)
            {
                Console.WriteLine($"Number {b} biggest than number {a}");
            }
            else
            {
                Console.WriteLine($"Number {a} equal to number {b}");
            }
        }
    }
}
