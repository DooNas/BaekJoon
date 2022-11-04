using System;

namespace baekjoon
{
    class no3003
    {
        static void Main(string[] args)
        {
            string[] white = Console.ReadLine().Split();
            int[] black = {1, 1, 2, 2, 2, 8};
            
            for(int i = 0; i < white.Length; i++)
            {
                System.Console.Write("{0} ", black[i]-int.Parse(white[i]));
            }
        }
    }
}