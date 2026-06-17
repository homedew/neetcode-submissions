public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dt = new ();

        foreach(var str in strs) {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);

            string sorted = new string(charArray);
            

            if(!dt.ContainsKey(sorted)) {
                dt[sorted] = new List<string>();
            }

            dt[sorted].Add(str);
        }

        return dt.Values.ToList<List<string>>();
    }
}
