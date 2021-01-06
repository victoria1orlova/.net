using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MathApp!");
            Console.WriteLine("\nWrite any two numbers)");
            Console.Write("Enter here: ");
            string numbers = Console.ReadLine();
            Console.WriteLine($"Your numbers: {numbers}!");

            Console.WriteLine("\nWhat arithmetic operation do you want to perform?)");
            Console.Write("Write arithmetic operation here: ");
            string ArithmeticOperation = Console.ReadLine();
            Console.WriteLine($"{ArithmeticOperation}=4");

            Console.WriteLine($"\n({numbers})-({ArithmeticOperation})=6");
            Console.Write("Am I right?");
            Console.ReadLine();
            Console.WriteLine($"\nOkay");
            Console.ReadKey();
        }
    }
}
