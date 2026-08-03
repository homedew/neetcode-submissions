public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dt = new Dictionary<string, List<string>>();

        foreach(string s in strs) {
            char[] c = s.ToCharArray();
            Array.Sort(c);
            string sortString = new string(c);

            if (!dt.ContainsKey(sortString)) 
            {
                dt[sortString] = new List<string>();                
            }

            dt[sortString].Add(s);

        }

        

        return dt.Values.ToList();
    }
}
