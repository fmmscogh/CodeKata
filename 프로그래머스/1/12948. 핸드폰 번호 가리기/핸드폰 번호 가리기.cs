public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        string star;
        star = new string('*', phone_number.Length - 4);
        answer = star + phone_number.Substring(phone_number.Length - 4);
        return answer;
    }
}