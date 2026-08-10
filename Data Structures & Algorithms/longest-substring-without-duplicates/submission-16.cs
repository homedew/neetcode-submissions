public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var hs = new HashSet<char>();
        int l = 0;
        int rs = 0;

        for(int i = 0 ; i< s.Length; i++)
        {
            while(hs.Contains(s[i]))
            {
                hs.Remove(s[l]);
                l++;
            }

            hs.Add(s[i]);

            rs = Math.Max(rs, i - l + 1);
            
        }

        return rs;
    }
}
