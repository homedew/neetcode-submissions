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
//  0,1,2,3

//  => temp = 0 
//  curr.next = 0 -> null

//  prev = 0

public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;

        while(curr !=null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;

        }
        return prev;
    }
}
