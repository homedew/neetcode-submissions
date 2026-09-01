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
    public bool IsValidBST(TreeNode root) {
        return IsValid(root, long.MinValue, long.MaxValue);
    }

    private bool IsValid(TreeNode node, long left, long right)
    {
        if(node ==null) return true;

        if(!(left<node.val && node.val< right)) return false;

        return IsValid(node.left, left, node.val) && IsValid(node.right, node.val, right);
    }
}
