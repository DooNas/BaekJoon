class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            string[] inputs = reader.ReadLine().Split(" ");
            int[] eq = Array.ConvertAll(inputs, int.Parse); // a,b,c,d,e,f
            int a = eq[0];
            int b = eq[1];
            int c = eq[2];
            int d = eq[3];
            int e = eq[4];
            int f = eq[5];
            for(int x = -999; x <= 999 ; x++)
            {
                for(int y = -999; y <= 999; y++)
                {
                    if((a * x + b * y) == c && (d * x + e * y) == f)
                    {
                        writer.WriteLine($"{x} {y}");
                        return;
                    }
                }
            }
        }
    }
}
