using System.Text;

namespace BorderApp
{
    internal class BorderBuilder
    {
        private readonly BuilderParams _builderParams;

        public BorderBuilder(BuilderParams builderParams)
        {
            _builderParams = builderParams;
        }

        public string Build(string content)
        {
            var stringBuilder = new StringBuilder();

            BuildHead(stringBuilder);
            BuildBody(stringBuilder, content);
            BuildFooter(stringBuilder);
            
            return stringBuilder.ToString();
        }

        private void BuildFooter(StringBuilder stringBuilder)
        {
            // ╚
            stringBuilder.Append((char)9562);

            for (int i = 0; i < _builderParams.Length; i++)
            {
                //═
                stringBuilder.Append((char)9552);
            }
            
            // ╝
            stringBuilder.Append((char)9565);
        }

        private void BuildBody(StringBuilder stringBuilder, string content)
        {
            // ║
            stringBuilder.Append((char)9553);

            stringBuilder.Append(content);

            // ║
            stringBuilder.Append((char)9553 + "\n");
        }

        private void BuildHead(StringBuilder stringBuilder)
        {
            //╔
            stringBuilder.Append((char)9556);

            for (int i = 0; i < _builderParams.Length; i++)
            {
                //═
                stringBuilder.Append((char)9552);
            }

            // ╗
            stringBuilder.Append((char)9559 + "\n");
        }
    }
}