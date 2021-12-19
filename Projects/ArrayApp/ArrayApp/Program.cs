using System;

namespace ArrayApp
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter number: ");
            string numA = Console.ReadLine();

            int a = int.Parse(numA);

            Console.WriteLine("We got just one number from you. Type here second numb: ");
            string numB = Console.ReadLine();

            int b = int.Parse(numB);

            var exp = $"{a} * {b} = {a * b}";
            var value = $"We multiplied it: \n{exp}";
            Console.WriteLine(value);
        }

    }
}
