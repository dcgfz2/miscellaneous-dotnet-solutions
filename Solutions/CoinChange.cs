//Problem:
/*
You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

You may assume that you have an infinite number of each kind of coin.
*/

// Constraints:
//1 <= coins.length <= 12
//1 <= coins[i] <= 231 - 1
//0 <= amount <= 104

using System;
using System.Linq;

namespace Solutions{
    public static class CoinChange {
    public static int Solve(int[] coins, int amount) {

        int[] minCoins = Enumerable.Repeat(amount+1, amount+1).ToArray();
        minCoins[0] = 0;
        
        for(int i = 1; i < minCoins.Length;i++){
            for(int c = 0; c < coins.Length; c++){
                if(coins[c] <= i) minCoins[i] = Math.Min(minCoins[i],1+minCoins[i-coins[c]]);
            }
        }
        return minCoins[amount] != amount+1 ? minCoins[amount] : -1;
    }

    public static string Example(){
        return "[1,2,5], amount = 11";
    }
}
}