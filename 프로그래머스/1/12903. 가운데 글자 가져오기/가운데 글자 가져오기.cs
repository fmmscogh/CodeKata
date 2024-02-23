using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
double r = s.Length / 2;
int h = s.Length / 2;
int a = (int)Math.Round(r);
if (s.Length % 2 == 1){
    answer = s[a].ToString();
}
else if(s.Length % 2 == 0)
{
    answer = s[h - 1] + s[h].ToString(); 
}
return answer;
    }
}