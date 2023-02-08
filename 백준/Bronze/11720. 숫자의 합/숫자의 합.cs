using System;
class Program
{
    public static void Main()
    {
        int Count = Convert.ToInt32(Console.ReadLine());
        string Numbers = Console.ReadLine();
        int sum = 0;
        if(Count == Numbers.Length){
            for(int i = 0; i < Count; i++)
            {
                 sum += int.Parse(Numbers[i].ToString());
            }
        }
        Console.WriteLine(sum);
    }
}