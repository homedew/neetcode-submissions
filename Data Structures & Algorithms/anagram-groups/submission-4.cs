public class Solution {

    private bool isAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] arr = new int[26];

        for(int i = 0; i < s.Length; i++) {
            arr[s[i] - 'a']++;
            arr[t[i] - 'a']--;
        } 

        foreach(int val in arr) {
            if(val !=0) return false;
        }

        return true;
    }

    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> rs = new();

        Dictionary<string, int> dt = new ();
        for(int i = 0; i < strs.Length; i++) {
            dt[strs[i]] = dt.GetValueOrDefault(strs[i], 0) + 1;
        }
        for(int i = 0; i < strs.Length; i++) {
            if(dt[strs[i]] ==0 ) continue;

            List<string> tempRs = new();
            tempRs.Add(strs[i]);
             dt[strs[i]]--;
            for(int j = i + 1; j < strs.Length; j++) {
                if(dt[strs[j]] >0 &&
                     isAnagram(strs[i], strs[j]) ) {
                        dt[strs[j]]--;
                    tempRs.Add(strs[j]);
                }
            }

            rs.Add(tempRs);
        }


        return rs;
    }
}
