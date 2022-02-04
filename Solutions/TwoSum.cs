//Problem:
/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.
*/

// Constraints:
//2 <= nums.length <= 104
//-109 <= nums[i] <= 109
//-109 <= target <= 109
//Only one valid answer exists.

using System.Collections.Generic;

namespace Solutions{
    public static class TwoSum {
    public static int[] Solve(int[] nums, int target) {

        int[] result = new int[2];
        Dictionary<int,int> hashTable = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            int sum = target - nums[i];
            if(hashTable.ContainsKey(sum)){
                result[0] = hashTable[sum];
                result[1] = i;
                return result;
            }else{
               if(!hashTable.ContainsKey(nums[i])) hashTable.Add(nums[i],i);
            }
        }
        return result;
    }

    public static string Example(){
        return "[2,7,11,15], target = 9";
    }
}
}