//Problem:
/*
There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.
*/

// Constraints:
//1 <= m, n <= 100

namespace Solutions{
    public static class UniquePaths{
    public static int Solve(int m, int n) {

        int[,] ways = new int[m,n];
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(j == 0 || i == 0) {
                    ways[i,j] = 1;
                }
                else{
                    ways[i,j] = ways[i-1,j] + ways[i,j-1];
                    }
            }
        }
        return ways[m-1,n-1];
    }

    public static string Example(){
        return "m = 3, n = 7";
    }
}
}