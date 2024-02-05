class program
{
    static void Main()
    {
        using StreamReader reader = new(Console.OpenStandardInput());
        using StreamWriter writer = new(Console.OpenStandardOutput());
        while (true)
        {
            string input = reader.ReadLine();
            int Num = (input != "") ? int.Parse(input) : 0;
            if (Num == -1) break;

            List<int> MeasureList = new();
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0) MeasureList.Add(i);
            }
            int MeasureSum = MeasureList.Sum() - Num;
            if(Num == MeasureSum)
            {
                writer.Write($"{Num} = ");
                for(int i = 0; i < MeasureList.Count-1; i++)
                {
                    writer.Write($"{MeasureList[i]}{((i < MeasureList.Count -2 )? " + " : "")}");
                }
                writer.WriteLine();
            }
            else
            {
                writer.WriteLine($"{Num} is NOT perfect.");
            }
            writer.Flush();
        }
    }
}