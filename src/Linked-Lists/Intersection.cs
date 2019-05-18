using Linked_Lists.Common;
using System;

namespace Linked_Lists
{
    public class Intersection
    {
        public SinglyLinkedListNode<int> FindIntersection(SinglyLinkedListNode<int> list1, SinglyLinkedListNode<int> list2)
        {
            if(list1 == null || list2 == null)
            {
                return null; // no intersection, either list is null
            }

            Result result1 = GetTailAndSize(list1);
            Result result2 = GetTailAndSize(list2);

            if(result1.Tail != result2.Tail)
            {
                return null; // no intersection, tails are not the same reference
            }

            SinglyLinkedListNode<int> shortList = (result1.Size < result2.Size) ? list1 : list2;
            SinglyLinkedListNode<int> longList = (result1.Size > result2.Size) ? list1 : list2;

            longList = MoveNode(longList, Math.Abs(result1.Size - result2.Size)); // move longer node pointer so lists start at same index

            while(shortList != longList)
            {
                shortList = shortList.Next;
                longList = longList.Next;
            }

            return shortList; // or longList!
        }


        private SinglyLinkedListNode<int> MoveNode(SinglyLinkedListNode<int> node, int k)
        {
            SinglyLinkedListNode<int> current = node;
            while(k > 0 && current != null)
            {
                current = current.Next;
                k--;
            }
            return current;
        }

        private Result GetTailAndSize(SinglyLinkedListNode<int> list)
        {
            if(list == null)
            {
                return null;
            }
            int size = 1;
            SinglyLinkedListNode<int> current = list;
            while(current != null)
            {
                size++;
                current = current.Next;
            }
            return new Result(current, size);
        }

        public class Result
        {
            public Result(SinglyLinkedListNode<int> tail, int size)
            {
                Tail = tail;
                Size = size;
            }

            public SinglyLinkedListNode<int> Tail { get; set; }
            public int Size { get; set; }
        }
    }
}
