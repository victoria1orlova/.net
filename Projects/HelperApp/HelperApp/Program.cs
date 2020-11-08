using System;

namespace HelperApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("                        Welcome \n                           to\n                        HelperApp!");

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
            Console.WriteLine("\n");

            // 4
            Console.WriteLine("++++++++++\n" +
                              "++++++++++\n" +
                              "++++++++++\n" +
                              "++++++++++\n");
            Console.WriteLine("\n");

            // 5
            Console.WriteLine("       +       \n" +
                              "      +++      \n" +
                              "     +++++     \n" +
                              "    +++++++    \n" +
                              "   +++++++++   \n" +
                              "  +++++++++++  \n" +
                              " +++++++++++++ \n");
            Console.WriteLine("\n");
            // 6
            Console.WriteLine("       +       \n" +
                              "      ***o     \n" +
                              "    0*****     \n" +
                              "    *******O   \n" +
                              "   *****6***   \n" +
                              " 8***********  \n" +
                              " ************* \n");
            Console.WriteLine("\n");
            // 7
            Console.WriteLine(" *           *       \n" +
                              "   *     *       *   \n" +
                              "        *    *       \n" +
                              "   *             *   \n" +
                              "       *     *     * \n" +
                              "    *      *         \n" +
                              "      *          *   \n");
            Console.WriteLine("\n");
            // 8
            Console.WriteLine("Autors: Atrtur Murmulyk & Mihail Orlov\n" +
                              "Writer program: Victoria Orlova _/(O w O)/-\n");
            Console.WriteLine("\n");
            Console.WriteLine("Exit");
            Console.ReadKey();
        }
    }
}