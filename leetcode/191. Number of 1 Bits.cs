public class Solution {
    public int HammingWeight(uint n) {
        var st = Convert.ToString(n,2);
        var counter = 0;
        for(var i = 0; i < st.Length; i++){
            if(st[i] == '1') counter++;
        }
        return counter;
    }
}