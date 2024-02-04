class program
{
    static void Main()
    {
        using StreamReader reader = new(Console.OpenStandardInput());
        using StreamWriter writer = new(Console.OpenStandardOutput());
        string[] inputs = reader.ReadLine().Split(" ");
        int A = int.Parse(inputs[0]);
        int B = int.Parse(inputs[1]);
        int V = int.Parse(inputs[2]);

        int Time = (V - B - 1) / (A - B) + 1;
        writer.WriteLine(Time);
    }
}