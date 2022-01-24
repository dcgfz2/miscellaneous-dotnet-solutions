using System;
using Solutions;

class Program{
    static void Main(string[] args){
        
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Longest Common Prefix");
        Console.WriteLine("2) Pascal's Triangle");

        switch(Console.ReadLine()){
            case "1":
                Console.WriteLine("Example Input: " + LongestCommonPrefix.Example());
                Console.WriteLine(LongestCommonPrefix.Solve(TakeStringArray()));
                break;
            case "2":
                Console.WriteLine("Example Input: " + PascalsTriangle.Example());
                Console.WriteLine(DisplayNestedList(PascalsTriangle.Solve(TakeInt())));
                break;
            default:
                Console.WriteLine("Not a valid option");
                break;
        }
    }

    private static string[] TakeStringArray(){
        int size;
        string[] array;

        Console.WriteLine("How many words?:");//Limit 200
        size = int.Parse(Console.ReadLine());
        if(size > 200) size = 200;

        Console.WriteLine("Enter words:");
        array = new string[size];

        for(int i = 0; i < size; i++){
          array[i] = Console.ReadLine();
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
