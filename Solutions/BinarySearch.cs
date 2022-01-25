//Problem:
/*
Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. 
If target exists, then return its index. Otherwise, return -1.
*/

// Constraints:
//1 <= nums.length <= 104
//-104 < nums[i], target < 104
//All the integers in nums are unique.
//nums is sorted in ascending order.

namespace Solutions{
    public class BinarySearch {
    public static int Solve(int[] nums, int target) {
        return BinarySearchRecur(nums,target,0,nums.Length-1);
    }
   private static int BinarySearchRecur(int[] nums,int target,int lower,int upper){
	    if(upper >= lower){
            int middle = (lower + upper)/2;
            if(nums[middle] == target){
                return middle;
            }else if(nums[middle] > target){
                return BinarySearchRecur(nums, target, lower, middle-1);
            }else{
                 return BinarySearchRecur(nums, target, middle+1, upper);
            }
        }
	    return -1;
    }

    public static string Example(){
        return "nums = [-1,0,3,5,9,12], target = 9";
    }
}
}