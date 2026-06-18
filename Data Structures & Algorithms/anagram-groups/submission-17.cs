public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string,List<string>>();
        // m in how many item in string
        // n lenght each item in string
        // m times
        // m* n 

        foreach(string s in strs)
        {
            int[] count = new int[26];
            foreach(char c in s){
                count[c - 'a']++;
            }

        
            string key = string.Join(",", count);
            if(!res.ContainsKey(key)) {
                res[key] = new List<string>();
            }

            res[key].Add(s);
        }

        return res.Values.ToList<List<string>>();
    }
}
