using System;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 2, 7, 5, 2, 12 };

            int sum = 0;
            int sub = 0;

            foreach (var i in array)
            {
                sum = sum + i;
            }

            sub = array[0] - array[1] - array[2] - array[3] - array[4];

            Console.WriteLine(sum);
            Console.WriteLine(sub);
        }
    }
}