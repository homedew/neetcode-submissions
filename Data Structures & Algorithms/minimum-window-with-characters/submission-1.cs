public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> countT = new ();
        int rs =0;
        int leftPosition =0;
        int length = int.MaxValue;

        for(int i = 0; i < t.Length; i++) {
            countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;
        }   

        for(int i = 0; i < s.Length; i++) {
            Dictionary<char, int> countS = new ();
            for(int j  = i;  j < s.Length; j++ ) {
                countS[s[j]] = countS.GetValueOrDefault(s[j], 0 ) + 1;
                bool flag = true;
                foreach(char c in countT.Keys) {
                    if(!countS.ContainsKey(c) || countS[c] < countT[c]) {
                        flag = false;
                        break;
                    }
                }

                if(flag && (j - i + 1) < length) {
                    length = j - i + 1;
                    leftPosition = i;
                }
            }
        }

        return length== int.MaxValue ? "" : s.Substring(leftPosition, length);
    }
}
