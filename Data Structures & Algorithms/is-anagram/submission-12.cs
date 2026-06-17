public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict1 = new Dictionary<char, int>();
        Dictionary<char, int> dict2 = new Dictionary<char, int>();
        if(s.Length != t.Length) return false;

        for(int i =0; i < s.Length ; i++) {
            dict1[s[i]] = dict1.GetValueOrDefault(s[i], 0) + 1;
            dict2[t[i]] = dict2.GetValueOrDefault(t[i], 0) + 1;
        }

        return dict1.Count == dict2.Count && !dict1.Except(dict2).Any();

    }
}
