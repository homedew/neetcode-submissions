public class Solution {

    public string Encode(IList<string> strs) {
        string rs ="";
        foreach(var str in strs) {
            rs += str.Length + "#" + str;
        }

        return rs;
    }

    public List<string> Decode(string s) {
        List<string> rs = new List<string>();
        int i =0;
        while(i< s.Length) {
            int j = i;

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
