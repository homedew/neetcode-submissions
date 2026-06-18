public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dt = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            char[] c = s.ToCharArray();
            Array.Sort(c);

            string newStr = new string(c);

            if (!dt.ContainsKey(newStr)) {
                dt[newStr] = new List<string>();
            }

            dt[newStr].Add(s);
        }

        return dt.Values.ToList<List<string>>();
    }
}
