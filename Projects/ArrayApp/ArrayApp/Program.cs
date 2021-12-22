using System;

namespace ArrayApp
{
    class Program
    {
        static void Main()
        { 
            // ShowExample();
            RandomArray();
        }

        private static void RandomArray()
        {
            int[] arr = new int[10];

            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }

            foreach (var t in arr)
            {
                Console.WriteLine(t);
            }
        }

        private static void ShowExample()
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