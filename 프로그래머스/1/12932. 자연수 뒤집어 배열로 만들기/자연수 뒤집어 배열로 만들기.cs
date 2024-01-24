public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();
int[] answer = new int[str.Length];                                              

for (int i = 0; i < str.Length; i++)
{
    answer[i] = (int)(n % 10);
    n = n / 10;
}
        return answer;
    }
}