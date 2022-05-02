//Problem:
/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
*/

// Constraints:
//1 <= prices.length <= 105
//0 <= prices[i] <= 104

using System;

namespace Solutions{
    public static class MaxProfit{
        public static int Solve(int[] prices) {
            if(prices.Length == 0) return 0;
        
            int maxProfit = 0;
            int minPrice = prices[0];
        
            for(int i = 0; i < prices.Length; i++){
                if(prices[i] > minPrice) maxProfit = Math.Max(maxProfit,prices[i]-minPrice);
                else minPrice = prices[i];
                
            }
        
            return maxProfit;
        }

        public static string Example(){
            return "prices = [7,1,5,3,6,4]";
        }
  }
}