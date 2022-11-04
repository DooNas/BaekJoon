using System;

namespace baekjoon
{
    class no10807
    {
        static void Main(string[] args)
       {
            int Count = int.Parse(Console.ReadLine());
            string[] input;
            input = Console.ReadLine().Split();
            int v = int.Parse(Console.ReadLine());
            int Check = 0;
            foreach(string n in input)
            {
                if(v == int.Parse(n)) Check++;
            }
            Console.WriteLine(Check);
       } 
    }
}