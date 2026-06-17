public class Solution {

    public string Encode(IList<string> strs) {
        string rs = "";
        foreach(var s in strs) {
            rs+= s.Length + "#" + s;
        }

        return rs;
    }

    public List<string> Decode(string s) {
        List<string> rs = new ();
        int i =0, j = 0;

        while(i < s.Length) {
            j = i;
            while(s[j] != '#') {
                j++;
            }


            int length = int.Parse(s.Substring(i, j - i));

            i = j + 1;
            j = i + length;

            rs.Add(s.Substring(i, length));

            i = j;
        }

        return rs;
   }
}
