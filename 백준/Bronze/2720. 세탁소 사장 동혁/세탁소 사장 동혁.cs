class program
{
    static void Main()
    {
        using StreamReader reader = new(Console.OpenStandardInput());
        using StreamWriter writer = new(Console.OpenStandardOutput());
        int tryCount = int.Parse(reader.ReadLine());

        int[] list = { 25, 10, 5, 1 }; // Qcoin, Dcoin, Ncoin, Pcoin
        int[,] CoinList = new int[tryCount, 4];
        for (int i = 0; i < tryCount; i++)
        {
            int input = int.Parse(reader.ReadLine());
            if (input > 500) continue;
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    CoinList[i, j] = input / list[j];
                    input %= list[j];
                }
            }
        }
        for (int i = 0; i < tryCount; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                writer.Write($"{CoinList[i, j]} ");
            }
            writer.WriteLine();
        }
    }
}