public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1, rs= 0;

        while(r < prices.Length) {
            if(prices[l] < prices[r]) {
                int profit = prices[r] - prices[l];
                rs= Math.Max(rs, profit);
            } else {
                l = r;
            }

            r++;
        }

        return rs;
    }
}
