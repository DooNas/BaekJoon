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
            int RowCount = 100;
            int ColumnCount = 100;

            int[,] List = new int[RowCount, ColumnCount];

            int PaperCount = int.Parse(reader.ReadLine());

            for(int i = 0; i < PaperCount; i++)
            {
                string[] inputs = reader.ReadLine().Split(" ");
                int ProwStart = int.Parse(inputs[0]);
                int PcolStart = int.Parse(inputs[1]);

                for(int row  = ProwStart; row < 10 + ProwStart; row++)
                {
                    for(int col = PcolStart; col < 10 + PcolStart; col++)
                    {
                        if(RowCount > row && ColumnCount > col)
                        {
                            List[row, col] = 1;
                        }
                    }
                }
            }
            int Sum = 0;
            for(int row =  0; row < RowCount; row++)
            {
                for(int col = 0; col < ColumnCount; col++)
                {
                    Sum += List[row, col];
                }
            }

            writer.WriteLine(Sum);
        }
    }
}