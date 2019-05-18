using Linked_Lists.Common;
using System.Collections.Generic;

public class LoopDetection
{
    public SinglyLinkedListNode<int> FindLoop(SinglyLinkedListNode<int> head)
    {
        SinglyLinkedListNode<int> slow = head;
        SinglyLinkedListNode<int> fast = head;

        while(fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            if (fast == slow)
            {
                break;
            }
        }

        // null check
        if(fast == null || fast.Next == null)
        {
            return null; // no loop found
        }

        slow = head;
        while(slow != fast)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        return slow;
    }
}
