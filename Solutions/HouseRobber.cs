//Problem:
/*
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police
*/

// Constraints:
//1 <= nums.length <= 100
//0 <= nums[i] <= 400

using System;
using System.Collections.Generic;

namespace Solutions{
    public static class HouseRobber {
    public static int Solve(int[] nums) {
        if(nums.Length <= 0) return 0;
        if(nums.Length == 1) return nums[0];
        
        List<int> valueList = new List<int>();
        
        valueList.Add(0);       //Basecase 0: 0
        valueList.Add(nums[0]); //Basecase 1: nums[0]
        
        for(int i = 1; i < nums.Length; i++){
            valueList.Add(Math.Max(valueList[i],valueList[i-1] + nums[i]));
        }
        
        return valueList[valueList.Count-1];
    }

    public static string Example(){
        return "[2,7,9,3,1]";
    }
}
}