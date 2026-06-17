public class Solution {
    public string MinWindow(string s, string t) {
        if( t == "") return "";

        Dictionary<char, int> dt = new ();
        Dictionary<char, int> window = new ();

        foreach(char c in t) {
            dt[c] = dt.GetValueOrDefault(c, 0) + 1;
        }

        int have = 0, need = dt.Count;
        int rsLen = int.MaxValue;
        int l =0;
        int leftPosition = -1;

        for(int r =0; r < s.Length; r++) {
            char c = s[r];
            window[c] = window.GetValueOrDefault(c, 0) + 1;

            if(dt.ContainsKey(c) && window[c] == dt[c]) {
                have++;
            }

            while(have == need) {
                if((r-l + 1) < rsLen) {
                    rsLen = r - l +1;
                    leftPosition = l;
                }

                char leftChar = s[l];
                window[leftChar]--;

                if(dt.ContainsKey(leftChar) && window[leftChar] < dt[leftChar]) {
                    have--;
                }

                l++;
            }
        }

        return rsLen == int.MaxValue ? "" : s.Substring(leftPosition, rsLen); 
    }
}
