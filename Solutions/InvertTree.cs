//Problem:
/*
Given the root of a binary tree, invert the tree, and return its root.
*/

// Constraints:
//The number of nodes in the tree is in the range [0, 100].
//-100 <= Node.val <= 100

using Support;

namespace Solutions{
    public static class InvertTree{
    public static TreeNode Solve(TreeNode root) {
        if(root == null) return null;
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
        
        Solve(root.left);
        Solve(root.right);
        
        return root;
    }

    public static string Example(){
        return "root = [2,1,3]";
    }
}
}