//Problem:
/*
You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.

Return the length of the longest substring containing the same letter you can get after performing the above operations.
*/

// Constraints:
//1 <= s.length <= 105
//s consists of only uppercase English letters.
//0 <= k <= s.length


using System;
using System.Linq;
using System.Collections.Generic;

namespace Solutions{
    public static class CharacterReplacement{
        public static int Solve(string s, int k) {
            Dictionary<char,int> count = new Dictionary<char,int>();
            int result = 0;
            int left = 0;
        
            for(int right = 0; right < s.Length; right++){
            
                if(!count.ContainsKey(s[right])) count.Add(s[right],0);
                count[s[right]] = count[s[right]] + 1;
            
                while(right - left + 1 - count.Values.Max() > k){
                    count[s[left]] = count[s[left]] - 1;
                    left++;
                }
            
                result = Math.Max(result, right - left + 1);
            }
            return result;
        }
        public static string Example(){
            return "s = \"ABAB\", k = 2";
        }
  }
}