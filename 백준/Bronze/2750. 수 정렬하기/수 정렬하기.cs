using System;

namespace baekjoon
{
    class no2750
    {
        static void Main(string[] args)
        {
            int Count = int.Parse(Console.ReadLine());
            int[] List = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                List[i] = int.Parse(Console.ReadLine());
            }
            choice(List);
            foreach(int i in List)
            {
                Console.WriteLine(i);
            }
        }

        static void choice(int[] List)
        {
            int nSmall = 0;
            int swap  = 0;

            for(int i = 0; i < List.Length; i++)
            {
                nSmall = i;
                for(int j = i; j < List.Length-1; j++)
                {
                    if(List[nSmall] > List[j+1])
                    {
                        nSmall = j + 1;
                    }
                }
                swap = List[i];
                List[i] = List[nSmall];
                List[nSmall] = swap;
            }
        }
    }
}