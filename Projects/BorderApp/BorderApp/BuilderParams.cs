using BorderApp.Model;

namespace BorderApp
{
    public class BuilderParams
    {
        public TableParam Build(string[] examples)
        {
            var length = GetLength(examples);
            return new TableParam
            {
                Length = length,
                Height = examples.Length
            };
        }

        private static int GetLength(string[] examples)
        {
            var length = 0;

            for (var i = 0; i < examples.Length; i++)
            {
                if (length < examples[i].Length)
                {
                    length = examples[i].Length;
                }
            }

            return length;
        }
    }
}