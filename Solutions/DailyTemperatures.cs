//Problem:
/*
Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.
*/

// Constraints:
//1 <= temperatures.length <= 105
//30 <= temperatures[i] <= 100

using System.Collections.Generic;

namespace Solutions{
    public static class DailyTemperatures{
        public static int[] Solve(int[] temperatures) {
            int[] result = new int[temperatures.Length];
            Stack<int> stack = new Stack<int>();
        
            for(int i = 0; i < temperatures.Length; i++){
                while(stack.Count != 0 && temperatures[stack.Peek()] < temperatures[i]){
                    int index = stack.Pop();
                    result[index] = i - index;
                }
                stack.Push(i);
            }
            return result;
        }
        public static string Example(){
            return "[73,74,75,71,69,72,76,73]";
        }
  }
}