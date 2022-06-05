using System;
using Solutions;
using Support;

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
        Console.WriteLine("10) Unique Paths");
        Console.WriteLine("11) Rotate Image");
        Console.WriteLine("12) Max Depth");
        Console.WriteLine("13) Same Tree");
        Console.WriteLine("14) Invert Tree");
        Console.WriteLine("15) Is Subtree");
        Console.WriteLine("16) Lowest Common Ancestor");
        Console.WriteLine("17) KthSmallest");
        Console.WriteLine("18) Contains Duplicate");
        Console.WriteLine("19) Maximum Product Subarray");
        Console.WriteLine("20) Search in Rotated Sorted Array");
        Console.WriteLine("21) Find Min in Rotated Sorted Array");
        Console.WriteLine("22) Find Max Profit");
        Console.WriteLine("23) Is Valid Anagram");
        Console.WriteLine("24) Group Anagrams");
        Console.WriteLine("25) Top K Frequent Elements");
        Console.WriteLine("26) Product of Array Except Self");
        Console.WriteLine("27) Valid Sudoku");
        Console.WriteLine("28) Longest Consecutive Sequence");
        Console.WriteLine("29) Valid Palindrome");
        Console.WriteLine("30) Two Sum II");
        Console.WriteLine("31) Valid Parentheses");
        Console.WriteLine("32) Evaluate Reverse Polish Notation");
        Console.WriteLine("33) Daily Temperatures(Next Highest Temperature)");
        Console.WriteLine("34) Longest Repeating Character Replacement");
        Console.WriteLine("35) Generate Parentheses");
        Console.WriteLine("36) Binary Search Matrix");
        Console.WriteLine("37) Reverse Linked List");
        Console.WriteLine("38) Linked List Cycle");
        Console.WriteLine("39) Diameter Of Binary Tree");

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
                Console.WriteLine("Example Input: " + HouseRobber.Example());
                Console.WriteLine(HouseRobber.Solve(TakeArray<int>()));
                break;
            case "9":
                Console.WriteLine("Example Input: " + CoinChange.Example());
                Console.WriteLine(CoinChange.Solve(TakeArray<int>(),TakeInt()));
                break;
            case "10":
                Console.WriteLine("Example Input: " + UniquePaths.Example());
                Console.WriteLine(UniquePaths.Solve(TakeInt(),TakeInt()));
                break;
            case "11":
                Console.WriteLine("Example Input: " + RotateImage.Example());
                foreach(var array in RotateImage.Solve(TakeJaggedArray<int>())){
                    string row = "[ ";
                    
                    foreach(var item in array){
                        row += item + " ";
                    }
                    row += "]";
                    Console.WriteLine(row);
                };
                break;
            case "12":
                Console.WriteLine("Example Input: " + MaxDepth.Example());
                Console.WriteLine(MaxDepth.Solve(TakeBinaryTree()));
                break;
            case "13":
                Console.WriteLine("Example Input: " + IsSameTree.Example());
                Console.WriteLine(IsSameTree.Solve(TakeBinaryTree(),TakeBinaryTree()));
                break;
            case "14":
                Console.WriteLine("Example Input: " + InvertTree.Example());
                PrintTreeBF(InvertTree.Solve(TakeBinaryTree()));
                break;
            case "15":
                Console.WriteLine("Example Input: " + IsSubtree.Example());
                Console.WriteLine(IsSubtree.Solve(TakeBinaryTree(),TakeBinaryTree()));
                break;
            case "16":
                Console.WriteLine("Example Input: " + LowestCommonAncestor.Example());
                Console.WriteLine(LowestCommonAncestor.Solve(TakeBinaryTree(),new TreeNode(TakeInt()),new TreeNode(TakeInt())).val);
                break;
            case "17":
                Console.WriteLine("Example Input: " + KthSmallest.Example());
                Console.WriteLine(KthSmallest.Solve(TakeBinaryTree(),TakeInt()));
                break;
            case "18":
                Console.WriteLine("Example Input: " + ContainsDuplicate.Example());
                Console.WriteLine(ContainsDuplicate.Solve(TakeArray<int>()));
                break;
            case "19":
                Console.WriteLine("Example Input: " + MaxProduct.Example());
                Console.WriteLine(MaxProduct.Solve(TakeArray<int>()));
                break;
            case "20":
                Console.WriteLine("Example Input: " + SearchRotatedSortedArray.Example());
                Console.WriteLine(SearchRotatedSortedArray.Solve(TakeArray<int>(),TakeInt()));
                break;
            case "21":
                Console.WriteLine("Example Input: " + FindMinRotatedSortedArray.Example());
                Console.WriteLine(FindMinRotatedSortedArray.Solve(TakeArray<int>()));
                break;
            case "22":
                Console.WriteLine("Example Input: " + MaxProfit.Example());
                Console.WriteLine(MaxProfit.Solve(TakeArray<int>()));
                break;
            case "23":
                Console.WriteLine("Example Input: " + IsAnagram.Example());
                Console.WriteLine(IsAnagram.Solve(TakeString(),TakeString()));
                break;
            case "24":
                Console.WriteLine("Example Input: " + GroupAnagrams.Example());
                foreach(List<string> list in GroupAnagrams.Solve(TakeArray<string>())){
                    string row = "[ ";
                    
                    foreach(string item in list){
                        row += item + " ";
                    }
                    row += "]";
                    Console.WriteLine(row);
                };
                break;
            case "25":
                Console.WriteLine("Example Input: " + TopKFrequent.Example());
                foreach(int num in TopKFrequent.Solve(TakeArray<int>(),TakeInt())){
                    Console.Write(num + " ");
                };
                break;
            case "26":
                Console.WriteLine("Example Input: " + ProductOfArrayExceptSelf.Example());
                foreach(int num in ProductOfArrayExceptSelf.Solve(TakeArray<int>())){
                    Console.Write(num + " ");
                };
                break;
            case "27":
                Console.WriteLine("Example Input: " + IsValidSudoku.Example());
                Console.WriteLine(IsValidSudoku.Solve(TakeJaggedArray<char>()));
                break;
            case "28":
                Console.WriteLine("Example Input: " + LongestConsecutiveSequence.Example());
                Console.WriteLine(LongestConsecutiveSequence.Solve(TakeArray<int>()));
                break;
            case "29":
                Console.WriteLine("Example Input: " + IsPalindrome.Example());
                Console.WriteLine(IsPalindrome.Solve(TakeString()));
                break;
            case "30":
                Console.WriteLine("Example Input: " + TwoSumII.Example());
                foreach(int num in TwoSumII.Solve(TakeArray<int>(),TakeInt())){
                    Console.Write(num + " ");
                };
                break;
            case "31":
                Console.WriteLine("Example Input: " + ValidParentheses.Example());
                Console.WriteLine(ValidParentheses.Solve(TakeString()));
                break;
            case "32":
                Console.WriteLine("Example Input: " + EvalRPN.Example());
                Console.WriteLine(EvalRPN.Solve(TakeArray<string>()));
                break;
            case "33":
                Console.WriteLine("Example Input: " + DailyTemperatures.Example());
                foreach(int num in DailyTemperatures.Solve(TakeArray<int>())){
                    Console.Write(num + " ");
                };
                break;
            case "34":
                Console.WriteLine("Example Input: " + CharacterReplacement.Example());
                Console.WriteLine(CharacterReplacement.Solve(TakeString(),TakeInt()));
                break;
            case "35":
                Console.WriteLine("Example Input: " + GenerateParentheses.Example());
                foreach(string set in GenerateParentheses.Solve(TakeInt())){
                    Console.WriteLine(set);
                };
                break;
            case "36":
                Console.WriteLine("Example Input: " + BinarySearchMatrix.Example());
                Console.WriteLine(BinarySearchMatrix.Solve(TakeJaggedArray<int>(),TakeInt()));
                break;
            case "37":
                Console.WriteLine("Example Input: " + ReverseList.Example());
                DisplayLinkedList(ReverseList.Solve(TakeLinkedList()));
                break;
            case "38":
                Console.WriteLine("Example Input: " + LinkedListCycle.Example());
                Console.WriteLine(LinkedListCycle.Solve(TakeLinkedList()));
                break;
            case "39":
                Console.WriteLine("Example Input: " + DiameterOfBinaryTree.Example());
                Console.WriteLine(DiameterOfBinaryTree.Solve(TakeBinaryTree()));
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
        Console.WriteLine("Enter a Integer:");
        return int.Parse(Console.ReadLine());
    }

    private static string TakeString(){
        Console.WriteLine("Enter a String:");
        return Console.ReadLine();
    }

    private static ListNode TakeLinkedList(){
        ListNode head = null;
        ListNode end = head;

        while(true){
            Console.WriteLine("Enter a Integer or Press Enter to End The List:");
            string input = Console.ReadLine();
            if(input == "") break;

            if(head == null){
                head = new ListNode(int.Parse(input),null);
                end = head;
            }else{
                end.next = new ListNode(int.Parse(input),null);
                end = end.next;
            }
        }
        
        return head;
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

    private static T[][] TakeJaggedArray<T>(){
        int size;
       T[][] array;

        Console.WriteLine("How many arrays?:");//Limit 200
        size = int.Parse(Console.ReadLine());
        if(size < 0) size = 0;
        if(size > 200) size = 200;

        
        array = new T[size][];

        for(int j = 0; j < size;j++){
            Console.WriteLine("Enter array size:");
            int num = int.Parse(Console.ReadLine());
            if(num < 0) num = 0;
            array[j] = new T[num];
            Console.WriteLine("Enter items:");
            for(int i = 0; i < num; i++){
            array[j][i] = (T)Convert.ChangeType(Console.ReadLine(),typeof(T));
         }
        }
         return array;
    }

    private static TreeNode TakeBinaryTree(){
        Console.WriteLine("Enter value of Node <leave blank for NULL/No Node>:");
        string input = Console.ReadLine();
        if(input == "") return null;

        TreeNode root = new TreeNode(int.Parse(input));
        Console.WriteLine("New Node: Left, Parent: " + input);
        root.left = TakeBinaryTree();

        Console.WriteLine("New Node: Right, Parent: " + input);
        root.right = TakeBinaryTree();
        
        return root;
    }
    private static void PrintTreeBF(TreeNode root){
        if(root == null) return;
        Queue<TreeNode> curLevel = new Queue<TreeNode>();
        Queue<TreeNode> nextLevel = new Queue<TreeNode>();
        curLevel.Enqueue(root);

        while(curLevel.Count > 0 || nextLevel.Count > 0){
            String level = "";
            while(curLevel.Count != 0){
                TreeNode temp = curLevel.Dequeue();
                level += temp.val + " ";
                if(temp.left != null) nextLevel.Enqueue(temp.left);
                if(temp.right != null)nextLevel.Enqueue(temp.right);
            }
            Console.WriteLine(level);
            curLevel = nextLevel;
            nextLevel = new Queue<TreeNode>();
        }
    }

    private static void DisplayLinkedList(ListNode head){
        string list = "[";
        ListNode cur = head;

        while(cur != null){
            list += cur.val.ToString();
            if(cur.next != null){
                list += ", ";
            }
            cur = cur.next;
        }

        list += "]";
        Console.WriteLine(list);
    }

}


