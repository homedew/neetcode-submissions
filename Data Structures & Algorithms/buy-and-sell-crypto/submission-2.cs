public class Solution {
    public int MaxProfit(int[] prices) {
        int rs = 0;
        int n = prices.Length;

        for(int i = 0; i < n; i++)
        {
            for(int j  = i + 1; j < n ;j++)
            {
                if(prices[j] > prices[i])
                {
                    rs = Math.Max(rs, prices[j] - prices[i]);
                }
            }
        }

        return rs;
    }
}
