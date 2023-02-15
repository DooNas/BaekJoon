using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);    //고정 비용
        int B = int.Parse(input[1]);    //가변 비용
        int C = int.Parse(input[2]);    //제품 가격
        // 손익 분기점 = 고정비용 / (제품가격 - 가변비용)
        
        //가변 비용이 제품 가격보다 높을 경우 손익 분기점 X
        if(B >= C)
        {
            Console.WriteLine(-1);
            return;
        }
        else
        {
            int reult = A / (C - B) + 1;
            Console.WriteLine(reult);
        }
    }
}