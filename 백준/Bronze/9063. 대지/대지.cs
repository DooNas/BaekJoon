using System.Numerics;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            int count = int.Parse(reader.ReadLine());
            int[] XList = new int[count];
            int[] YList = new int[count];
            for(int i = 0; i < count; i++)
            {
                string[] inputs = reader.ReadLine().Split(" ");
                XList[i] = int.Parse(inputs[0]);
                YList[i] = int.Parse(inputs[1]);
            }
            if(count > 1)
            {
                int min = XList[0];
                int max = XList[0];
                foreach (int x in XList) { min = (min > x) ? x : min; }
                foreach (int x in XList) { max = (max < x) ? x : max; }
                int Xline = max - min;

                min = YList[0];
                max = YList[0];
                foreach (int y in YList) { min = (min > y) ? y : min; }
                foreach (int y in YList) { max = (max < y) ? y : max; }
                int Yline = max - min;

                writer.WriteLine(Xline * Yline);
            }
            else
            {
                writer.WriteLine("0");
            }
        }
    }
}
