public class Solution {
    public int CharacterReplacement(string s, int k) {
        int rs = 0;
        for(int i = 0; i < s.Length; i++ ) {
            Dictionary<char, int> count = new ();
            int maxF =0;
            for(int j = i; j < s.Length; j++) {
                char c = s[j];
                count[c] = count.GetValueOrDefault(c, 0) + 1;
                maxF = Math.Max(maxF, count[c]);

                if( (j- i + 1) - maxF <=k) {
                    rs = Math.Max(rs, j  - i + 1);
                }


            }
        }

    return rs;

    }

}
