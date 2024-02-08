using System.Numerics;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            int[] AngelList = new int[3];
            int[] SameList = new int[3];
            for(int i = 0; i < 3; i++)
            {
                AngelList[i] = int.Parse(reader.ReadLine());
            }
            string[] TypeList = new string[]{ "Equilateral", "Isosceles", "Scalene", "Error" };
            string result = string.Empty;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (AngelList[i] == AngelList[j]) SameList[i]++;
                }
            }
            foreach(int same in SameList) 
            {
                if (same == 3) result = TypeList[0];
                else if (same == 2) result = TypeList[1];
                else if (same == 1) result = TypeList[2];
            }
            if (result == TypeList[1]) result = (AngelList[0] + AngelList[1] + AngelList[2] == 180) ? result : TypeList[3];
            if (result == TypeList[2]) result = (AngelList[0] + AngelList[1] + AngelList[2] == 180) ? result : TypeList[3];
            writer.WriteLine(result);
        }
    }
}
