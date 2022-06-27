//Problem:
/*
Given a string s, return the longest palindromic substring in s.
*/

// Constraints:
//1 <= s.length <= 1000
//s consist of only digits and English letters.

using Support;

namespace Solutions{
    public static class LongestPalindrome{
        public static string Solve(string s) {
            int resultL = 0;
            int resultR = 0;
            int resultLength = 0;
        
            for(int i = 0; i < s.Length; i++){
                //Start from the center
                int left = i;
                int right = i;
                //Check if Odd length
                while(left >= 0 && right < s.Length && s[left] == s[right]){
                    if(right - left+1 > resultLength){
                        resultLength = right - left+1;
                        resultL = left;
                        resultR = right;
                    }
                    left--;
                    right++;
                }
            
                //Check if Even length
                left = i;
                right = i+1;
                while(left >= 0 && right < s.Length && s[left] == s[right]){
                    if(right - left+1 > resultLength){
                        resultLength = right - left+1;
                        resultL = left;
                        resultR = right;
                    }
                    left--;
                    right++;
                }
            }
        
            return s.Substring(resultL,resultR-resultL+1);
        }
        public static string Example(){
            return "babad";
        }
  }
}