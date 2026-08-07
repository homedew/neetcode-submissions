public class Solution {
    public int MaxArea(int[] heights) {
        int rs = 0;
        int right = heights.Length - 1;
        int left =0;

        while(left < right)
        {
            rs = Math.Max(rs, Math.Min(heights[left], heights[right]) * (right - left));
            if(heights[left] < heights[right])
            {
                left++;
            } else if(heights[left] > heights[right])
            {
                right--;
            } else 
            {
                right--;
            }
        }
        return rs;
    }
}
