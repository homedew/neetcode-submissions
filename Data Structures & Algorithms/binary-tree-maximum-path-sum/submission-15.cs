/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private int res = Int32.MinValue;

    public int MaxPathSum(TreeNode root) {
        Dfs(root);
        return res;
    }

    private int Dfs(TreeNode root)
    {
        if(root == null) return 0;
        int maxLeft =  Math.Max( Dfs(root.left), 0);
        int maxRight = Math.Max( Dfs(root.right), 0);

        res = Math.Max(res, root.val + maxLeft + maxRight);
        return root.val + Math.Max(maxLeft, maxRight);
    }
}
