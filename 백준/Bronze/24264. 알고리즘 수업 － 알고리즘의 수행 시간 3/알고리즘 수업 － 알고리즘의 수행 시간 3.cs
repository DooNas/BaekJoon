class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            long input = long.Parse(reader.ReadLine());
            writer.WriteLine(input*input);
            writer.WriteLine(2);
        }
    }
}