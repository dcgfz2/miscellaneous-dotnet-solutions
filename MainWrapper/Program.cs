using System;
using Solutions;

class Program{
    static void Main(string[] args){
        
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Longest Common Prefix");

        switch(Console.ReadLine()){
            case "1":
                Console.WriteLine("Example Input:" + LongestCommonPrefix.Example());
                Console.WriteLine(LongestCommonPrefix.Solve(TakeStringArray()));
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
}
