//Problem:
/*
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/

// Constraints:
//The number of nodes in each linked list is in the range [1, 100].
//0 <= Node.val <= 9
//It is guaranteed that the list represents a number that does not have leading zeros.

using Support;

namespace Solutions{
    public static class AddTwoNumbersList{
        public static ListNode Solve(ListNode l1, ListNode l2) {
            bool carry = false;
            ListNode sum = new ListNode();
            ListNode it = sum;
        
            while(l1!=null||l2!=null){
            
                int val1 = l1 is null ? 0 : l1.val;
                int val2 = l2 is null ? 0 : l2.val;
                int total = val1+val2;
            
                if(total+it.val >= 10){
                    total-=10;
                    carry = true;
                }
            
                it.val+= total;
            
                if(l1?.next!=null||l2?.next!=null||carry == true){
                it.next = carry == true ? new ListNode(1):new ListNode();
                it = it.next;
                }
                carry = false;
           
                l1 = l1 is null ? null : l1.next;
                l2 = l2 is null ? null : l2.next;
            }
            return sum;
        }
        public static string Example(){
            return "l1 = [2,4,3], l2 = [5,6,4]";
        }
  }
}