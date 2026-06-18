public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dt = new Dictionary<int,int>();

        for( int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if(dt.ContainsKey(diff)) {
                return [dt[diff], i ];
            }

            dt.Add(nums[i], i);
        }

        return null;
    }
}
