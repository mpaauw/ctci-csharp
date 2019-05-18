using Trees_Graphs.Common;

public class PathsWithSum
{
    public int CountPaths(BinaryTreeNode<int> root, int value)
    {
        if(root == null)
        {
            return 0;
        }
        return Recurse(root, value, 0) + CountPaths(root.Left, value) + CountPaths(root, value);
    }

    private int Recurse(BinaryTreeNode<int> node, int value, int sum)
    {
        if(node == null)
        {
            return 0;
        }

        int pathsWithSum = 0;
        sum += node.Value;
        if(sum == value)
        {
            pathsWithSum++;
        }
        pathsWithSum += Recurse(node.Left, value, sum);
        pathsWithSum += Recurse(node.Right, value, sum);
        return pathsWithSum;
    }
}