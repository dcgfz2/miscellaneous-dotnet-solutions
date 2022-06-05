//Problem:
/*
Given the root of a binary tree, return the length of the diameter of the tree.

The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.

The length of a path between two nodes is represented by the number of edges between them.
*/

// Constraints:
//The number of nodes in the tree is in the range [1, 104].
//-100 <= Node.val <= 100

using System;
using Support;

namespace Solutions{
    public static class DiameterOfBinaryTree {
    public static int Solve(TreeNode root) {
        int result = 0;
        
        int MaxDepth(TreeNode node){
            if(node == null) return 0;
        
            int left = MaxDepth(node.left);
            int right = MaxDepth(node.right);
        
            result = Math.Max(result,left+right);
            
            return 1 + Math.Max(left,right);
        }
        
        MaxDepth(root);
        return result;
    }

    public static string Example(){
        return "root = [1,2,3,4,5]";
    }
}
}