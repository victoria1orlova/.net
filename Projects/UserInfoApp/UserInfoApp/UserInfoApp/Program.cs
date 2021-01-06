using System;

namespace UserInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UserInfoApp!");
            Console.WriteLine("\nWhat's your name?)");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}!");

            Console.WriteLine("\nWhat's your second name?)");
            Console.Write("Enter your second name: ");
            string secondName = Console.ReadLine();
            Console.WriteLine($"{name} {secondName}!");

            Console.WriteLine("\nHow old are you?)");
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Your age: {age}!");
            Console.WriteLine($"\nYour name: {name}\nYour second name: {secondName}\nYour age: {age}");
            Console.ReadKey();
        }
    }
}