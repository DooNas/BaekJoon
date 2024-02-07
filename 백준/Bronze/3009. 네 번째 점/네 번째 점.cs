class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            List<List<int>> PosList = new();
            for(int i = 0; i < 3; i++)
            {
                string[] inputs = reader.ReadLine().Split(" ");
                List<int> Pos = new() { int.Parse(inputs[0]), int.Parse(inputs[1]) };
                PosList.Add( Pos );
            }
            int x = PosList[0][0] ^ PosList[1][0] ^ PosList[2][0];
            int y = PosList[0][1] ^ PosList[1][1] ^ PosList[2][1];
            writer.WriteLine($"{x} {y}");
        }
    }
}
