using System;
using System.Collections.Generic;
using System.Text;
using Trees_Graphs.Common;

namespace Trees_Graphs
{
    public class ListOfDepths<T>
    {
        public List<List<BinaryTreeNode<T>>> BuildListOfNodeDepths(BinaryTreeNode<T> root)
        {
            return Recurse(root, 0, new List<List<BinaryTreeNode<T>>>());
        }

        private List<List<BinaryTreeNode<T>>> Recurse(BinaryTreeNode<T> node, int depth, List<List<BinaryTreeNode<T>>> list)
        {
            if (node is null)
            {
                return list;
            }
            if(depth >= list.Count)
            {
                list.Add(new List<BinaryTreeNode<T>>());
            }
            if (list[depth] is null)
            {
                list[depth] = new List<BinaryTreeNode<T>>();
            }
            list[depth].Add(node);
            list = Recurse(node.Left, depth + 1, list);
            list = Recurse(node.Right, depth + 1, list);
            return list;
        }
    }
}
