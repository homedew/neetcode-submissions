public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> cs = new ();
        int l = 0, rs =0;

        for(int r = 0; r < s.Length; r++) {
            while(cs.Contains(s[r])) {
                cs.Remove(s[l]);
                l++;
            }
            cs.Add(s[r]);
            rs = Math.Max(rs,  r- l + 1);
        }

        return rs;
    }
}

