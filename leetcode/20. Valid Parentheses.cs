public class Solution {
    public bool IsValid(string s) {
        var st = new Stack();
        var dictionary = new Dictionary<char,char>();
        dictionary['('] = ')';
   
        dictionary['{'] = '}';

        dictionary['['] = ']';

        for(int i = 0; i < s.Length; i ++){
            if(st.Count == 0) {
                st.Push(s[i]);
            }
            else if(dictionary.ContainsKey((char)st.Peek()) && dictionary[(char)st.Peek()] == s[i]){            st.Pop();;
                 
            } else st.Push(s[i]);
        }
        return st.Count == 0;
    }
}
