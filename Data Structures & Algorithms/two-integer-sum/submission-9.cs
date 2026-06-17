public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dt = new ();

        for(int i = 0 ; i < nums.Length; i ++) {
            
            int diff = target - nums[i];

            if(dt.ContainsKey(diff)) {
                return new int[2] { dt[diff], i};
            }

            dt.Add(nums[i], i);

        }


        return null;


    }
}
