public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        var rs = new List<List<int>>();
        int left = 0, right = n - 1;
        for (int i = 0; i < n; i++) {
            if(i > 0 && nums[i] == nums[i -1]) continue;
            left = i + 1;
            right = n - 1;
            while (left < right) {
                int sum = nums[left] + nums[right] + nums[i];
                if (sum > 0) {
                    right--;
                } else if (sum < 0) {
                    left++;
                } else {
                    rs.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    while(nums[left] == nums[left-1] && left < right)
                    {
                        left++;
                    }
                }

            }
        }

        return rs;
    }
}
