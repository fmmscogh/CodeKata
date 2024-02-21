using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int[] num = {0,1,2,3,4,5,6,7,8,9};
        answer = num.Except(numbers).Sum();
        return answer;
    }
}
