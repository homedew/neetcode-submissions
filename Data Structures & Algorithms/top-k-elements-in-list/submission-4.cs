public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dt = new ();
        List<int>[] freq  = new List<int>[nums.Length + 1];

        for(int i =0 ; i< freq.Length; i++) {
            freq[i] = new List<int>();
        }

        int[] rs = new int[k];

        foreach(int n in nums) {
            dt[n] = dt.GetValueOrDefault(n, 0) + 1;
        }

        foreach(var entry in dt) {
            freq[entry.Value].Add(entry.Key);
        }  
        int index = 0;

        for(int i = freq.Length - 1; i > 0 && index <k; i--) {
            foreach(int n in freq[i]){
                rs[index++] = n;
                if(index == k) {
                    return rs;
                }
            }
           
        }

        return rs;
    }
}
