using System;
using System.IO;

class Program
{
    static void Main()
    {
        // 입력 및 출력 스트림 설정
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            int bit = int.Parse(reader.ReadLine());
            int longCount = bit / 4; //몫만 저장.
            string result = "";
            for(int i = 0; i < longCount; i++)
                result += "long ";
            result += "int";
            writer.WriteLine(result);
        }
    }
}