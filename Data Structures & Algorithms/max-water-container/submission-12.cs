public class Solution {
    public int MaxArea(int[] heights) {
        int rs = 0 ;

        int l = 0, r = heights.Length - 1;

        while(l < r) {
            int area = (r - l) * Math.Min(heights[r], heights[l]);
            rs=  Math.Max(area, rs);

            if(heights[l] <= heights[r]) {
                l++;
            } else {
                r --;
            }
        }

        return rs;
    }
}
