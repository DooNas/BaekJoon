using System.Numerics;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            int[] TrigleList = new int[3];
            string[] inputs = reader.ReadLine().Split(" ");
            for (int i = 0; i < 3; i++) TrigleList[i] = int.Parse(inputs[i]);
            int result = 0;
            int Max = TrigleList[0];
            int Sum = 0;
            foreach (int t in TrigleList) 
            {
                Max = (t > Max) ? t : Max;
                Sum += t;
            }

            if(Max < (Sum - Max))
            {
                result = Sum;
            }
            else
            {
                int Cut = (Sum - Max) - 1;
                result = Cut + (Sum - Max);
            }
            writer.WriteLine(result);
        }
    }
}
