//Problem:
/*
Write an efficient algorithm that searches for a value target in an m x n integer matrix matrix. This matrix has the following properties:

Integers in each row are sorted from left to right.
The first integer of each row is greater than the last integer of the previous row.
*/

// Constraints:
//m == matrix.length
//n == matrix[i].length
//1 <= m, n <= 100
//-104 <= matrix[i][j], target <= 104

namespace Solutions{
    public static class BinarySearchMatrix{
        public static bool Solve(int[][] matrix, int target) {
            int start = 0;
            int end = matrix.Length-1;
        
            while(start <= end){
                int row = (start+end)/2;
                if(target > matrix[row][matrix[0].Length-1]) start = row + 1;
                else if(target < matrix[row][0]) end = row - 1;
                else break;
            }
        
            int rowIndex = (start+end)/2;
            start = 0;
            end = matrix[rowIndex].Length-1;
        
            while(start <= end){
                int mid = (start+end)/2;
                if(target > matrix[rowIndex][mid]) start = mid + 1;
                else if(target < matrix[rowIndex][mid]) end = mid - 1;
                else return true;
            }
            return false;
        }
        public static string Example(){
            return "matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3";
        }
  }
}