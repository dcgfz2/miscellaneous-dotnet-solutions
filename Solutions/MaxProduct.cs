//Problem:
/*
Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.

The test cases are generated so that the answer will fit in a 32-bit integer.

A subarray is a contiguous subsequence of the array.
*/

// Constraints:
//1 <= nums.length <= 2 * 104
//-10 <= nums[i] <= 10
//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

using System;

namespace Solutions{
    public static class MaxProduct {
    public static int Solve(int[] nums) {
        int maxProd = nums[0];
        int max = 1;
        int min = 1;
        
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                max = 1;
                min = 1;
            }
            int temp = max * nums[i];
            max = Math.Max(Math.Max(temp,min*nums[i]),nums[i]);
            min = Math.Min(Math.Min(temp,min*nums[i]),nums[i]);
            maxProd = Math.Max(maxProd,max);
        }
        return maxProd;
    }

    public static string Example(){
        return "nums = [2,3,-2,4]";
    }
    }
}