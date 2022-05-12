//Problem:
/*
Evaluate the value of an arithmetic expression in Reverse Polish Notation.

Valid operators are +, -, *, and /. Each operand may be an integer or another expression.

Note that division between two integers should truncate toward zero.

It is guaranteed that the given RPN expression is always valid. That means the expression would always evaluate to a result, and there will not be any division by zero operation.
*/

// Constraints:
//1 <= tokens.length <= 104
//tokens[i] is either an operator: "+", "-", "*", or "/", or an integer in the range [-200, 200].

using System;
using System.Collections.Generic;

namespace Solutions{
    public static class EvalRPN{
        public static int Solve(string[] tokens) {
            Stack<int> stack = new Stack<int>();
        
            for(int i = 0; i < tokens.Length;i++){
                switch(tokens[i]){
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case "-":
                        stack.Push(-stack.Pop() + stack.Pop());
                        break;
                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case "/":
                        int num1 = stack.Pop();
                        int num2 = stack.Pop();
                        stack.Push(num2 / num1);
                        break;
                    default:
                        stack.Push(Convert.ToInt32(tokens[i]));
                        break;
                }
            }
            return stack.Pop();
        }
        public static string Example(){
            return "tokens = [\"2\",\"1\",\"+\",\"3\",\"*\"]";
        }
  }
}