namespace BorderApp
{
    internal class ExampleGenerator
    {
        public string[] Generate()
        {
            string[] result = new string[8];
            for (int v = 2; v < 3; v++)
            {
                for (int i = 2, index = 0; i < result.Length + 2; i++, index++)
                {
                    if (i < 5)
                    {
                        var space = " ";
                        var obj = $"{v} * {i} = {v * i}{space}";
                        result[index] = obj;
                    }
                    else
                    {
                        var space = " ";
                        var obj = $"{v} * {i} = {v * i}";
                        result[index] = obj;
                    }
                    //Console.WriteLine(obj);
                }
            }

            return result;
        }
    }
}