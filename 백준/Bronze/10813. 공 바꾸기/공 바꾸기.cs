using System;
using System.IO;

class Program
{
    static void Main()
    {
        // 입력 및 출력 스트림 설정
        using (StreamReader reader = new(Console.OpenStandardInput()))
        using (StreamWriter writer = new(Console.OpenStandardOutput()))
        {
            string[] inputs = reader.ReadLine().Split(" ");
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int[] List = new int[N];
            for(int i  = 0; i < N; i++) List[i] = i+1;
            int t = 0;
            while(M != 0)
            {
                string[] balls = reader.ReadLine().Split(" ");
                int A = int.Parse(balls[0]) - 1;
                int B = int.Parse(balls[1]) - 1;
                if (A > N && B > N) continue;
                int Temp = List[A];
                List[A] = List[B];
                List[B] = Temp;
                M--;
            }
            string result = "";
            foreach(int i in List)
            {
                result += $"{i} ";
            }
            writer.WriteLine(result);
        }
    }
}