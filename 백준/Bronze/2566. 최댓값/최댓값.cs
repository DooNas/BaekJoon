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
            int[,] Pan = new int[9, 9];
            for(int row =  0; row < 9;  row++)
            {
                string[] input = reader.ReadLine().Split(" ");
                for(int col = 0; col < 9; col++)
                {
                    if(input.Length > col)    // 범위 내에 있을 경우
                    {
                        Pan[row, col] = int.Parse(input[col]);
                    }
                    else // 범위를 초과할 경우
                    {
                        Pan[row, col] = 0;
                    }
                }
            }

            //최대값과 위치 저장
            int MaxNum = 0;
            int MaxRow = 0;
            int MaxCol = 0;
            for(int row = 0; row < 9; row++)
            {
                for(int col = 0;col < 9; col++)
                {
                    if(Pan[row, col] >= MaxNum)
                    {
                        MaxNum = Pan[row, col];
                        MaxRow = row+1;
                        MaxCol = col+1;
                    }
                }
            }
            writer.WriteLine(MaxNum);
            writer.WriteLine($"{MaxRow} {MaxCol}");
        }
    }
}