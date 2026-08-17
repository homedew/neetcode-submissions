public class Solution {
    public int FindMin(int[] nums) {
        int rs = nums[0];
        int left = 0;
        int right = nums.Length - 1;

        while( left <= right)
        {
            if(nums[left] < nums[right])
            {
                rs = Math.Min(rs, nums[left]);
                break;
            }

            int m = (left + right) / 2;

            rs = Math.Min(rs, nums[m]);

            if(nums[m] >= nums[left])
            {
                left = m + 1;
            } else {
                right = m - 1;
            }
        }

        return rs;
    }
}
