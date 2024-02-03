using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Dictionary<string, double> gradeValues = new()
        {
            { "A+", 4.5 },
            { "A0", 4.0 },
            { "B+", 3.5 },
            { "B0", 3.0 },
            { "C+", 2.5 },
            { "C0", 2.0 },
            { "D+", 1.5 },
            { "D0", 1.0 },
            { "F", 0.0 }
        };
        // 입력 및 출력 스트림 설정
        using (StreamReader reader = new(Console.OpenStandardInput()))
        using (StreamWriter writer = new(Console.OpenStandardOutput()))
        {
            double TotalGPA = 0;
            double TotalPoint = 0;
            for (int i = 0; i < 20; i++)
            {
                string[] input = reader.ReadLine().Split(" ");

                string ClassName = input[0];
                double ClassPoint = double.Parse(input[1]);
                string ClassLevel = input[2];
                if (ClassLevel == "P") continue;
                TotalGPA += gradeValues[ClassLevel] * ClassPoint;
                TotalPoint += ClassPoint;
            }
            double result = TotalGPA / TotalPoint;
            writer.WriteLine(result.ToString("F6"));
        }
    }
}