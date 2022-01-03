using BorderApp.Model;

namespace BorderApp
{
    public class BuilderParams
    {
        public TableParam Build(string[] examples)
        {
            return new TableParam
            {
                Length = examples[0].Length,
                Height = examples.Length
            };
        }
    }
}