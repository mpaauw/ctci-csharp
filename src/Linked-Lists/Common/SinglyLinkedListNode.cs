using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists.Common
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode() { }

        public SinglyLinkedListNode(T data)
        {
            Data = data;
        }

        public T Data { get; set; }

        public SinglyLinkedListNode<T> Next { get; set; }
    }
}
