//Problem:
/*
Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

You must write an algorithm that runs in O(n) time.
*/

// Constraints:
//0 <= nums.length <= 105
//-109 <= nums[i] <= 109

using System;
using System.Collections.Generic;

namespace Solutions{
    public static class LongestConsecutiveSequence{
        public static int Solve(int[] nums) {
            HashSet<int> hashset = new HashSet<int>(nums);
            int longest = 0;
        
            foreach(int num in nums){
                //Check if number is the start of a sequence
                if(!hashset.Contains(num-1)){
                    int length = 0;
                    while(hashset.Contains(num+length)) length++;
                    longest = Math.Max(length,longest);
                }
            }
        
            return longest;
        }
        public static string Example(){
            return "[100,4,200,1,3,2]";
        }
  }
}