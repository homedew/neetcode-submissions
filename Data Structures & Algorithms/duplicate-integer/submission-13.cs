public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool res = false;
        HashSet<int> hs = new HashSet<int>(nums.Length);
        
        foreach(var n in nums)
        {
            if(hs.Contains(n)) return true;

            hs.Add(n);
        }
        
        return res;
    }
}