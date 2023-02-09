using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader(Console.OpenStandardInput()); //시간 감소를 위한 조치
        using var writer = new StreamWriter(Console.OpenStandardOutput());//시간 감소를 위한 조치
        int count = Convert.ToInt32(reader.ReadLine());

        int[] list = new int[10001];    //1~10000을 담을 수 있는 배열
        for(int i = 0; i < count; i++)
        {
            list[int.Parse(reader.ReadLine())]++; //입력받은 수를 인덱스로 사용하여 해당 인덱스의 값을 1 증가
        }
        for(int i = 0; i <= 10000; i++){
            if(list[i] != 0)    //해당 인덱스의 값이 0이 아니면
                for(int j = 0; j < list[i]; j++)    //해당 인덱스의 값만큼 출력
                    writer.WriteLine(i);
        }
    }
}