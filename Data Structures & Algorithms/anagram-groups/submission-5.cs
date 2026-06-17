public class Solution {
    private bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] count = new int[26];
        
        for(int i =  0 ; i < s.Length; i++) {
            count[s[i]- 'a']++;
            count[t[i] - 'a']--;
        }

        foreach(int n in count) {
            if(n !=0) return false;
        }

        return true;
    }

    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, int> dt = new ();
        List<List<string>> rs = new ();

        foreach(string str in strs) {
            dt[str] = dt.GetValueOrDefault(str, 0) + 1;
        }

        for(int i = 0;  i< strs.Length; i ++) {
            if(dt[strs[i]] == 0) continue;
            List<string> tempRs = new();
            tempRs.Add(strs[i]);
            dt[strs[i]]--;
            for(int j = i + 1; j < strs.Length;  j++) {
                if(dt[strs[j]] > 0 && IsAnagram(strs[i], strs[j])) {
                    tempRs.Add(strs[j]);
                    dt[strs[j]]--;
                }
            }

            rs.Add(tempRs);
        }

        return rs;
        
    }
}
