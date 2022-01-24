//Problem:
/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
*/

// Constraints:
// 1 <= strs.length <= 200
// 0 <= strs[i].length <= 200
// strs[i] consists of only lower-case English letters.

public class LongestCommonPrefix {
    public string Solve(string[] strs) {
        if (strs.Length == 0) return "";
        
        for(int i = 0; i < strs[0].Length; i++){
            char letter = strs[0][i];
            for(int j = 1; j < strs.Length; j++){
                if(i == strs[j].Length || strs[j][i]!= letter){
                    return strs[0].Substring(0, i);
                }
            }
        }
        return strs[0];
    }
}