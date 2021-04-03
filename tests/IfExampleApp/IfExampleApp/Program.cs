using System;

namespace IfExampleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! How old are you?");
            int age = Int32.Parse(Console.ReadLine());

            AgeCheck(age);
        }

        static void AgeCheck(int age)
        {
            if (age <= 10)
            {
                Console.WriteLine("You are too young for this ride!");
            }
            else
            {
                Console.WriteLine("Welcome to trampolines!)");
            }
        }
    }
}
