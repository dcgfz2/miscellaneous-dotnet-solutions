//Problem:
/*
Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:

[4,5,6,7,0,1,2] if it was rotated 4 times.
[0,1,2,4,5,6,7] if it was rotated 7 times.
Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].

Given the sorted rotated array nums of unique elements, return the minimum element of this array.

You must write an algorithm that runs in O(log n) time.
*/

// Constraints:
//n == nums.length
//1 <= n <= 5000
//-5000 <= nums[i] <= 5000
//All the integers of nums are unique.
//nums is sorted and rotated between 1 and n times


namespace Solutions{
    public static class FindMinRotatedSortedArray{
        public static int Solve(int[] nums) {
            if(nums.Length == 1) return nums[0];
        
            int start = 0;
            int end = nums.Length-1;
        
            while(start != end){
                int mid = (start+end)/2;
                if(nums[mid] > nums[end]) start = mid+1;
                else end = mid; 
        }
            return nums[start];
        }

        public static string Example(){
            return "[3,4,5,1,2]";
        }
  }
}