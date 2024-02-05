class program
{
    static void Main()
    {
        using StreamReader reader = new(Console.OpenStandardInput());
        using StreamWriter writer = new(Console.OpenStandardOutput());
        int Count = int.Parse(reader.ReadLine());
        string[] inputs = reader.ReadLine().Split(" ");

        int Result = 0;
        for (int i = 0; i < Count; i++)
        {
            bool PrimeCheck = true;
            int Num = int.Parse(inputs[i]);
            if(Num == 1) PrimeCheck = false;
            else
            {
                for (int j = 2; j < Num; j++)
                {
                    if (Num % j == 0)
                    {
                        PrimeCheck = false;
                        break;
                    }
                }
            }
            Result += (PrimeCheck) ? 1 : 0;
        }
        writer.WriteLine(Result);
    }
}