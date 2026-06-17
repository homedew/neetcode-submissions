public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        int n = nums.Length;

        for(int i = 0; i < n; i++) {
            for(int j = i + 1; j < n; j++) {
                if(nums[i] + nums[j] == target) {
                    result[0] = i;
                    result[1] = j;

                    return result;
                }
            }
        }

        return result;
    }
}
