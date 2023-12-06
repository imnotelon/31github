public class Solution {
    public int TitleToNumber(string columnTitle)
    {
        int ans = 0;
        for (int i = columnTitle.Length - 1; i >=0; i--)
        {
            ans+= ((int)columnTitle[i] - (int)'A' + 1)*((int)Math.Pow(26,columnTitle.Length - 1 - i));
        }

        return ans;
    }
}