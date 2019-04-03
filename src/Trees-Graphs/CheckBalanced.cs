using System;
using System.Collections.Generic;
using System.Text;
using Trees_Graphs.Common;

namespace Trees_Graphs
{
    public class CheckBalanced<T>
    {
        public bool IsTreeBalanced(BinaryTreeNode<T> root)
        {
            if(Math.Abs(GetHeight(root.Left) - GetHeight(root.Right)) > 1)
            {
                return false;
            }
            return true;
        }

        private int GetHeight(BinaryTreeNode<T> node)
        {
            if(node is null)
            {
                return -1;
            }
            return Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
        }
    }
}
