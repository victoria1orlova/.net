using System;

namespace OptionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData(3, 4, out var perimeterSquare, out var perimeterRectangle);

            Console.WriteLine("Perimeter rectangle : " + perimeterRectangle);
            Console.WriteLine("Perimeter square : " + perimeterSquare);

            Console.ReadKey();
        }
        static void GetData(int a, int b, out int perimeterRectangle, out int perimeterSquare)
        {
            perimeterRectangle = (a + b) * 2;
            perimeterSquare = a * 4;
        }
    }
}