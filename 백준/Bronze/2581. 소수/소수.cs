using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            int Min = int.Parse(reader.ReadLine());
            int Max = int.Parse(reader.ReadLine());

            List<bool> isPrime = new List<bool>(Max + 1);

            for (int i = 0; i <= Max; i++)
            {
                isPrime.Add(true);
            }

            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i * i <= Max; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= Max; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            int sum = 0;
            int minPrime = int.MaxValue;

            for (int i = Min; i <= Max; i++)
            {
                if (isPrime[i])
                {
                    sum += i;
                    minPrime = Math.Min(minPrime, i);
                }
            }

            if (sum > 0)
            {
                writer.WriteLine(sum);
                writer.WriteLine(minPrime);
            }
            else
            {
                writer.WriteLine(-1);
            }
        }
    }
}
