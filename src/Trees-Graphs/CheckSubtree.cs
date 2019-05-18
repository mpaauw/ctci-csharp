using Trees_Graphs.Common;

public class CheckSubtree
{
    public bool IsSubtree(BinaryTreeNode<int> t1, BinaryTreeNode<int> t2)
    {
        if(t2 == null)
        {
            return true;
        }
        return Subtree(t1, t2);
    }

    private bool Subtree(BinaryTreeNode<int> t1, BinaryTreeNode<int> t2)
    {
        if (t1 == null)
        {
            return false;
        }
        else if (t1.Value == t2.Value && MatchTree(t1, t2))
        {
            return true;
        }
        return Subtree(t1.Left, t2) || Subtree(t1.Right, t2);
    }

    private bool MatchTree(BinaryTreeNode<int> t1, BinaryTreeNode<int> t2)
    {
        if(t1 == null && t2 == null)
        {
            return true;
        }
        else if(t1 == null || t2 == null)
        {
            return false;
        }
        else if(t1.Value != t2.Value)
        {
            return false;
        }
        else
        {
            return MatchTree(t1.Left, t2.Left) && MatchTree(t1.Left, t2.Left);
        }
    }
}