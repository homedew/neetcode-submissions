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
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode curr = root;

        while(s.Count !=0 || curr !=null)
        {
            while(curr !=null)
            {
                s.Push(curr);
                curr = curr.left;
            }

            curr = s.Pop();
            k--;
            if(k == 0) return curr.val;
            curr = curr.right;
        }

        return -1;
    }
}
