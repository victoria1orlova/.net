namespace BorderApp
{
    internal class ExampleGenerator
    {
        public string[] Generate()
        {
            string[] result = new string[3];
            for (int v = 2; v < 3; v++)
            {
                for (int i = 2, index = 0; i < result.Length + 2; i++, index++)
                {
                    var obj = $"{v} * {i} = {v * i}";
                    result[index] = obj;
                    //Console.WriteLine(obj);
                }
            }

            return result;
        }
    }
}