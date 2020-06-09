using System;

namespace LiteralsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{true.GetType()}: {true}");
            Console.WriteLine($"{false.GetType()}{false}");

            Console.WriteLine($"{(-11).GetType()}: {-11}");
            Console.WriteLine($"{(5).GetType()}: {5}");
            Console.WriteLine($"{(505).GetType()}: {505}");
            Console.WriteLine($"{(0b11).GetType()}: {0b11}");        // 3
            Console.WriteLine($"{(0b1011).GetType()}: {0b1011}");      // 11
            Console.WriteLine($"{(0b100001).GetType()}: {0b100001}");    // 33
            Console.WriteLine($"{(0x0A).GetType()}: {0x0A}");    // 10
            Console.WriteLine($"{(0xFF).GetType()}: {0xFF}");    // 255
            Console.WriteLine($"{(0xA1).GetType()}: {0xA1}");    // 161

            Console.WriteLine($"{(1.1).GetType()}: {1.1}");

            Console.ReadKey();
        }
    }
}
