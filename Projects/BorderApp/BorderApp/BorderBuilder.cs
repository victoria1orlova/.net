using System.Text;
using BorderApp.Model;

namespace BorderApp
{
    public class BorderBuilder
    {
        public string Build(string[] content, TableParam tableParam)
        {
            var stringBuilder = new StringBuilder();

            BuildHead(stringBuilder, tableParam);

            for (var i = 0; i < tableParam.Height; i++)
            {
                BuildBody(stringBuilder, content[i], tableParam);
            }

            BuildFooter(stringBuilder, tableParam);
            
            return stringBuilder.ToString();
        }

        private void BuildHead(StringBuilder stringBuilder, TableParam tableParam)
        {
            //╔
            stringBuilder.Append((char)9556);

            for (int i = 0; i < tableParam.Length; i++)
            {
                //═
                stringBuilder.Append((char)9552);
            }

            // ╗
            stringBuilder.Append((char)9559 + "\n");
        }

        private void BuildFooter(StringBuilder stringBuilder, TableParam tableParam)
        {
            // ╚
            stringBuilder.Append((char)9562);

            for (int i = 0; i < tableParam.Length; i++)
            {
                //═
                stringBuilder.Append((char)9552);
            }
            
            // ╝
            stringBuilder.Append((char)9565);
        }

        private void BuildBody(StringBuilder stringBuilder, string example, TableParam tableParam)
        {
            // ║
            stringBuilder.Append((char)9553);

            stringBuilder.Append(example);

            // ║
            stringBuilder.Append((char)9553 + "\n");
        }
    }
}