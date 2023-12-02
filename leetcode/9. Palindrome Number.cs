public class Solution {
    public bool IsPalindrome(int x) {
        var ans = x.ToString();
        for (var i = 0; i < Math.Ceiling(ans.Length / 2.0); i++)
            if (ans[i] != ans[ans.Length - i - 1])
                return false;
        return true;
    }
}