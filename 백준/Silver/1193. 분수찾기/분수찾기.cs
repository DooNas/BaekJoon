class program
{
    static void Main()
    {
        using StreamReader reader = new(Console.OpenStandardInput());
        using StreamWriter writer = new(Console.OpenStandardOutput());
        int input = int.Parse(reader.ReadLine());

        int LineLevel = 0; // 몇번째 대각선
        int LineIndex = 0; // 대각선의 몇번째
        int LineSum = 0;
        while(input > LineSum)
        {
            LineLevel++;
            LineSum += LineLevel;
        }
        LineIndex = input - (LineSum - LineLevel);
        
        if(LineLevel % 2 == 0) // 짝수(상승)
        {
            writer.WriteLine($"{LineIndex}/{(LineLevel - LineIndex + 1)}");
        }
        else // 홀수(하강)
        {
            writer.WriteLine($"{(LineLevel - LineIndex + 1)}/{LineIndex}");
        }
    }
}