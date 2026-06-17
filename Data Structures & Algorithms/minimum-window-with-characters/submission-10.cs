public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> countT = new ();
        foreach(char c in t) {
            countT[c] = countT.GetValueOrDefault(c, 0) + 1;
        }

        int have = 0, need = countT.Count;
        int resLen = int.MaxValue;
        int left =0;
        int start = 0;
        Dictionary<char,int> window = new();

        for(int r = 0; r < s.Length; r++) {
            window[s[r]] = window.GetValueOrDefault(s[r], 0) + 1;

            if(countT.ContainsKey(s[r]) && window[s[r]] == countT[s[r]]) {
                have++;
            }

            while(have == need) {
                if((r- left + 1 < resLen)) {
                    resLen = r - left + 1;
                    start = left;
                }
                var leftChar = s[left];
                window[leftChar]--;
                if(countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar]) {
                    have--;
                }
                left++;
            }
        }

        return resLen == int.MaxValue ? "" : s.Substring(start, resLen);
    }
}
