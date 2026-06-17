public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;
        while(l < r) {

            while(l < r && !IsAlphaNum(s[l])) {
                l++;
            }

            while(r > l && !IsAlphaNum(s[r])) {
                r--;
            }

            if(char.ToLower(s[l]) != char.ToLower(s[r])) {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }

    public bool IsAlphaNum(char c) {
        return ((c >='a' && c <='z') ||
                 (c >='A' && c <= 'Z') ||
                 (c>= '0' && c <='9')
                 );
    }
}
