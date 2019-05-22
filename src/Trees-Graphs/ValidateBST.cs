using System;
using System.Collections.Generic;
using System.Text;
using Trees_Graphs.Common;

namespace Trees_Graphs
{
    public class ValidateBST
    {
        public bool IsBST(BinaryTreeNode<int> root)
        {
            return Recurse(root, Int32.MinValue, Int32.MaxValue);
        }

        private bool Recurse(BinaryTreeNode<int> node, int min, int max)
        {
            if(node == null)
            {
                return true;
            }
            if(node.Value <= min || node.Value > max)
            {
                return false;
            }
            return Recurse(node.Left, min, node.Value)
                && Recurse(node.Right, node.Value, max);
        }
    }
}
