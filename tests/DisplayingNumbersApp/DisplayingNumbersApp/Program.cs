using System;

namespace DisplayingNumbersApp
{
    class Program
    {
        static void Main()
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

            Console.WriteLine();
            

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
        }
    }
}
