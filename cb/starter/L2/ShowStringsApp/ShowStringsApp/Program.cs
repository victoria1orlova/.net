using System;

namespace ShowStringsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "\nMyString 1";
            string t = "\tMyString 2";
            string a = "\aMyString 3";
     
            Console.WriteLine("n: " + n);
            Console.WriteLine("t: " + t);
            Console.WriteLine("a: " + a);

            Console.ReadKey();
        }
    }
}
