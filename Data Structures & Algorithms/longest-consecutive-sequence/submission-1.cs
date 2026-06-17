public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs = new HashSet<int>(nums);
        int rs = 0;

        foreach(int n in nums) {
            int streak = 0, curr =n;

            while(hs.Contains(curr)) {
                streak++;
                curr++;
            }   

            rs = Math.Max(rs, streak);
        }

        return rs;
    }
}
