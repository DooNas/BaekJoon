using System;
using System.IO;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        // 입력 및 출력 스트림 설정
        using (StreamReader reader = new(Console.OpenStandardInput()))
        using (StreamWriter writer = new(Console.OpenStandardOutput()))
        {
            string input = reader.ReadLine();

            int T = int.Parse(input);
            string[]  List = new string[T];
            for(int index = 0; index < T; index++)
            {
                string Ward = reader.ReadLine();
                List[index] = Ward[0].ToString();
                List[index] +=Ward[^1];
            }
            foreach (string result in List)
            {
                writer.WriteLine(result);
            }
        }
    }
}