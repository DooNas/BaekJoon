using System;

class Program
{
    static void Main()
    {
        // 입력 및 출력 스트림 설정
        using (StreamReader reader = new(Console.OpenStandardInput()))
        using (StreamWriter writer = new(Console.OpenStandardOutput()))
        {
            string input = reader.ReadLine();

            char[] RightArray = input.ToCharArray();
            Array.Reverse(RightArray);
            string Reverseinput =new(RightArray);

            int same = 0;
            if (input.Equals(Reverseinput)) { same = 1;}
            else { same = 0;}

            writer.WriteLine(same);
        }
    }
}