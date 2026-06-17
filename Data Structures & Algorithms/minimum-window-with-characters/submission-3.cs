public class Solution {
    public string MinWindow(string s, string t) {
        if(t.Length > s.Length) return "";

        Dictionary<char, int > countT = new();
        Dictionary<char, int> window = new ();

        foreach(char c in t) {
            countT[c] = countT.GetValueOrDefault(c, 0) + 1;
        }

        int have =0, need = countT.Count;
        int left =0, rsLen= int.MaxValue, rsStart =0;

        for(int right = 0; right < s.Length; right++) {
            char c = s[right];
            window[c] = window.GetValueOrDefault(c, 0) + 1;
            if(countT.ContainsKey(c) && window[c] == countT[c]) {
                have++;
            }

            while(have == need) {
                if(( right - left + 1) < rsLen) {
                    rsLen = right - left + 1;
                    rsStart = left;
                }

                char leftChar = s[left];
                window[leftChar]--;
                if(countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar]) {
                    have--;
                }
                left++;
            }
        }

        return rsLen == int.MaxValue ? "" : s.Substring(rsStart, rsLen);
    }
}
