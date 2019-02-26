using System;
using System.Collections.Generic;
using System.Text;
using Trees_Graphs.Common;

namespace Trees_Graphs
{
    public class MinimalTree
    {
        public BinaryTreeNode<int> BuildBinarySearchTreeFromSortedArray(int[] sortedArr)
        {
            return Recurse(sortedArr, 0, sortedArr.Length - 1);
        }

        public BinaryTreeNode<int> Recurse(int[] sortedArr, int leftPart, int rightPart)
        {
            if (rightPart < leftPart)
            {
                return null;
            };
            int midPoint = (leftPart + rightPart) / 2;
            var node = new BinaryTreeNode<int>()
            {
                Value = sortedArr[midPoint]
            };
            node.Left = Recurse(sortedArr, leftPart, midPoint - 1);
            node.Right = Recurse(sortedArr, midPoint + 1, rightPart);
            return node;
        }
    }
}
