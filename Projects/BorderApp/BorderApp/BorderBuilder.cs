using System;
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
            //╔
            stringBuilder.Append((char)9556);

            //═
            stringBuilder.Append((char)9552);

            // ╗
            stringBuilder.Append((char)9559 + "\n");

            // ║
            stringBuilder.Append((char)9553);

            stringBuilder.Append(content);

            // ║
            stringBuilder.Append((char)9553 + "\n");

            // ╚
            stringBuilder.Append((char)9562);

            //═
            stringBuilder.Append((char)9552);

            // ╝
            stringBuilder.Append((char)9565);

            return stringBuilder.ToString();
        }
    }
}