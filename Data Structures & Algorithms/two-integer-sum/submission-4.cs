public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dt = new();

        for(int i = 0 ; i < nums.Length; i++) {
            dt[nums[i]] = i;
        }

        for(int i = 0 ; i < nums.Length; i ++) {
            int diff = target - nums[i];

            if(dt.ContainsKey(diff) && dt[diff] != i) {
                return new int[] {i, dt[diff]};
            }
        }

        return new int[0];
    }
}
