//Problem:
/*
Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.
*/

// Constraints:
//The number of nodes in the tree is n.
//1 <= k <= n <= 104
//0 <= Node.val <= 104

using Support;
using System.Collections.Generic;

namespace Solutions{
    public static class KthSmallest{
    public static int Solve(TreeNode root, int k) {
        int counter = 0;
        Stack<TreeNode> traverseStack = new Stack<TreeNode>();
        TreeNode cur = root;
        
        while(cur != null || traverseStack.Count > 0){
            while(cur != null){
                traverseStack.Push(cur);
                cur = cur.left;
            }
            cur = traverseStack.Pop();
            counter++;
            
            if(counter == k) return cur.val;
            cur = cur.right;
        }   
        
        return cur.val;
    }

    public static string Example(){
        return "root = [3,1,4,null,2], k = 1";
    }
}
}