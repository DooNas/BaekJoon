class program
{
    static void Main()
    {
        using StreamReader reader = new(Console.OpenStandardInput());
        using StreamWriter writer = new(Console.OpenStandardOutput());
        int tryCount = int.Parse(reader.ReadLine());
        writer.WriteLine((int)Math.Pow(Math.Pow(2, tryCount) + 1, 2));
    }
}