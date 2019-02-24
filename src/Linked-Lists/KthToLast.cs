using Linked_Lists.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    public class KthToLast
    {
        public T FindKthToLastElementOfSinglyLinkedListByUsingTwoPointers<T>(SinglyLinkedListNode<T> head, int k)
        {
            var runner = head;
            for(int i = 0; i < k; i++)
            {
                if(runner == null)
                {
                    return default(T);
                }
                runner = runner.Next;
            }
            var current = head;
            while(runner != null)
            {
                runner = runner.Next;
                current = current.Next;
            }
            return current.Data;
        }

        public T FindKthToLastElementOfSinglyLinkedList<T>(SinglyLinkedListNode<T> head, int k)
        {
            int count = 0;
            var current = head;
            while(current != null)
            {
                count += 1;
                current = current.Next;
            }

            var iter = head;
            for(int i = 0; i < (count - k); i++)
            {
                iter = iter.Next;
            }
            return iter.Data;
        }
    }
}
