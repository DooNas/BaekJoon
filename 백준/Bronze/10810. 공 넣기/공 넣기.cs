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
            while(M != 0)
            {
                string[] balls = reader.ReadLine().Split(" ");
                int Start = int.Parse(balls[0]);
                int End = int.Parse(balls[1]);
                int Ballnum = int.Parse(balls[2]);
                if (Ballnum > N) continue;
                for(int i = Start-1; i < End; i++)
                {
                    List[i] = Ballnum;
                }
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