using System;

namespace OptionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int area;
            int perimetr;
            GetData(3, 4, out area, out perimetr);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Perimetr : " + perimetr);

            Console.ReadKey();
        }
        static void GetData(int a, int b, out int area, out int perim)
        {
            area = a * b;
            perim = (a + b) * 2;
        }
    }
}