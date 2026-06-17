public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dt = new ();

        foreach(var s in strs) {
            char[] c = s.ToCharArray();

            Array.Sort(c);

            string sortS = new string(c);

            if(!dt.ContainsKey(sortS)) {
                dt[sortS] = new List<string>();
            }

            dt[sortS].Add(s);

        }

        return dt.Values.ToList<List<string>>();
    }
}
