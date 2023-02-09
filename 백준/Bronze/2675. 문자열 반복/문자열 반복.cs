class Program
{
    public static void Main()
    {
        List<string> list = new List<string>();

        int Count = int.Parse(Console.ReadLine());
        for(int i = 0; i < Count; i++)
        {
            list.Add(Console.ReadLine());
        }

        foreach(string str in list)
        {
            int count = int.Parse(str[0].ToString());
            for(int i = 2; i < str.Length; i++)
            {
                Console.Write(new string(str[i], count));
            }
            Console.WriteLine();
        }
    }
}