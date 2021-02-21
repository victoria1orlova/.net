using System;

namespace OperationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
        }

        static int Sum()
        {
            var n1 = 5;
            var n2 = 6;
            //Console.WriteLine($"{n1}+{n2}");
            return n1 + n2;
        }

        static int Sub(int n1, int n2)
        {
            //Console.WriteLine($"{n1}-{n2}");
            return n1 - n2;
        }

        static int Mul()
        {
            var n1 = 5;
            var n2 = 6;
            //Console.WriteLine($"{n1}*{n2}");
            return n1 * n2;
        }

        static int Div(int n1, int n2)
        {
            //Console.WriteLine($"{n1}/{n2}");
            return n1 / n2;
        }

        static void Display()
        {
            Console.WriteLine("a + b = {0}", Sum());
            Console.WriteLine("a - b = {0}", Sub(2, 3));
            Console.WriteLine("a * b = {0}", Mul());
            Console.WriteLine("a / b = {0}", Div(4, 7));
        }

    }
}
