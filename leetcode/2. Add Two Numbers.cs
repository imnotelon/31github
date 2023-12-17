/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int remainder = 0;
        var ans = new ListNode();
        var retAns = ans;
        while(ans != null){
            ans.val = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + remainder;
            remainder = ans.val/10;
            ans.val %=10;
            l1 = l1?.next;
            l2 = l2?.next;
            ans.next = l1 != null || l2 != null || remainder != 0 ? new ListNode() : null;
            ans = ans.next;
        }
        return retAns;
    }
}
