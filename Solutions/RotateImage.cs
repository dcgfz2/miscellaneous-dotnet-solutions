//Problem:
/*
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.
*/

// Constraints:
//n == matrix.length == matrix[i].length
//1 <= n <= 20
//1000 <= matrix[i][j] <= 1000

using System;

namespace Solutions{
    public static class RotateImage {
    public static int[][] Solve(int[][] matrix) {
        for(int i = 0; i < matrix[0].Length-1; i++){
            for(int j = i; j < matrix[0].Length-1-i; j++){
                 rotateLayer(matrix,i,j);
            }
        } 
        return matrix;
    }

    private static void rotateLayer(int[][] matrix, int x, int y){
        int temp = matrix[x][y];
        matrix[x][y] = matrix[matrix[x].Length-1-y][x];
        matrix[matrix[x].Length-1-y][x] = matrix[matrix[x].Length-1-x][matrix[x].Length-1-y];
        matrix[matrix[x].Length-1-x][matrix[x].Length-1-y] = matrix[y][matrix[x].Length-1-x];
        matrix[y][matrix[x].Length-1-x] = temp;
    }

    public static string Example(){
        return "matrix = [[1,2,3],[4,5,6],[7,8,9]]";
    }
}
}