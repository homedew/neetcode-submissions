public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] rs = new int[k];
        
        Array.Reverse(nums);
        Dictionary<int , int > dt = new();

        foreach(var num in nums) {
            dt[num] = dt.GetValueOrDefault(num, 0) + 1;
        }

        dt = dt.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key, x=> x.Value);
        int i =0;
            foreach(var val in dt) {
                if(k ==0) {
                    return rs;
                }

                rs[i++] = val.Key;
                k--;
                
            }

    return rs;

    }
}
