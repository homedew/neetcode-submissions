public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count  = new int[26];

        int left = 0, maxFreq = 0, rs = 0;

        for(int right = 0; right  < s.Length; right ++) {

            count[s[right] - 'A']++;
            maxFreq = Math.Max(maxFreq, count[s[right] - 'A']);

            while((right - left) + 1 - maxFreq > k) {
                count[s[left] - 'A']--;
                left++;
            }

            rs = Math.Max(rs,  right - left + 1);
        }

        return rs;
    }
}
