//Problem:
/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
*/

// Constraints:
//1 <= s.length <= 104
//s consists of parentheses only '()[]{}'.

using System.Collections.Generic;

namespace Solutions{
    public static class ValidParentheses{
        public static bool Solve(string s) {
            Stack<char> par = new Stack<char>();
            for(int i = 0; i < s.Length; i++){
                if(s[i] == '(' || s[i] == '{' || s[i] == '[' ){
                    par.Push(s[i]);
                }else{
                    if(par.Count == 0) return false;
                    switch(par.Pop()){
                        case '(':
                            if(s[i] != ')') return false;
                            break;
                        case '{':
                            if(s[i] != '}') return false;
                            break;
                        case '[':
                            if(s[i] != ']') return false;
                            break;
                        default:
                            return false;
                    }
                }
            }
            if(par.Count > 0) return false;
            return true;
        }
        public static string Example(){
            return "s = \"()[]{}\"";
        }
  }
}