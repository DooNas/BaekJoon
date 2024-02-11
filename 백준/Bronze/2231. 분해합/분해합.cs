class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            string input = reader.ReadLine();
            int M = int.Parse(input);
            int N = (M - (9 * input.Length) > 0) ? M - (9 * input.Length) : 0;
            while (true)
            {
                int Sum = N;
                string s = N.ToString();    //자리값 체크
                for(int i = 0; i < s.Length; i++)
                {
                    Sum += int.Parse(s[i].ToString());
                }
                if (Sum == M || N > M)
                {
                    if(N > M) N = 0;
                    break;
                }
                N++;
            }
            writer.WriteLine(N);
        }
    }
}