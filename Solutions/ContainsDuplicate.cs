//Problem:
/*
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
*/

// Constraints:
//1 <= nums.length <= 105
//-109 <= nums[i] <= 109

using Support;
using System.Collections.Generic;

namespace Solutions{
    public static class ContainsDuplicate{
    public static bool Solve(int[] nums) {
        HashSet<int> hashset = new HashSet<int>();
        
        for(int i = 0; i < nums.Length;i++){
            if(hashset.Contains(nums[i])) return true;
            hashset.Add(nums[i]);
        }
        return false;
    }

    public static string Example(){
        return "nums = [1,2,3,1]";
    }
}
}