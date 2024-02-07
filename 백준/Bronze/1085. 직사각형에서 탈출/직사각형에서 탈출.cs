class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            string[] inputs = reader.ReadLine().Split(" ");
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int w = int.Parse(inputs[2]);
            int h = int.Parse(inputs[3]);
            int result = 0;
            if(x > w || y > h)  // 직사각형 외부
            {
                result = (x > w) ? x - w : y - h;
            }
            else // 직사각형 내부
            {
                result = Math.Min(Math.Min(x, w - x), Math.Min(y, h - y));
            }
            writer.WriteLine(result);
        }
    }
}
