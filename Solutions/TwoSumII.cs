//Problem:
/*
Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

The tests are generated such that there is exactly one solution. You may not use the same element twice.

Your solution must use only constant extra space.
*/

// Constraints:
//2 <= numbers.length <= 3 * 104
//-1000 <= numbers[i] <= 1000
//numbers is sorted in non-decreasing order.
//-1000 <= target <= 1000
//The tests are generated such that there is exactly one solution.


namespace Solutions{
    public static class TwoSumII{
        public static int[] Solve(int[] numbers, int target) {
            int[] result = new int[2];
            int p1 = 0;
            int p2 = numbers.Length-1;;
        
            while(p1 < p2){
                int sum = numbers[p1] + numbers[p2];
                if(sum == target){
                    result[0] = p1+1;
                    result[1] = p2+1;
                    return result;
                }else if(sum < target) p1++;
                else p2--;
            }
            return result;
        }
        public static string Example(){
            return "numbers = [2,7,11,15], target = 9";
        }
  }
}