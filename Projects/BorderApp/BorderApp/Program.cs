using System;

namespace BorderApp
{
    class Program
    {
        static void Main()
        {
            var builderParams = new BuilderParams();
            var borderBuilder = new BorderBuilder(builderParams);
            var content = "+";
            string table = borderBuilder.Build(content);
            Console.WriteLine(table);
            Console.ReadKey();
        }
    }
}