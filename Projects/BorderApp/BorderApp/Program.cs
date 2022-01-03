using System;
using BorderApp.Model;

namespace BorderApp
{
    class Program
    {
        static void Main()
        {
            string[] examples = ExampleGenerator.Generate();

            BuilderParams builderParams = new();
            TableParam tableParam = builderParams.Build(examples);
            BorderBuilder borderBuilder = new();
            string table = borderBuilder.Build(examples, tableParam);
            Console.WriteLine(table);
            Console.ReadKey();
        }
    }
}