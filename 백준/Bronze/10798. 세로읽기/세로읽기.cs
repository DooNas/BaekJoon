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
            int RowCount = 5;
            int ColumnCount = 15;

            string[,] List = new string[RowCount, ColumnCount];

            for(int row = 0; row < RowCount; row++)
            {
                string input = reader.ReadLine();
                for (int col = 0; col < ColumnCount; col++)
                {
                    if(input.Length > col)
                    {
                        List[row, col] = input[col].ToString();
                    }
                    else
                    {
                        List[row, col] = "";
                    }
                }
            }
            
            for(int col =  0; col < ColumnCount; col++)
            {
                for(int row = 0; row < RowCount; row++)
                {
                    writer.Write(List[row, col]);
                }
            }
        }
    }
}