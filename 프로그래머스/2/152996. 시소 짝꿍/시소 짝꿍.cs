using System;
using System.Collections.Generic;

public class Solution {
    public long solution(int[] weights) {
        long answer = 0;
        
        Array.Sort(weights);
        Dictionary<int,int> W_List = new Dictionary<int,int>();
        int count = 0;
        int BeforeWeight = 0;
        
        foreach(int w in weights)
        {
            for(int i = 2; i < 5; i++)
            {
                W_List.TryAdd(w*i , 0);
                W_List[w*i]++;
            }
            if(BeforeWeight == w)
            {
                count++;
                answer -= count * 2;
            }
            else
            {
                BeforeWeight = w;
                count = 0;
            }
        }
        foreach(var item in W_List)
        {
            if(item.Value > 1){
                long match = 0;
                for(int i = 1; i < item.Value; i++) match += i;
                answer += match;
            }
        }
        return answer;
    }
}