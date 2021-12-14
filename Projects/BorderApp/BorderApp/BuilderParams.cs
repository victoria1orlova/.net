using BorderApp.Model;

namespace BorderApp
{
    internal class BuilderParams
    {
        public TableParam Build(string content)
        {
            return new TableParam
            {
                Length = content.Length
            };
        }
    }
}