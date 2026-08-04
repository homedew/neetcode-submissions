public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[]rs = new int[nums.Length];

        Array.Fill(rs,1);

        for( int i = 1; i <rs.Length; i++)
        {
            rs[i] = rs[i -1] * nums[i - 1];
        }

        int postFix = 1;

        for(int i = rs.Length - 1; i>=0; i--) 
        {
            rs[i] *= postFix;
            postFix*= nums[i];
        }

        return rs;
    }
}
