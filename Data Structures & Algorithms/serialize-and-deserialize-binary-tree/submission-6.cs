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

public class Codec {

    // Encodes a tree to a single string.
    private void DfsSer(TreeNode root, List<string> vals)
    {
        if(root == null)
        {
            vals.Add("N");
            return;
        }
        vals.Add(root.val.ToString());
        DfsSer(root.left, vals);
        DfsSer(root.right, vals);

        
    }
    public string Serialize(TreeNode root) {
        List<string> vals = new List<string>();

        DfsSer(root,vals);

        return String.Join(',', vals);
    }

    public TreeNode DfsDes(string[] vals, ref int i)
    {
        if(vals[i] == "N")
        {
            i++;
            return null;
        }

        TreeNode node = new TreeNode(Int32.Parse(vals[i]));
        i++;
        node.left = DfsDes(vals, ref i);
        node.right = DfsDes(vals, ref i);

        return node;
    }

    // Decodes your encoded data to tree.

    public TreeNode Deserialize(string data) {
        int i = 0;
        return DfsDes(data.Split(','), ref  i );


    }
}
