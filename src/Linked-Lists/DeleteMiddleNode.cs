using Linked_Lists.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_Lists
{
    public class DeleteMiddleNode
    {
        public SinglyLinkedListNode<T> DeleteMiddleNodeWithAccessOnlyToThatNode<T>(SinglyLinkedListNode<T> node)
        {
            if(node.Next == null)
            {
                throw new InvalidOperationException("Node supplied is not a 'middle' node.");
            }
            var nextNode = node.Next;
            node.Data = nextNode.Data;
            node.Next = nextNode.Next;
            return node;
        }
    }
}
