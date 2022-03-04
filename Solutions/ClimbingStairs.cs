//Problem:
/*
You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
*/

// Constraints:
//1 <= n <= 45

using System.Collections.Generic;

namespace Solutions{
    public static class ClimbingStairs {
    public static int Solve(int n) {
        List<int> ways = new List<int>();
        ways.Add(1); //Basecase 0: n = 1
        ways.Add(2); //Basecase 1: n = 2
        
        for(int i = 2; i < n; i++){
            ways.Add(ways[i-1]+ways[i-2]);
        }
        return ways[n-1];
}

    public static string Example(){
        return "3";
    }
  }
}