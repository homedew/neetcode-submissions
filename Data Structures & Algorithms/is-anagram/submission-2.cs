public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dicS = new();
        Dictionary<char, int> dicT = new();

        foreach(char c in s) {
            if(dicS.ContainsKey(c)){
                dicS[c]++;
            } else {
                dicS.Add(c, 1);
            }
        }

        foreach(char c in t) {
            if(dicT.ContainsKey(c)){
                dicT[c]++;
            } else {
                dicT.Add(c, 1);
            }
        }

        if(dicT.Count != dicS.Count) return false;

        foreach(char c in t) {
             if(dicS.ContainsKey(c)){
                dicS[c]--;
            } 
        }


        foreach(var c in dicS) {
            if(c.Value > 0) {
                return false;
            }
        }

        return true;
    }
}
