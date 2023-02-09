using System;
using static System.Console;

class MainApp
{
    static void Main()
    {
        int N = int.Parse(ReadLine());
        string[] words = new string[N];
        int count = 0;

        for (int i = 0; i < N; i++)
        {
            words[i] = ReadLine();
        }

        for (int i = 0; i < N; i++)
        {
            if (checkWord(words[i]))
            {
                count++;
            }
        }
        WriteLine(count);
    }

    static bool checkWord(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i; j < word.Length; j++)
            {
                if (j - i > 1)
                {
                    if (word[i] == word[j])
                    {
                        return false;
                    }
                }
                if (word[i] == word[j])
                {
                    i += j - i;
                }
            }
        }
        return true;
    }
}