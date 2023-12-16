public class Solution {
    public int[] PlusOne(int[] digits) {
        int remainder = 1;
        for(int i = digits.Length - 1; i >= 0; i--){
            digits[i]+=remainder;
            remainder = digits[i]/10;
            digits[i]%=10;
        }
        if(remainder == 0) return digits;
        List<int> arr = new List<int>();
        arr.Add(remainder);
        arr.AddRange(digits);
        return arr.ToArray();       
    }
}
