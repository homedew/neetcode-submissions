public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dt = new Dictionary<int, int>();

        for(int k = 0; k < nums.Length;k++) {

            if(dt.ContainsKey( target - nums[k]) && k != dt[target - nums[k]]) {
                return [dt[target - nums[k]], k ];
            }

            dt.Add(nums[k], k);

        }

        return [0,0];
    }
}
