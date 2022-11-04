using System;

namespace baekjoon
{
    class no1008{
        static void Main(string[] args){
            string[] nums = Console.ReadLine().Split();
            double ansower = Double.Parse(nums[0]) / Double.Parse(nums[1]);
            
            Console.WriteLine("{0:N9}", ansower);
        }
    }
}