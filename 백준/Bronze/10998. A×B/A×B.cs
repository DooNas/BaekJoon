using System;

namespace baekjoon
{
    class no1000
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(); //입력받은 값을 공백 기준으로 배열로 나눈다.
            Console.WriteLine(int.Parse(a[0]) * int.Parse(a[1]));
        }
    }
}