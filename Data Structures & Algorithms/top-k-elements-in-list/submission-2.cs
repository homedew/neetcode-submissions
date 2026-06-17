public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dt = new ();
        int[] rs = new int[k];

        foreach(int n in nums) {
            dt[n] = dt.GetValueOrDefault(n, 0) + 1;
        }

        dt = dt.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, x=>x.Value);

        List<int[]> arr = dt.Select( x => new int[] {x.Value, x.Key}).ToList();
        arr.Sort((a, b) => b[0].CompareTo(a[0]));

        for(int i = 0; i < k; i++) {
            rs[i] = arr[i][1];
        }    

        return rs;
    }
}
