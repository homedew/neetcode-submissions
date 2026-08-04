public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var s in strs)
        {
            sb.Append($"{s.Length}#{s}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var rs = new List<string>();
        int i = 0 ;
        while(i < s.Length)
        {
            int j  = i;
            while(s[j] != '#')
            {
                j++;
            }

            int length = int.Parse(s.Substring(i , j - i));

            rs.Add(s.Substring(j + 1, length));
            i = j + 1+ length;

        }

        return rs;
   }
}
