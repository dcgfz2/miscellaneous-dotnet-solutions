//Problem:
/*
Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
*/

// Constraints:
//board.length == 9
//board[i].length == 9
//board[i][j] is a digit 1-9 or '.'

using System.Collections.Generic;

namespace Solutions{
    public static class IsValidSudoku{
        public static bool Solve(char[][] board) {
            HashSet<string> hashset = new HashSet<string>();
        
            for(int i = 0; i < 9; i++){
                for(int j = 0; j < 9; j++){
                    if(board[i][j] != '.'){
                        if(hashset.Contains("row"+ i + board[i][j]) || hashset.Contains("col"+ j + board[i][j]) || hashset.Contains("box"+ (i/3) + (j/3) + board[i][j])){
                            return false;
                        }
                        hashset.Add("row" + i + board[i][j]);
                        hashset.Add("col" + j + board[i][j]);
                        hashset.Add("box" + (i/3) + (j/3) + board[i][j]);
                    }
                }
            }
            return true;
        }
        public static string Example(){
            return "!NOTE USE 9x9: board = [[5,3,.,.,7,.,.,.,.],[6,.,.,1,9,5,.,.,.],[.,9,8,.,.,.,.,6,.],[8,.,.,.,6,.,.,.,3],[4,.,.,8,.,3,.,.,1],[7,.,.,.,2,.,.,.,6],[.,6,.,.,.,.,2,8,.],[.,.,.,4,1,9,.,.,5],[.,.,.,.,8,.,.,7,9]]";
        }
  }
}