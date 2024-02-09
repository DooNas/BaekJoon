class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            string[] inputs = reader.ReadLine().Split(" ");
            int a1 = int.Parse(inputs[0]);
            int a2 = int.Parse(inputs[1]);
            int c = int.Parse(reader.ReadLine());
            int n = int.Parse(reader.ReadLine());

            int F = a1 * n + a2;
            int G = c * n;
            writer.WriteLine((F <= G && a1 <= c) ? 1 : 0);
        }
    }
}