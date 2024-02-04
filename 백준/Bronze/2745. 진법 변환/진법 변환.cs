class program
{
    static void Main()
    {
        using (StreamReader reader = new(Console.OpenStandardInput()))
        using (StreamWriter writer = new(Console.OpenStandardOutput()))
        {
            string[] inputs = reader.ReadLine().Split(" ");
            int B = int.Parse(inputs[1]);    // 진법
            string N = inputs[0];            // 수

            Dictionary<string, int> jinbub = new();
            for(int i  = 0; i < 36; i++)
            {
                if(i < 10)  // 10진법 기준 숫자는 1 ~ 9존재.
                {
                    jinbub.Add(i.ToString(), i);
                }
                else    // 10진법 이후에 A(10), B(11), C(12)....Z(35)로 구성.
                {
                    jinbub.Add(((char)(i+55)).ToString(), i); //CHAR기준으로 55부터 A,B,C....로 구정.
                }
            }
            double result = 0;
            int stand = 0;
            for (int i = N.Length-1; i >= 0; i--)
            {
                result += jinbub[N[i].ToString()] * ((double)Math.Pow(B, stand));
                stand++;
            }
            writer.Write(result.ToString());
        }
    }
}