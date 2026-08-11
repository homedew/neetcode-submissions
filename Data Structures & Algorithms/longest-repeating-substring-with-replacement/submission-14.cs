public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> dt = new Dictionary<char, int>();
        int rs = 0;
        int left = 0;
        int maxLength =0;
        for (int i = 0; i < s.Length; i++) {
            dt[s[i]] = dt.GetValueOrDefault(s[i], 0) + 1;
            maxLength = Math.Max(maxLength, dt[s[i]]);
            while ((i - left + 1) - maxLength > k) {
                dt[s[left]]--;
                left++;
            }

            rs = Math.Max(rs, i - left + 1);
        }

        return rs;
    }
}
