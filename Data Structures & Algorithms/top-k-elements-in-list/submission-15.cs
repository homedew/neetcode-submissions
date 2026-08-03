public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        PriorityQueue<int, int > pq = new PriorityQueue<int, int>();

        Dictionary<int, int> dt = new Dictionary<int, int>();
        foreach(int num in nums)
        {
            dt[num] = dt.GetValueOrDefault(num, 1) + 1;
        }

        foreach(var entry in dt)
        {
            pq.Enqueue(entry.Key, entry.Value);
            if(pq.Count >k){
                pq.Dequeue();
            }
        }

        var rs  = new int[k];
        for(int i = 0; i < k; i++) {
            rs[i] = pq.Dequeue();
        }

        return rs;
    }
}
