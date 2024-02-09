class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            long N = long.Parse(reader.ReadLine());
            writer.WriteLine((N-1)* N / 2);
            writer.WriteLine(2);
        }
    }
}
