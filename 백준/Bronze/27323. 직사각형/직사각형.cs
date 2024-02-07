class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            int A = int.Parse(reader.ReadLine());
            int B = int.Parse(reader.ReadLine());

            writer.WriteLine(A * B);
        }
    }
}