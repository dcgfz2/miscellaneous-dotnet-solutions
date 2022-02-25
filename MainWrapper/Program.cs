using System;
using Solutions;

class Program{
    static void Main(string[] args){
        
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Longest Common Prefix");
        Console.WriteLine("2) Pascal's Triangle");
        Console.WriteLine("3) Binary Search");
        Console.WriteLine("4) Two Sum");
        Console.WriteLine("5) Climbing Stairs");
        Console.WriteLine("6) Fibonacci");
        Console.WriteLine("7) Best Sightseeing Pair");
        Console.WriteLine("8) House Robber");
        Console.WriteLine("9) Coin Change");


        switch(Console.ReadLine()){
            case "1":
                Console.WriteLine("Example Input: " + LongestCommonPrefix.Example());
                Console.WriteLine(LongestCommonPrefix.Solve(TakeArray<string>()));
                break;
            case "2":
                Console.WriteLine("Example Input: " + PascalsTriangle.Example());
                Console.WriteLine(DisplayNestedList(PascalsTriangle.Solve(TakeInt())));
                break;
            case "3":
                Console.WriteLine("Example Input: " + BinarySearch.Example());
                Console.WriteLine(BinarySearch.Solve(TakeArray<int>(),TakeInt()));
                break;
            case "4":
                Console.WriteLine("Example Input: " + TwoSum.Example());
                foreach(var index in TwoSum.Solve(TakeArray<int>(),TakeInt())){
                    Console.WriteLine("Index of value: " + index);
                }
                break;
            case "5":
                Console.WriteLine("Example Input: " + ClimbingStairs.Example());
                Console.WriteLine(ClimbingStairs.Solve(TakeInt()));
                break;
            case "6":
                Console.WriteLine("Example Input: " + Fibonacci.Example());
                Console.WriteLine(Fibonacci.Solve(TakeInt()));
                break;
            case "7":
                Console.WriteLine("Example Input: " + BestSightseeingPair.Example());
                Console.WriteLine(BestSightseeingPair.Solve(TakeArray<int>()));
                break;
            case "8":
                //Console.WriteLine("Example Input: " + HouseRobber.Example());
                //Console.WriteLine(HouseRobber.Solve(TakeArray<int>()));
                break;
            case "9":
                Console.WriteLine("Example Input: " + CoinChange.Example());
                Console.WriteLine(CoinChange.Solve(TakeArray<int>(),TakeInt()));
                break;
            default:
                Console.WriteLine("Not a valid option");
                break;
        }
    }

    private static T[] TakeArray<T>(){
        int size;
       T[] array;

        Console.WriteLine("How many items?:");//Limit 200
        size = int.Parse(Console.ReadLine());
        if(size < 0) size = 0;
        if(size > 200) size = 200;

        Console.WriteLine("Enter items:");
        array = new T[size];

        for(int i = 0; i < size; i++){
          array[i] = (T)Convert.ChangeType(Console.ReadLine(),typeof(T));
        }
         return array;
    }

    private static int TakeInt(){
        Console.WriteLine("Enter a integer:");
        return int.Parse(Console.ReadLine());
    }

    private static string DisplayNestedList(IList<IList<int>> lists){
        string output = "{ ";
        for(int i = 0; i < lists.Count(); i++){
            output+="[";
            for(int j = 0; j < lists[i].Count(); j++){
                output+=lists[i][j];
                if(j != lists[i].Count()-1){
                    output+=", ";
                }
            }
            output+="]";
            if(i != lists.Count()-1){
                    output+=", ";
                }
        }
        output+=" }";
        return output;
    }
}
