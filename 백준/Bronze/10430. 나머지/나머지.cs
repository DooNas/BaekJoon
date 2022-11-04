using System;

namespace baekjoon
{
    class no10430
    {
        static void Main(string[] args)
        {
            string[] ans = Console.ReadLine().Split();
            int A = int.Parse(ans[0]);
            int B = int.Parse(ans[1]);
            int C = int.Parse(ans[2]);
        
            Console.WriteLine((A+B)%C);
            Console.WriteLine(((A%C) + (B%C))%C);
            Console.WriteLine((A*B)%C);
            Console.WriteLine(((A%C) * (B%C))%C);
        }
    }
}