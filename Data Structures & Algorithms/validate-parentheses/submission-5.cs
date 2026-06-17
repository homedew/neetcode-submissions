public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new ();

        foreach(char c in s ) {
            if(c == '(') st.Push(')');
            else if(c=='[') st.Push(']');
            else if(c=='{') st.Push('}');
            else {
                if(st.Count ==0 || st.Pop() != c) {
                    return false;
                }
            }
        }

        return st.Count == 0;
    }
}
