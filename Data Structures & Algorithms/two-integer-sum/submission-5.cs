public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dt = new ();

        for(int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];

            if(dt.ContainsKey(diff)) {
                return new int[] {dt[diff] ,i};
            }

            dt[nums[i]] = i;
        }

        return new int[0];
    }
}
