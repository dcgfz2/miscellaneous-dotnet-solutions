//Problem:
/*
Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.

A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. The tree tree could also be considered as a subtree of itself.
*/

// Constraints:
//The number of nodes in the root tree is in the range [1, 2000].
//The number of nodes in the subRoot tree is in the range [1, 1000].
//-104 <= root.val <= 104
//-104 <= subRoot.val <= 104

using Support;

namespace Solutions{
    public static class IsSubtree{
    public static bool Solve(TreeNode root, TreeNode subRoot) {
        if(root == null) return false;
        if(IsEqual(root,subRoot)) return true;
        
        return Solve(root.left,subRoot) || Solve(root.right,subRoot);
    }
     public static bool IsEqual(TreeNode root, TreeNode subRoot){
        if(root == null && subRoot == null) return true;
        if(root == null || subRoot == null) return false;
        
        return root.val == subRoot.val && IsEqual(root.left,subRoot.left) && IsEqual(root.right,subRoot.right);
    }

    public static string Example(){
        return "root = [3,4,5,1,2], subRoot = [4,1,2]";
    }
}
}