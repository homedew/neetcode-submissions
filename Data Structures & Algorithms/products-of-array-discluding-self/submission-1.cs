public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //  1 2 4 6
        //  0 1 2 3

        //  prefix[i] = prefix[i - 1] * nums[i - 1]

        //  1 1 1 1
        //  prefix[1] = 1 * 1 = 1
        //  prefix[2] = 1 * 2 = 2
        //  prefix[3] = 2 * 4 = 8
        //  prefix[4] = 8 * 6 = 48

        //     postFix = 1
        //     rs[3] = 48 => postFix = nums[3] = 1 * 6 = 6
        //     rs[2] =
        //     rs

        int[] rs  = new int[nums.Length];


        Array.Fill(rs, 1);

        for(int i = 1  ; i < rs.Length; i ++ ) {
            rs[i] = rs[i - 1] * nums[i- 1];
        }

        int postFix = 1;
        for(int i = rs.Length - 1; i >=0; i--) {
            rs[i] *= postFix;
            postFix*= nums[i];
        }

        return rs;

    }
}
