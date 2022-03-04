//Problem:
/*
You are given an integer array values where values[i] represents the value of the ith sightseeing spot. Two sightseeing spots i and j have a distance j - i between them.

The score of a pair (i < j) of sightseeing spots is values[i] + values[j] + i - j: the sum of the values of the sightseeing spots, minus the distance between them.

Return the maximum score of a pair of sightseeing spots.
*/

// Constraints:
//2 <= values.length <= 5 * 104
//1 <= values[i] <= 1000

using System;

namespace Solutions{
    public static class BestSightseeingPair {
    public static int Solve(int[] values) {
        int startPoint = values[0];
        int max = startPoint+values[1]-1;
        
        for(int i = 1; i < values.Length; i++){
                max = Math.Max(max,startPoint+values[i]-i);          
                startPoint = Math.Max(startPoint,values[i] + i);
        }
        return max;
        
    }

    public static string Example(){
        return "[8,1,5,2,6]";
    }
}
}