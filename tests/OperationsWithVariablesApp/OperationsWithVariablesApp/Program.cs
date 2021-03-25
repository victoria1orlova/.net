using System;
using System.Diagnostics.CodeAnalysis;

namespace OperationsWithVariablesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first variable -> ");
            int firstV = int.Parse(Console.ReadLine());

            Console.Write("Enter second variable -> ");
            int secondV = Int32.Parse(Console.ReadLine());

            Console.Write("Enter third variable -> ");
            int thirdV = Int32.Parse(Console.ReadLine());

            var operations = new ArithmeticOperations();
            operations.Average(firstV, secondV, thirdV);

            Console.WriteLine(operations.Sum(firstV, secondV, thirdV));
            Console.WriteLine(operations.Average(firstV, secondV, thirdV));

            var tell = new Tell();
            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            tell.Greeting(name);
        }
        class ArithmeticOperations
        {
            public int Sum(int firstV, int secondV, int thirdV)
            {
                return firstV + secondV + thirdV;
            }
            public int Average(int firstV, int secondV, int thirdV)
            {
                return Sum(firstV, secondV, thirdV) / 3;
            }
        }

        class Tell
        {
            public void Greeting(string yourName)
            {
                Console.WriteLine($"Hi,{yourName}:>");
            }
        }
    }
}
