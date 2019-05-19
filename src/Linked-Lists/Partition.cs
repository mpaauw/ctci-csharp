using Linked_Lists.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    public class Partition
    {
        SinglyLinkedListNode<int> lessThanList = null;
        SinglyLinkedListNode<int> greaterThanEqualList = null;

        public SinglyLinkedListNode<int> SortByPartition(int partition, SinglyLinkedListNode<int> list)
        {
            var lessPtr = lessThanList;
            var greaterPtr = greaterThanEqualList;
            var current = list;
            while(current != null)
            {
                if(current.Data < partition)
                {
                    WriteToList(current.Data, lessThanList);
                }
                else
                {
                    WriteToList(current.Data, greaterThanEqualList);
                }
                current = current.Next;
            }
            lessThanList.Next = greaterPtr;
            return lessPtr;
        }

        private void WriteToList(int value, SinglyLinkedListNode<int> list)
        {
            if(list is null)
            {
                list = new SinglyLinkedListNode<int>()
                {
                    Data = value
                };
            }
            else
            {
                list.Next = new SinglyLinkedListNode<int>()
                {
                    Data = value
                };
                list = list.Next;
            }
        }
    }
}
