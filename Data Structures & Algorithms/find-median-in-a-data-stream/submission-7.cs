public class MedianFinder {
    PriorityQueue<int, int> smallHeap;
    PriorityQueue<int, int> largeHeap;


    public MedianFinder() {
        largeHeap = new PriorityQueue<int,int>();
        smallHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b)=> (b - a)));
    }
    
    public void AddNum(int num) {
        if(largeHeap.Count !=0 && largeHeap.Peek() < num)
        {
            largeHeap.Enqueue(num,num);
        } else 
        {
            smallHeap.Enqueue(num, num);
        }

        if(smallHeap.Count > largeHeap.Count + 1)
        {
            int val = smallHeap.Dequeue();
            largeHeap.Enqueue(val, val);
        } else if(largeHeap.Count > smallHeap.Count + 1)
        {
            int val = largeHeap.Dequeue();
            smallHeap.Enqueue(val, val);
        }
    }
    
    public double FindMedian() {
        if(smallHeap.Count > largeHeap.Count ){
            return smallHeap.Peek();
        }   else if(largeHeap.Count > smallHeap.Count)
        {
            return largeHeap.Peek();
        }
        return (largeHeap.Peek() + smallHeap.Peek())/ (2.0);
    }
}
