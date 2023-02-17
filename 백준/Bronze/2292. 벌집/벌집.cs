using System;
using static System.Console;

class MainApp
{
    static void Main()
    {
        // 입력 수
        int input = int.Parse(ReadLine());

        // 계산에 필요한 변수
        int cnt = 1; // 몇겹인지 = 최소 칸수
        long range = 1; // 숫자의 범위 ex) 2~7, 8~19
        long temp = 1; // 6의 배수를 더하기 위해서 사용

        while(true)
        {
            if(range >= input) // 범위가 커지면 정지
            {
                break;
            }
            temp = 6 * cnt++; // 6씩 증가되는 벌집 크기를 위해 temp에 저장
            range += temp; // 그 temp 값을 범위에 넣어서 input 값과 비교함
        }
        WriteLine(cnt);
    }
}