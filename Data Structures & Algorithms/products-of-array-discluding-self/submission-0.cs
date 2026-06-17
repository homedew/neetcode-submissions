public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] rs = new int[n];

        Array.Fill(rs, 1);

        for(int i = 1; i < n ; i ++) {
            rs[i] = rs[i -1] * nums[i - 1];
        }

        int postFix = 1;

        for(int i = n -1;  i >=0; i--) {
            rs[i] *=postFix;
            postFix *= nums[i];
        }

        return rs;
    }
}
