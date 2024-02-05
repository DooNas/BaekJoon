class program
{
    static void Main()
    {
        using StreamReader reader = new(Console.OpenStandardInput());
        using StreamWriter writer = new(Console.OpenStandardOutput());
        string[] inputs = reader.ReadLine().Split(" ");
        int Num = (inputs[0] != "") ? int.Parse(inputs[0]) : 0;
        int Stay = (inputs[1] != "") ? int.Parse(inputs[1]) : 0;

        List<int> MeasureList = new();
        for(int i = 1; i <= Num; i++)
        {
            if(Num % i == 0) MeasureList.Add(i);
        }
        int result = (Stay <= MeasureList.Count) ? MeasureList[Stay-1] : 0;
        writer.WriteLine(result);
    }
}