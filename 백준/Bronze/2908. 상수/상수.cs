class Program
{
    public static void Main()
    {
        string input = Console.ReadLine().Trim();
        string[] Numbers = input.Split(' ');

        int[] NumbersInt = new int[Numbers.Length];
        int i = 0;
        foreach(string Number in Numbers)
        {
            string temp = "";
            for(int j = Number.Length-1; j > -1; j--)
            {
                temp += Number[j];
            }
            NumbersInt[i++] = int.Parse(temp);
        }
        if(NumbersInt[0] > NumbersInt[1])
        {
            Console.WriteLine(NumbersInt[0]);
        }
        else
        {
            Console.WriteLine(NumbersInt[1]);
        }
    }
}