//Problem:
/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.
*/

// Constraints:
//1 <= s.length <= 2 * 105
//s consists only of printable ASCII characters.

using System;
using System.Linq;

namespace Solutions{
    public static class IsPalindrome{
        public static bool Solve(string s) {
            string alphanumeric = "";
        
            //Remove spaces and punctuation
            for(int i = 0; i < s.Length; i++){
                if(Char.IsLetterOrDigit(s[i])) alphanumeric += Char.ToLower(s[i]);
            }
        
            //String is a palidrome if it is identical after being reversed
            return alphanumeric.Equals(new string(alphanumeric.Reverse().ToArray()));
        }
        public static string Example(){
            return "s = \"A man, a plan, a canal: Panama\"";
        }
  }
}