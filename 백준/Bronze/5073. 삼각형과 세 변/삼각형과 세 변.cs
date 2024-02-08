using System.Numerics;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            int[] Trigle = new int[3];
            int[] Same = new int[3];
            int Stop, Max, Sum;
            string result;
            while (true)
            {
                string[] inputs = reader.ReadLine().Split(" ");     // 3변의 길이를 받음.
                for (int i = 0; i < 3; i++) Trigle[i] = int.Parse(inputs[i]);   // string > int
                result = string.Empty;
                Stop = 0;
                Max = 0;
                Sum = 0;
                foreach (int i in Trigle)
                {
                    Stop += (i == 0) ? 1 : 0; // 3변이 모두 0이면 종료.
                    Max = (Max < i) ? i : Max; // 3변중에 가장 긴 변값을 저장.
                    Sum += i;  // 삼각형의 둘레값.
                }
                if (Stop == 3) break;   // 3변이 모두 0이면 종료.
                if (Max >= (Sum - Max)) result = "Invalid"; //가장 긴 변의 길이가 나머지 두변의 길이의 합보다 짧지 않을 경우.
                else
                {
                    for(int i = 0; i < 3; i++)  // 3변을 기준으로 [3,3,3] , [1,2,2], [1,1,1] 이런 느낌으로 같은 갯수를 파악.
                    {
                        Same[i] = 0;
                        for (int j = 0; j < 3; j++) Same[i] += (Trigle[i] == Trigle[j]) ? 1 : 0;
                    }
                    Max = Same[0];
                    foreach (int s in Same) Max = (s > Max) ? s : Max;  // 3개 중복, 2개 중복, 1개 중복 중 가장 큰 값을 찾음.
                    result = (Max == 3) ? "Equilateral" : ((Max == 2) ? "Isosceles" : "Scalene");
                }
                writer.WriteLine(result);
                writer.Flush();
            }
        }
    }
}
