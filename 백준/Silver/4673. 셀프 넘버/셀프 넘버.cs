using System;
using System.Text;

namespace baekjoon
{
    class no4673
    {
        static void Main(string[] args)
        {
            //10000이하의 숫자를 구하기 때문에 10000개의 배열을 만들어준다.
            int[] List = new int[10000];
            for(int i = 0; i < 10000; i++)
            {
                List[i] = d(i.ToString());
            }

            //생성자가 있는 0~9999까지의 숫자가 저장된 List배열을 만들었다.
            //Stringbuilder를 통해 성능을 높인다.(using System.Text)
            StringBuilder seftNum = new StringBuilder();
            bool isCheck = true; // 거름망
            for(int i = 0; i < 10001; i++)
            {
                for(int j = 0; j < List.Length; j++)
                {
                    if(List[j] == i)
                    {
                        isCheck = false;
                        break;  //바로 다음 숫자 진행
                    }
                    else isCheck = true;
                }
                if(isCheck) seftNum.AppendLine(i.ToString()); //int To string
            }
            Console.WriteLine(seftNum);
        }

        //지문에서 말하는 d(n)을 구하는 함수
        static int d(string n)
        {
            int Result = int.Parse(n);

            for(int i=0; i < n.Length; i++)
            {
                Result += int.Parse(n[i].ToString());   //각 자리수를 더해준다.
            }
            return Result;
        }
    }
}