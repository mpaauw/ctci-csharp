using Linked_Lists.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    public class SumLists
    {

        public SinglyLinkedListNode<int> CreateSumListFromListsRecursively(SinglyLinkedListNode<int> num1, SinglyLinkedListNode<int> num2)
        {
            return Recurse(num1, num2, 0);
        }

        private SinglyLinkedListNode<int> Recurse(SinglyLinkedListNode<int> a, SinglyLinkedListNode<int> b, int carry)
        {
            if(a == null && b == null && carry == 0)
            {
                return null;
            }

            var newNode = new SinglyLinkedListNode<int>();
            int sum = carry;

            if(a != null)
            {
                sum += a.Data;
            }
            if(b != null)
            {
                sum += b.Data;
            }

            newNode.Data = sum % 10;

            if(a != null || b != null)
            {
                var nextNode = Recurse(
                    (a.Next != null) ? a.Next : null,
                    (b.Next != null) ? b.Next : null,
                    (sum > 9) ? 1 : 0);
                newNode.Next = nextNode;
            }
            
            return newNode;
        }
    }
}
