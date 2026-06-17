public class Solution {
    public int MaxProfit(int[] prices) {
        int rs = 0;
        int l =0, r = 1;
        while(r < prices.Length) {
            if(prices[l] < prices[r]) {
                rs = Math.Max(rs, prices[r] - prices[l]);
            } else {
                l = r;
            }

            r++;
        }
        return rs;
    }
}
