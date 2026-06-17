public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        int [] result = new int[2];

        for(int i = 0 ; i < n; i++) {
            for(int j = i + 1; j < n; j++) {
                if(nums[j] + nums[i] == target) {
                   result[0] = i;
                   result[1] = j;

                   return result;
                }
            }
        }

        return result;
    }
}
