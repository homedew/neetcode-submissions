public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> closeToOpen =
            new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (closeToOpen.ContainsKey(c)) {
                if (stack.Count > 0 && closeToOpen[c] == stack.Peek()) {
                    stack.Pop();
                } else {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
