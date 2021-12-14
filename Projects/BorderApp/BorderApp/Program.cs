using System;
using BorderApp.Model;

namespace BorderApp
{
    class Program
    {
        static void Main()
        {
            ExampleGenerator exampleGenerator = new();
            string[] content = exampleGenerator.Generate();

            BuilderParams builderParams = new();
            TableParam tableParam = builderParams.Build(content);
            BorderBuilder borderBuilder = new();
            string table = borderBuilder.Build(content, tableParam);
            Console.WriteLine(table);
            Console.ReadKey();
        }
    }
}