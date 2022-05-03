//Problem:
/*
Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
*/

// Constraints:
//1 <= nums.length <= 105
//k is in the range [1, the number of unique elements in the array].
//It is guaranteed that the answer is unique.

using System.Collections.Generic;

namespace Solutions{
    public static class TopKFrequent{
        public static int[] Solve(int[] nums, int k) {
            Dictionary<int,int> freq = new Dictionary<int,int>();
            int[] result = new int[k];
        
            //Count frequency of each number
            foreach(int num in nums){
                if(!freq.ContainsKey(num)) freq[num] = 1;
                else freq[num]++;
            }
            //Make Max Heap
            PriorityQueue<int,int> heap = new PriorityQueue<int,int>(new MaxCompare());
        
            //Add to Max Heap
            foreach(int key in freq.Keys){
                heap.Enqueue(key,freq[key]);
            }
        
            //Pop Max Heap k times
            for(int i = 0; i < k; i++){
                result[i] = heap.Dequeue();
            }
        
            return result;
        }

        public class MaxCompare :IComparer<int>{
            public int Compare(int x, int y) => y.CompareTo(x);
        }

        public static string Example(){
            return "nums = [1,1,1,2,2,3], k = 2";
        }
  }
}