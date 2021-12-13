namespace BorderApp
{
    internal class BuilderParams
    {
        public BuilderParams(string content)
        {
            Length = content.Length;
        }

        public int Length { get; set; }
    }
}