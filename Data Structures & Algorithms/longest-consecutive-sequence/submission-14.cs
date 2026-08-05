public class Solution {
    public int LongestConsecutive(int[] nums) {
        int rs= 0;
        HashSet<int> hs = new HashSet<int>(nums);
        foreach(int num in nums)
        {
            if(!hs.Contains(num -1))
            {
                int length = 1;
                while(hs.Contains(num + length))
                {
                    length++;
                }

                rs = Math.Max(rs,length);
            }
        }

        return rs;

    }
}
