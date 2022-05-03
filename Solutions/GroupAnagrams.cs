//Problem:
/*
Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
*/

// Constraints:
//1 <= strs.length <= 104
//0 <= strs[i].length <= 100
//strs[i] consists of lowercase English letters.

using System.Collections.Generic;

namespace Solutions{
    public static class GroupAnagrams{
        public static IList<IList<string>> Solve(string[] strs) {
            List<IList<string>> result = new List<IList<string>>();
            Dictionary<string, List<string>> dictionary = new Dictionary<string,List<string>>();
        
            //Group all anagrams by frequency of letters
            foreach(string str in strs){
                char[] freq = new char[26];
                foreach(char c in str.ToCharArray()){
                    freq[c-'a']++;
                }
                string temp = new string(freq);
                if(!dictionary.ContainsKey(temp)) dictionary[temp] = new List<string>();
                dictionary[temp].Add(str);
            }
        
            //Add all the groupings to result list
            foreach(string key in dictionary.Keys){
                result.Add(dictionary[key]);
            }
        
            return result;
        }

        public static string Example(){
            return "strs = [\"eat\",\"tea\",\"tan\",\"ate\",\"nat\",\"bat\"]";
        }
  }
}