using Linked_Lists.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    public class RemoveDups
    {
        public SinglyLinkedListNode RemoveDupsFromSinglyLinkedListUsingHashSet(SinglyLinkedListNode head)
        {
            HashSet<string> existingData = new HashSet<string>();
            SinglyLinkedListNode current = head;
            SinglyLinkedListNode prev = null;
            while (current != null)
            {
                if (existingData.Contains(current.Data))
                {
                    prev.Next = current.Next;
                }
                else
                {
                    existingData.Add(current.Data);
                    prev = current;
                }
                current = current.Next;
            }
            return head;
        }

        public SinglyLinkedListNode RemoveDupsFromSinglyLinkedListUsingNoBuffer(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode current = head;
            while (current != null)
            {
                SinglyLinkedListNode runner = current.Next;
                SinglyLinkedListNode prev = null;
                while (runner != null)
                {
                    if (runner.Data == current.Data)
                    {
                        prev.Next = runner.Next;
                    }
                    else
                    {
                        prev = runner;
                    }
                    runner = runner.Next;
                }
                current = current.Next;
            }
            return head;
        }
    }
}
