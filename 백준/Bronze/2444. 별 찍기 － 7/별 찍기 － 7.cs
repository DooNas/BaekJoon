class Program
{
    static void Main()
    {
        // 입력 및 출력 스트림 설정
        using (StreamReader reader = new(Console.OpenStandardInput()))
        using (StreamWriter writer = new(Console.OpenStandardOutput()))
        {
            string input = reader.ReadLine();

            int Temp = int.Parse(input);

            int Star = 0;
            int Space = Temp - 1; 

            for(int Line = 0; Line < (Temp*2-1); Line++)
            {
                string result = "";
                if(Line < Temp-1)
                {
                    for (int emt = 0; emt < Space; emt++) { result += " "; }
                    result += "*";
                    for (int str = 0; str < Star*2; str++) { result += "*"; }
                    Space--;
                    Star++;
                }
                else
                {

                    for (int emt = 0; emt < Space; emt++) { result += " "; }
                    result += "*";
                    for (int str = 0; str < Star * 2; str++) { result += "*"; }
                    Space++;
                    Star--;
                }
                writer.WriteLine(result);
            }
        }
    }
}