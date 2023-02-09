class Program
{
    public static void Main()
    {
        List<string> list = new List<string>();

        string Count = Console.ReadLine();
        for(int i = 0; i < int.Parse(Count); i++)
        {
            list.Add(Console.ReadLine());
        }
        //원하는 만큼 진행 N string

        foreach(string str in list)
        {
            int count = int.Parse(str[0].ToString());
            for(int i = 2; i < str.Length; i++)
            {
                for(int j = 0; j < count; j++)
                {
                    Console.Write(str[i]);
                }
            }
            Console.WriteLine();
        }
    }
}