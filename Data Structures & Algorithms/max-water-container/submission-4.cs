public class Solution {
    public int MaxArea(int[] heights) {
        int rs = 0; 


        for(int i =  0; i < heights.Length;i++) {
            int area = 0;
            for(int j = i + 1; j < heights.Length; j++) {
                area =(j - i) * Math.Min(heights[j],heights[i]);
                rs = Math.Max(rs, area);
            }

        }

        return rs;
    }
}
