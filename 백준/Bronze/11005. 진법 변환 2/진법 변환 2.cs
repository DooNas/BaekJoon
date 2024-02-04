class program
{
    static void Main()
    {
        using StreamReader reader = new(Console.OpenStandardInput());
        using StreamWriter writer = new(Console.OpenStandardOutput());
        string[] inputs = reader.ReadLine().Split(" ");
        int B = int.Parse(inputs[1]);    // 진법
        int N = int.Parse(inputs[0]);        // 수
        Dictionary<int, string> jinbub = new();
        for (int i = 0; i < 36; i++)
        {
            string Key = (i < 10) ? i.ToString() : ((char)(i + 55)).ToString();
            jinbub.Add(i, Key);
        }
        string Result = "";
        while (true)
        {
            int share = N / B;  // 몫
            int remain = N % B; // 나머지
            if(share == 0 && remain == 0) 
            { break; }
            else
            {
                Result = jinbub[remain] + Result;
                N = share;
            }
        }
        writer.Write(Result);
    }
}