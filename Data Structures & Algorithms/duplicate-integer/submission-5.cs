public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hs = new ();

        foreach(int num in nums) {
            if(hs.Contains(num)) return true;

            hs.Add(num);
        }

        return false;
    }
}
