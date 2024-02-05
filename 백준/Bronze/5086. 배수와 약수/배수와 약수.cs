class program
{
    static void Main()
    {
        using StreamReader reader = new(Console.OpenStandardInput());
        using StreamWriter writer = new(Console.OpenStandardOutput());
        while (true)
        {
            string[] inputs = reader.ReadLine().Split(" ");
            if (inputs.Length == 1 && inputs.Length > 2) break;
            int A = (inputs[0] != "") ? int.Parse(inputs[0]) : 0;
            int B = (inputs[1] != "") ? int.Parse(inputs[1]) : 0;
            string result = "";
            if (A == 0 & B == 0) break;
            else
            {
                if(A > B && A % B == 0) result = "multiple";
                else if(A < B && B % A == 0) result = "factor";
                else result = "neither";
                writer.WriteLine(result);
                writer.Flush(); // 버퍼 비우기
            }
        }
    }
}