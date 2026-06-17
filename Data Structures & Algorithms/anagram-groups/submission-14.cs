public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dt = new ();

        foreach(string s in strs) {
           int[] count = new int[26];
           foreach(char c in s) {
                count[c- 'a']++;
           }

           string key = string.Join(",", count);

           if(!dt.ContainsKey(key)) {
                dt[key] = new List<string>();
           }

            dt[key].Add(s);
        }


        return dt.Values.ToList<List<string>>();


    }
}
