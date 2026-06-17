public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> countT = new ();
        Dictionary<char, int> window = new ();


        foreach(char c in t) {
            countT[c] = countT.GetValueOrDefault(c, 0) + 1;
        }

        int rsLen = int.MaxValue, start = 0;
        int have = 0, need = countT.Count;
        int l =0, right = 0;

        for(int r = 0; r < s.Length; r++) {
            window[s[r]] = window.GetValueOrDefault(s[r], 0) + 1;
            var key = s[r];
          if(countT.ContainsKey(key) && window[key] == countT[key]) {
                    have++;
                }
            while(have == need) {
                if((r - l + 1) < rsLen) {
                    rsLen = r- l + 1;
                    start = l;
                }

                char leftC = s[l];
                window[leftC]--;
                if(countT.ContainsKey(leftC) && window[leftC] < countT[leftC]) {
                    have--;
                }
                l++;
            }
        }


        return rsLen == int.MaxValue ? "" : s.Substring(start, rsLen);
    }
}
