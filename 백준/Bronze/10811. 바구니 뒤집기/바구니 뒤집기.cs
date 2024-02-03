using System;
using System.IO;
using System.Runtime.InteropServices;

class Program
{
    static int[] List;
    static void Main()
    {
        // 입력 및 출력 스트림 설정
        using (StreamReader reader = new(Console.OpenStandardInput()))
        using (StreamWriter writer = new(Console.OpenStandardOutput()))
        {
            string[] inputs = reader.ReadLine().Split(" ");
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            List = new int[N];
            for(int i  = 0; i < N; i++) List[i] = i+1;
            int t = 0;
            while(M != 0)
            {
                string[] balls = reader.ReadLine().Split(" ");
                int Start = int.Parse(balls[0]) - 1;
                int End = int.Parse(balls[1]) - 1;
                if (Start > N && End > N) continue;
                Reverse(Start,End);
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
    static void Reverse(int Start, int End)
    {
        int Startindex = Start;
        int Endindex = End;
        while(Startindex < Endindex)
        {
            int temp = List[Startindex];
            List[Startindex] = List[Endindex];
            List[Endindex] = temp;
            Startindex++;
            Endindex--;
        }
    }
}