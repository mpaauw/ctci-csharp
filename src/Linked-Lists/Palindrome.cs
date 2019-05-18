using Linked_Lists.Common;

public class Palindrome
{
    public bool IsPalindrome(SinglyLinkedListNode<int> head)
    {
        // reverse + copy:
        var reversed = ReverseAndCopy(head);

        // compare reversed to original:
        return Compare(head, reversed);
    }

    private SinglyLinkedListNode<int> ReverseAndCopy(SinglyLinkedListNode<int> node)
    {
        SinglyLinkedListNode<int> prev = null;
        while(node != null)
        {
            SinglyLinkedListNode<int> current = new SinglyLinkedListNode<int>(node.Data);
            current.Next = node.Next;
            prev = current;
            node = node.Next;
        }
        return prev;
    }

    private bool Compare(SinglyLinkedListNode<int> list1, SinglyLinkedListNode<int> list2)
    {
        while(list1 != null && list2 != null)
        {
            if(list1.Data != list2.Data)
            {
                return false;
            }
            list1 = list1.Next;
            list2 = list2.Next;
        }
        return list1 == null && list2 == null;
    }
}