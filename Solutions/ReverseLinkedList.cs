//Problem:
/*
Given the head of a singly linked list, reverse the list, and return the reversed list.
*/

// Constraints:
//The number of nodes in the list is the range [0, 5000].
//-5000 <= Node.val <= 5000

using Support;

namespace Solutions{
    public static class ReverseList{
        public static ListNode Solve(ListNode head) {
            ListNode prev = null;
            ListNode cur = head; 
        
            while(cur != null){
                ListNode next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }
        
            //prev should be the head of the reversed list
            return prev;
        }
        public static string Example(){
            return "head = [1,2,3,4,5]";
        }
  }
}