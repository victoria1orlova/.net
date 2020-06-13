using System;

namespace LiteralsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical literals");
            Console.WriteLine($"{true.GetType()}: {true}");
            Console.WriteLine($"{false.GetType()}{false}");
            Console.WriteLine("Integer literals");
            Console.WriteLine($"{(-11).GetType()}: {-11}");
            Console.WriteLine($"{(5).GetType()}: {5}");
            Console.WriteLine($"{(505).GetType()}: {505}");
            Console.WriteLine($"{(0b11).GetType()}: {0b11}");        // 3
            Console.WriteLine($"{(0b1011).GetType()}: {0b1011}");      // 11
            Console.WriteLine($"{(0b100001).GetType()}: {0b100001}");    // 33
            Console.WriteLine($"{(0x0A).GetType()}: {0x0A}");    // 10
            Console.WriteLine($"{(0xFF).GetType()}: {0xFF}");    // 255
            Console.WriteLine($"{(0xA1).GetType()}: {0xA1}");    // 161
            Console.WriteLine("Real literals");
            Console.WriteLine(3.2e3);   // по сути равно 3.2 * 10<sup>3</sup> = 3200
            Console.WriteLine(1.2E-1);  // равно 1.2 * 10<sup>-1</sup> = 0.12
            Console.WriteLine($"{(1.1).GetType()}: {1.1}");
            Console.WriteLine("Character literals");
            Console.WriteLine('\x78');    // x
            Console.WriteLine('\x5A');    // Z
            Console.WriteLine('\u0420');    // Р
            Console.WriteLine('\u0421');    // С
            Console.WriteLine("String literals");
            Console.WriteLine("hello");
            Console.WriteLine("hello everyone");
            Console.WriteLine("Company \"LUXOFT\"");
            Console.WriteLine("I love my father, mother and of all \nvery much");
            //null представляет ссылку, которая не указывает ни на какой объект. То есть по сути отсутствие значения.
            Console.ReadKey();
        }
    }
}