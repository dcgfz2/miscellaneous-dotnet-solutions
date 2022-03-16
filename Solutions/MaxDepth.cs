//Problem:
/*
Given the root of a binary tree, return its maximum depth.

A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
*/

// Constraints:
//The number of nodes in the tree is in the range [0, 104].
//-100 <= Node.val <= 100

using System;
using Support;

namespace Solutions{
    public static class MaxDepth {
    public static int Solve(TreeNode root) {
        if(root == null) return 0;
        
        int depL = Solve(root.left);
        int depR = Solve(root.right);
        
        return Math.Max(depL,depR) + 1;
    }

    public static string Example(){
        return "root = [3,9,20,null,null,15,7]";
    }
}
}