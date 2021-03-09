using System;

namespace MethodTest
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter number 'a': ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 'b': ");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {Sum(a,b)}");
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
