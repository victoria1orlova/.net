using System;
using System.Runtime.InteropServices.ComTypes;

namespace DisplayingNumbersApp
{
    class Program
    {
        static void Main()
        {
            DisplayOddNumbers();
            DisplayHyphen();
            DisplayEvenNumbers();
        }
        static void DisplayHyphen()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.Write("_-");
            }

            Console.WriteLine();
        }
        static void DisplayEvenNumbers()
        {
            for (int b = 5; b < 16; b++)
            {
                if (b % 2 == 0)
                {
                    if (b == 14)
                    {
                        Console.Write(b + ".");
                    }
                    else
                    {
                        Console.Write(b + ", ");
                    }
                }
            }
        }

        static void DisplayOddNumbers()
        {
            for (int a = 1; a < 10; a++)
            {
                if (a % 2 != 0)
                {
                    if (a == 9)
                    {
                        Console.Write(a + ".");
                    }
                    else
                    {
                        Console.Write(a + ", ");
                    }

                }
            }
            Console.WriteLine();
        }
    }
}