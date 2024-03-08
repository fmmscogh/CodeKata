using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long answer = 0;
        long x = 0;
        for(int i = 1; i <= count; i++){
            x += (long)(price * i);
        }
        if(x >= money){
            answer = x - money;
        }
        else if(x <= money){
            answer = 0;
        }
        return answer;
    }
}