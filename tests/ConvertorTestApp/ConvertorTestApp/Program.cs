using System;

namespace ConvertorTestApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter course hrn OR dol:");
            string course = Console.ReadLine();

            Console.Write("Enter NUMBER of dollar course: ");

            int money = Int32.Parse(Console.ReadLine());
            int result = 0;

            if (course == "hrn")
            {
                ConvertHrn(money, ref result);
            }
            else
            {
                ConvertDol(money, ref result);
            }

            Console.WriteLine(result);
        }

        static void ConvertHrn(int money, ref int result)
        {
            result = money / 28;
        }
        static void ConvertDol(int money, ref int result)
        {
            result = money * 28;
        }
    }
}