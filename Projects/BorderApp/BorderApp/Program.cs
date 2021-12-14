using System;
using BorderApp.Model;

namespace BorderApp
{
    class Program
    {
        static void Main()
        {
            // var content = new[]{"=^_^=", "=^_^="};
            var content = "=^_^=";
            var builderParams = new BuilderParams();
            TableParam tableParam = builderParams.Build(content);
            var borderBuilder = new BorderBuilder();
            string table = borderBuilder.Build(content, tableParam);
            Console.WriteLine(table);
            Console.ReadKey();
        }
    }
}