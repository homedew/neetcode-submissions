public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs = new HashSet<int>(nums);

        int streak = 0;
        int current = 0;

        foreach(var n in nums) {
           //n i dau chuoi  
            if(!hs.Contains(n - 1)) {
                int length = 1;
                while(hs.Contains(n + length)) {
                    length++;
                }

                streak = Math.Max(streak, length);
            }
        }

        return streak;
    }
}
