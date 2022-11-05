public class Solution {
    public string solution(string s) {
        string[] list = s.Split();
        int min = int.Parse(list[0]);
        int max = int.Parse(list[0]);
        for(int i = 0; i < list.Length; i++)
        {
            int num = int.Parse(list[i]);
            if(num > max) max = num;
            if(num < min) min = num;
        }
        
        string answer = min.ToString() + " " + max.ToString();
        return answer;
    }
}