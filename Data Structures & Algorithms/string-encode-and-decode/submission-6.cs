public class Solution {

    public string Encode(IList<string> strs) {
        string rs = "";
        
        foreach(var s in strs) {
            rs += s.Length + "#" + s;
        }

        return rs;
    }
    // 4#neet4#code4#love3#you

    public List<string> Decode(string s) {
        List<string> rs = new ();
        int i =0;

        while( i < s.Length) {
            int j  = i;

            while(s[j] != '#') {
                j++;
            }

            int len = int.Parse(s.Substring(i, j - i));
            i = j  + 1;
            j = i + len;

            rs.Add(s.Substring(i, len));
            i = j;
        }

        return rs;
       
   }
}
