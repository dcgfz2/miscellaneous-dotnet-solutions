//Problem:
/*
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
*/

// Constraints:
//1 <= n <= 8

using System.Collections.Generic;

namespace Solutions{
    public static class GenerateParentheses{
        public static IList<string> Solve(int n) {
            IList<string> result = new List<string>();
        
            void GenerateCombination(int open, int closed, string combination){
                if(open == n && closed == n){
                    result.Add(combination);
                    return;
                }
            
                if(open < n) GenerateCombination(open+1,closed,combination+"(");
                if(open > closed) GenerateCombination(open,closed+1,combination+")");
            }
        
            GenerateCombination(0,0,"");
            return result;
        }
        public static string Example(){
            return "n = 3";
        }
  }
}