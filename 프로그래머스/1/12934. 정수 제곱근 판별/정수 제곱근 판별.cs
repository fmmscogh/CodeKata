using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        var x = Math.Ceiling(Math.Sqrt(n));
        if(n/x == x){
            answer = (long)Math.Pow((x + 1), 2);
        }
        else if(n/x != x){
            answer = -1;
        }
        return answer;
    }
}