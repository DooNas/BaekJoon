using System;

namespace baekjoon
{
    class no25305
    {
        static void Main(string[] args)
        {
            string[] config = Console.ReadLine().Split(' ');
            int count = int.Parse(config[0]);
            int win = int.Parse(config[1]);

            string[] strList = Console.ReadLine().Split(' ');
            int[] numList = Array.ConvertAll(strList, s => int.Parse(s));

            if(numList.Length == count){//응시자 수와 입력된 수가 같을 때
                bubble(numList);
            }
            Console.WriteLine(numList[count-win]);
        }
        //버블정렬
        static void bubble(int[] List)
        {
            int swap = 0;
            for(int i = 0; i < List.Length-1; i++)
            {
                for(int j = i; j < List.Length; j++)
                {
                    if(List[i] > List[j])
                    {
                        swap = List[i];
                        List[i] = List[j];
                        List[j] = swap;
                    }
                }
            }
        }
        //선택정렬
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