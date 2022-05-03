//Problem:
/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
*/

// Constraints:
//1 <= s.length, t.length <= 5 * 104
//s and t consist of lowercase English letters.

using System.Collections.Generic;

namespace Solutions{
    public static class IsAnagram{
        public static bool Solve(string s, string t) {
            //Anagrams must have equal lengths
            if(s.Length != t.Length) return false;
        
            Dictionary<char,int> countS = new Dictionary<char,int>();
            Dictionary<char,int> countT = new Dictionary<char,int>();
        
            for(int i = 0; i < s.Length; i++){
                if(!countS.ContainsKey(s[i])) countS.Add(s[i],1);
                else countS[s[i]] += 1;
            
                if(!countT.ContainsKey(t[i])) countT.Add(t[i],1);
                else countT[t[i]] += 1;
            }
        
            foreach(char key in countS.Keys){
                if(!countT.ContainsKey(key))    return false;
                if(countS[key] != countT[key])  return false;
            }
        
            return true;
        }

        public static string Example(){
            return "s = \"anagram\", t = \"nagaram\"";
        }
  }
}