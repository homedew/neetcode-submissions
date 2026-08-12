public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict = new Dictionary<char, int>();
        int left = 0;
        int maxW = 0;
        int res = 0;
        for(int i = 0; i < s.Length; i++)
        {
            dict[s[i]] = dict.GetValueOrDefault(s[i], 0) + 1;
            maxW = Math.Max(maxW, dict[s[i]]);
            while(((i - left + 1) - maxW )> k)
            {
                dict[s[left]]--;
                left++;
            }

            res = Math.Max(res, i - left + 1);
        }

        return res;
    }
}
