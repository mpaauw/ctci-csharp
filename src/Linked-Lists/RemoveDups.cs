using Linked_Lists.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    public class RemoveDups
    {
        public SinglyLinkedListNode<T> RemoveDupsFromSinglyLinkedListUsingHashSet<T>(SinglyLinkedListNode<T> head)
        {
            HashSet<T> existingData = new HashSet<T>();
            SinglyLinkedListNode<T> current = head;
            SinglyLinkedListNode<T> prev = null;
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

        public SinglyLinkedListNode<T> RemoveDupsFromSinglyLinkedListUsingNoBuffer<T>(SinglyLinkedListNode<T> head)
        {
            SinglyLinkedListNode<T> current = head;
            while (current != null)
            {
                SinglyLinkedListNode<T> runner = current.Next;
                SinglyLinkedListNode<T> prev = null;
                while (runner != null)
                {
                    if (runner.Data.Equals(current.Data))
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
