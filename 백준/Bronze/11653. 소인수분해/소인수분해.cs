public class Program
{

    public static void Main()
    {
        //정수 N 소인수분해하기
        int N = int.Parse(Console.ReadLine());
        for(int i=2; i<N+1; i++)
        {
            while (N % i == 0)
            {
                Console.WriteLine(i);
                N /= i;
            }
        }
    }
}