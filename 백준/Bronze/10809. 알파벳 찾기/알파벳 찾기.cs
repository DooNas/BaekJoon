class Program
{
    public static void Main()
    {
        String S = Console.ReadLine();
        char start = 'a';
        string result = "";
        for(int i = 0; i < 26; i++)
        {
            Console.Write(S.IndexOf((char)(start + i)) + " ");
        }
    }
}