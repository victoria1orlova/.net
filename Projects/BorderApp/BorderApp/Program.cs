using System;

namespace BorderApp
{
    class Program
    {
        static void Main()
        {
            // var content = new[]{"=^_^=", "=^_^="};
            var content = "=^_^=";
            var builderParams = new BuilderParams(content);
            var borderBuilder = new BorderBuilder(builderParams);
            string table = borderBuilder.Build(content);
            Console.WriteLine(table);
            Console.ReadKey();
        }
    }
}