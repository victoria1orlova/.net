using System;

namespace OptionRefApp
{
    class Program
    {
        static void Main()
        {
            int priceMilka = 22; //-4
            int priceRoshen = 40; //-5
            int priceKontik = 18; //-11

            ChangePrice(ref priceMilka, ref priceRoshen, ref priceKontik);

            Console.WriteLine($"Price Milka:{priceMilka}");
            Console.WriteLine($"Price Roshen:{priceRoshen}");
            Console.WriteLine($"Price Kontik:{priceKontik}");
        }

        static void ChangePrice(ref int priceMilka, ref int priceRoshen, ref int priceKontik)
        {
            priceMilka = 18;
            priceRoshen = 35;
            priceKontik = 7;
        }
    }
}
