using System;
using System.Numerics;

namespace baekjoon {
    class Program {
        public static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(" ");
            
            // 1부터 10^12까지의 정수로 제한 BigInteger를 통해 해결.
            BigInteger A = BigInteger.Parse(input[0]);
            BigInteger B = BigInteger.Parse(input[1]);
            BigInteger C = BigInteger.Parse(input[2]);
            
            Console.WriteLine(A + B + C);
        }
    }
}