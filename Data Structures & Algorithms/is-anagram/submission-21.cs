public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> d1 = new Dictionary<char, int>();
        Dictionary<char, int> d2 = new Dictionary<char, int>();

        bool res = true;
        
        if(s.Length != t.Length) return false;

        foreach(char c in s) 
        {
            d1[c] =d1.GetValueOrDefault(c) + 1;
        }

        foreach(char c in t) 
        {
            d2[c] = d2.GetValueOrDefault(c) + 1;
        }

        if(d1.Count != d2.Count) return false;

        foreach(var c in d1) {
            if(!d1.ContainsKey(c.Key) || !d2.ContainsKey(c.Key)) return false;
            if(d1[c.Key] != d2[c.Key]) return false;
        }

        return res;
    }
}
