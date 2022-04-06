//Problem:
/*
Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value
*/

// Constraints:
//The number of nodes in both trees is in the range [0, 100].
//-104 <= Node.val <= 104

using System;
using Support;

namespace Solutions{
    public static class IsSameTree {
    public static bool Solve(TreeNode p, TreeNode q) {
        if(p == null && q == null) return true;
        if(p == null || q == null) return false;
        if(p.val == q.val){
            return Solve(p.left, q.left) && Solve(p.right, q.right);
        }
        return false;
    }

    public static string Example(){
        return "p = [1,2,3], q = [1,2,3]";
    }
}
}