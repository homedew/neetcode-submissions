public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0, sell = 1;
        int rs =0;
        while(sell < prices.Length)
        {
            if(prices[sell] > prices[buy])
            {
                rs = Math.Max(rs, prices[sell] - prices[buy]);
            } else 
            {
                buy = sell;
            }

            sell++;
            
        }

        return rs;
    }
}
