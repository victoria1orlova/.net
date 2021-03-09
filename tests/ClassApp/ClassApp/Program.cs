using System;

namespace ClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 8;
            int n2 = 4;
            Rectangle.Area(n1, 5);
            Rectangle.Perimeter(3, n2);
        }
    }

    class Rectangle
    {
        public static void Area(int a, int b)
        {
            //int a = 3;
            //int b = 5;
            int result = a * b;
            Console.WriteLine($"{a} * {b} = {result}");
        }

         public static void Perimeter(int a, int b)
        {
            //int a = 3;
            //int b = 5;
            int result = (a + b) * 2;
            Console.WriteLine($"({a} + {b}) * 2 = {result}");
        }
    }
}
