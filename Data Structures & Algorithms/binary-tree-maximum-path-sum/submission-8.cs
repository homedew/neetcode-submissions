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
    int res = Int32.MinValue;
    private int Dfs(TreeNode root)
    {
if (root == null) return 0;

        int maxLeft = Math.Max(0, Dfs( root.left));
        int maxRight = Math.Max(0, Dfs(root.right));
        
        res = Math.Max(res, root.val + maxLeft + maxRight);

        return root.val + Math.Max(maxLeft, maxRight);
    }
    public int MaxPathSum(TreeNode root) {
        Dfs(root);
        return res;
    }
}
