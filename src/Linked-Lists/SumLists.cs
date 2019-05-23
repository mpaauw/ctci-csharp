using Linked_Lists.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    public class SumLists
    {
        /// <summary>
        /// O(N), where N is the length of the longest list.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public SinglyLinkedListNode<int> SumTwoLists(SinglyLinkedListNode<int> num1, SinglyLinkedListNode<int> num2)
        {
            int carry = 0;
            SinglyLinkedListNode<int> previous = new SinglyLinkedListNode<int>();
            SinglyLinkedListNode<int> result = previous;
            while(num1 != null || num2 != null || carry > 0)
            {
                int num1Current = (num1 != null) ? num1.Data : 0;
                int num2Current = (num2 != null) ? num2.Data : 0;

                int currentSum = num1Current + num2Current + carry;
                carry = currentSum / 10;

                SinglyLinkedListNode<int> current = new SinglyLinkedListNode<int>(currentSum % 10);
                previous.Next = current;
                previous = current;

                num1 = (num1 != null) ? num1.Next : num1;
                num2 = (num2 != null) ? num2.Next : num2;
            }
            return result.Next;
        }

    }
}
