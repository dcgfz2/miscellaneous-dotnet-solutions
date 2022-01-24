//Problem:
/*Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it
https://en.wikipedia.org/wiki/Pascal's_triangle
*/

// Constraints:
//1 <= numRows <= 30

using System.Collections.Generic;
public static class PascalsTriangle {
    public static IList<IList<int>> Solve(int numRows) {
        IList<IList<int>> pascal = new List<IList<int>>();
             
        for(int i = 0; i < numRows; i++){
            pascal.Add(new List<int>());//Add new row
            
            for(int j = 0; j < i+1; j++){
                if(j == 0){         //First element of row is always 1
                    pascal[i].Add(1);
                }
                else if(j == i){    //Last element of row is always 1
                    pascal[i].Add(1);
                }
                else{
                    pascal[i].Add(pascal[i-1][j-1]+pascal[i-1][j]);
                }
            }
        }
        return pascal;
    }

    public static string Example(){
        return "5";
    }
    
}