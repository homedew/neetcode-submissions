public class Solution {
    public bool IsValid(string s) {
        Stack<char> sk = new ();
        Dictionary<char, char> dt = new ();

        foreach(char c in s) {
            if(c == '[' || c == '(' || c == '{') {
                sk.Push(c);
            }   else {
                if(sk.Count == 0) return false;

                char top = sk.Pop();

                if((c== ')' && top  != '(') ||
                    (c == ']' && top !='[') ||
                    (c =='}' && top !='{')
                ) return false;

            }
        }

        return sk.Count == 0;
    }
}
