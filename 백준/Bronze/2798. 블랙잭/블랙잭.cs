class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            string[] inputs = reader.ReadLine().Split(" ");
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);


            string[] Strcards = reader.ReadLine().Split(" ");
            int[] cards = new int[N];
            for(int i = 0; i < N; i++) { cards[i] = int.Parse(Strcards[i]); }

            int maxSum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    for (int k = j + 1; k < N; k++)
                    {
                        int sum = cards[i] + cards[j] + cards[k];
                        if (sum <= M && sum > maxSum) maxSum = sum;
                    }
                }
            }

            writer.WriteLine(maxSum);
        }
    }
}