public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dicNum = new ();
        foreach(int n in nums) {
            if(dicNum.Contains(n)) return true;
            dicNum.Add(n);

        }

        return false;
    }
}
