using System;

namespace baekjoon
{
    class no2750
    {
        static void Main(string[] args)
        {
            int[] List = new int[5];
            for (int i = 0; i < 5; i++)
            {
                List[i] = int.Parse(Console.ReadLine());
            }
            choice(List);
            int sum = 0;
            foreach(int i in List)
            {
                sum += i;
            }
            Console.WriteLine(sum/5);
            Console.WriteLine(List[List.Length/2]);
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