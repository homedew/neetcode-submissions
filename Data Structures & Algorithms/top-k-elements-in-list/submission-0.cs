public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dt = new ();
        List<int> lst = new ();

        foreach(int n in nums) {
            dt[n] = dt.GetValueOrDefault(n, 0) + 1;
        }

        dt = dt.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, x=>x.Value);
        foreach(var d in dt) {
            if(k>0) {
                lst.Add(d.Key);
            }
            k--;
        }

        return lst.ToArray();
    }
}
