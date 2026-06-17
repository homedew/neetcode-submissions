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
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        // 1 2 3 4
        // temp = 2 3 4
        // curr.next = null; 1 -> null ( curr = 1 -> null)
        // prev = 1 -> null
        // curr = temp=> 2 3 4


        while(curr !=null) {
            ListNode temp  = curr.next;
            curr.next= prev;
            prev = curr;
            curr = temp;
        }

        return prev;

    }
}
