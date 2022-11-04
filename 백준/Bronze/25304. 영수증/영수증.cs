using System;

namespace baekjoon
{
    class no25304
    {
        static void Main(string[] args)
        {
            int Sum = int.Parse(Console.ReadLine());
            int Count = int.Parse(Console.ReadLine());

            int[] List = new int[Count];
            for(int i = 0; i < Count; i++)
            {
                string[] input = Console.ReadLine().Split();
                List[i] = int.Parse(input[0]) * int.Parse(input[1]);
            }
            int check = 0;
            foreach(int i in List){
                check += i;
            }
            if(Sum == check) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}