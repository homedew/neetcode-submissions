public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dictionary  = new Dictionary<int,int>();
        for(int i = 0 ; i< nums.Length; i++) {
            dictionary[nums[i]] = dictionary.GetValueOrDefault(nums[i], 1)+ 1;
        }

        var heap = new PriorityQueue<int, int>();
        
        foreach(var entry in dictionary)
        {
            heap.Enqueue(entry.Key, entry.Value);
            if(heap.Count >k){
                heap.Dequeue();
            }
        }

        var res= new int[k];
        for(int i = 0; i< k;i++)
        {
            res[i] = heap.Dequeue();
        }

        return res;
    }
}
