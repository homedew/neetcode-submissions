public class Solution {
    public int CharacterReplacement(string s, int k) {
        // core idea 
        // count the number appear of character 
        // in substring

        // currentLength - maxFreq <= k => update rs

        int rs = 0;
        for(int i = 0; i<  s.Length; i++) {
            Dictionary<char, int> count = new ();
            int maxFreq = 0;

            for(int j = i; j < s.Length; j++) {
                char c = s[j];

                count[c] = count.GetValueOrDefault(c, 0) + 1;

                maxFreq = Math.Max(maxFreq, count[c]);
                
                int windowSize = j - i + 1;

                if(windowSize - maxFreq <=k) {
                    rs = Math.Max(rs, windowSize);
                }
            }
        }

        return rs;
    }
}
