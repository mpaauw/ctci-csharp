using System;
using System.Collections.Generic;
using System.Text;

namespace Trees_Graphs.Common
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }

        public BinaryTreeNode<T> Left { get; set; }

        public BinaryTreeNode<T> Right { get; set; }
    }
}
