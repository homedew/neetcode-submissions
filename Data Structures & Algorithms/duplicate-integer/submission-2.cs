public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> hash = new();

       foreach(int num in nums) {
        if(hash.Contains(num)) {
            return true;
        } else {
            hash.Add(num);
        }
       }

        return false;
    }
}
