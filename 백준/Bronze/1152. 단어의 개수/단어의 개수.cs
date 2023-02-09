class Program
{
    public static void Main()
    {
        string input = Console.ReadLine().Trim();
        string[] words = input.Split(' ');

        int CountNull = 0;
        foreach(string word in words)
        {
            if(String.IsNullOrEmpty(word))  // 공백으로 구성된 단어 체크
            {
                CountNull++;
            }
        }
        Console.WriteLine(words.Length - CountNull);
    }
}