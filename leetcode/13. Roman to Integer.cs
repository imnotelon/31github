public class Solution {
    public int RomanToInt(string s) {
        var roman = new Dictionary<char, int>();
        roman['I'] = 1;
        roman['V'] = 5;
        roman['X'] = 10;
        roman['L'] = 50;
        roman['C'] = 100;
        roman['D'] = 500;
        roman['M'] = 1000;

        var sum = 0; 
        for(int i = 0; i < s.Length; i++){
            if(i <= s.Length -2 && roman[s[i]] < roman[s[i+1]]){
                sum -= roman[s[i]];
            } else sum+=roman[s[i]];
        }
        return sum;

    }
}
