//Problem:
/*
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.
*/

// Constraints:
//2 <= nums.length <= 105
//-30 <= nums[i] <= 30
//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

using System;

namespace Solutions{
    public static class ProductOfArrayExceptSelf{
        public static int[] Solve(int[] nums) {
            int[] products = new int[nums.Length];
            Array.Fill(products,1);
        
            int left = 1;
            int right = 1;
        
            for(int i = 0; i < nums.Length; i++){
                products[i] *= left;
                products[nums.Length-1-i] *= right;
                left *= nums[i];
                right *= nums[nums.Length-1-i];
            }
            return products;
        }
        public static string Example(){
            return "nums = [1,2,3,4]";
        }
  }
}