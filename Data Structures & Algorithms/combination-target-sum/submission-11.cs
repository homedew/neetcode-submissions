public class Solution {
    private List<List<int>> rs = new List<List<int>>();
    private void Dfs(int[] nums, int i, int target, int total, List<int> arr)
    {
        if(total > target || i>=nums.Length)
        {
            return;
        }

        if(total == target) {rs.Add(arr.ToList()); return;}
        arr.Add(nums[i]);
        Dfs(nums, i, target, total + nums[i], arr);
        arr.Remove(arr.Last());
        Dfs(nums, ++i, target, total, arr);
    }
    public List<List<int>> CombinationSum(int[] nums, int target) {
        Dfs(nums, 0, target, 0, new List<int>());

        return rs;
    }
}
