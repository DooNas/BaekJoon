using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // 입력 및 출력 스트림 설정
        using (StreamReader reader = new(Console.OpenStandardInput()))
        using (StreamWriter writer = new(Console.OpenStandardOutput()))
        {
            string[] input = reader.ReadLine().Split(" ");
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int[,] A = new int[N,M];
            int[,] B = new int[N,M];
            int[,] Sum = new int[N,M];
            for(int type = 0; type < 2; type++)
            {
                for (int i = 0; i < N; i++)
                {
                    string[] Ainput = reader.ReadLine().Split(" ");
                    if (Ainput.Length == M)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            if (type == 0) A[i, j] = int.Parse(Ainput[j]);
                            if (type == 1) B[i, j] = int.Parse(Ainput[j]);
                        }
                    }
                }
            }
            for(int ni = 0; ni < N; ni++)
            {
                for(int mi = 0; mi < M; mi++)
                {
                    Sum[ni,mi] = A[ni,mi] + B[ni,mi];
                }
            }
            for (int ni = 0; ni < N; ni++)
            {
                for (int mi = 0; mi < M; mi++)
                {
                    writer.Write($"{Sum[ni, mi]} ");
                }
                writer.WriteLine();
            }
        }
    }
}