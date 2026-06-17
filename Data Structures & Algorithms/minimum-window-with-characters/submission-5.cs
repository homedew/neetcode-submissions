public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int > countT = new ();
        int rsLen = int.MaxValue;
        int rsStart = -1;

        int rs = int.MaxValue;

        foreach(char c in t) {
            countT[c] = countT.GetValueOrDefault(c, 0) + 1;
        }

        for(int i = 0 ; i< s.Length; i ++) {
            Dictionary<char,int> countS = new ();

            for(int j = i; j <s.Length; j++) {
                countS[s[j]] = countS.GetValueOrDefault(s[j], 0) + 1;
                bool flag = true;

                foreach(var key in countT.Keys) {
                    if(!countS.ContainsKey(key) || countS[key] < countT[key]) {
                        flag = false;
                        break;
                    }
                }

                if( flag && (j - i + 1) < rsLen) {
                    rsLen = j - i + 1;
                    rsStart = i;
                }
            }
        }

        return rsLen == int.MaxValue ? "" : s.Substring(rsStart, rsLen);
    }
}
