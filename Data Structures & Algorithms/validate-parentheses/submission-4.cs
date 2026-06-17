public class Solution {
    public bool IsValid(string s) {
        Stack<char> sk = new ();

        foreach(char c in s) {
            if(c =='(') sk.Push(')');
            else if(c =='{') sk.Push('}');
            else if(c == '[') sk.Push(']');
            else {
                if(sk.Count == 0 || sk.Pop() != c) {
                    return false;
                }
            }
        }

        return sk.Count ==0;
    }
}
