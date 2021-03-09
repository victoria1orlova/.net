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
            double result = 0.0;

            switch (course)
            {
                case "hrn":
                    ConvertHrn(money, ref result);
                    break;
                case "dol":
                    ConvertDol(money, ref result);
                    break;
            }

            Console.WriteLine(result);
        }

        static void ConvertHrn(int money, ref double result)
        {
            result = money / 28.0;
        }
        static void ConvertDol(int money, ref double result)
        {
            result = money * 28.0;
        }
    }
}