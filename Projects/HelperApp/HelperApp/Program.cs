using System;

namespace HelperApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-=Welcome \n     to\n    HelperApp!");

            // 1
            Console.WriteLine("+");
            Console.WriteLine("\n");

            // 2.1
            Console.WriteLine("++++++++++");
            Console.WriteLine("\n");

            // 2.2
            for (int i = 0; i < 20; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine("\n");

            // 3
            Console.WriteLine("++++\n" +
                              "++++\n" +
                              "++++\n" +
                              "++++\n");

            Console.WriteLine("Exit");
            Console.ReadKey();
        }
    }
}