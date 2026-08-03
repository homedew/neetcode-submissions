public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dt = new Dictionary<int, int>();

        for(int k = 0; k < nums.Length;k++) {
            var diff = target - nums[k];
            if(dt.ContainsKey(diff)) {
                return [dt[diff], k ];
            }
            dt.Add(nums[k], k);


        }

        return [0,0];
    }
}
