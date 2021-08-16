using System;

namespace PairedApp
{
    class Program
    {
        static void Main()
        {
            var mathHelper = new MathHelper();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("                           -= The program for determining the pairing of numbers =-");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEnter number: ");
            var str = Console.ReadLine() ?? "0";

            var num = int.Parse(str);

            var result = mathHelper.IsEvenNumber(num);
            
            Console.ForegroundColor = ConsoleColor.Blue;

            var message = result 
                ? "Number is even"
                : "Number isn't even";
            Console.WriteLine(message);

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}