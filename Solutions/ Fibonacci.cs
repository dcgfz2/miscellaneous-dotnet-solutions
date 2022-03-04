//Problem:
/*
The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1
*/

// Constraints:
//0 <= n <= 30

using System.Collections.Generic;

namespace Solutions{
    public static class Fibonacci {
    public static int Solve(int n) {

        List<int> fibonacci = new List<int>();
        fibonacci.Add(0); // Basecase: 0
        fibonacci.Add(1); // Basecase: 1
        
        for(int i = 2; i < n+1; i++){
            fibonacci.Add(fibonacci[i-1] + fibonacci[i-2]);
        }
        return fibonacci[n];
    }

    public static string Example(){
        return "n = 3";
    }
}
}