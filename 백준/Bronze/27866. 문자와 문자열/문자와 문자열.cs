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
            string inputString = reader.ReadLine();
            string inputIndex = reader.ReadLine();

            int index = int.Parse(inputIndex) - 1;

            writer.WriteLine(inputString[index]);
        }
    }
}