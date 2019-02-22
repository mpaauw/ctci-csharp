using System;
using System.Collections.Generic;
using System.Text;
using Trees_Graphs.Common;

namespace Trees_Graphs
{
    public class RouteBetweenNodes
    {
        public bool DoesRouteExistBetweenTwoNodes(GraphNode node1, GraphNode node2)
        {
            Stack<GraphNode> stack = new Stack<GraphNode>();
            stack.Push(node1);
            return DepthFirstSearch(stack, node2);
        }

        private bool DepthFirstSearch(Stack<GraphNode> stack, GraphNode searchNode)
        {
            while(stack.Count > 0)
            {
                GraphNode currentNode = stack.Pop();
                if(currentNode.Equals(searchNode))
                {
                    return true;
                }
                currentNode.Status = VisitStatus.Visiting;
                foreach (GraphNode adjacentNode in currentNode.AdjacencyList)
                {
                    if(adjacentNode.Status == VisitStatus.Unvisited)
                    {
                        stack.Push(adjacentNode);
                    }
                }
                currentNode.Status = VisitStatus.Visited;
            }
            return false;
        }

        private bool BreadthFirstSearch(Queue<GraphNode> queue, GraphNode searchNode)
        {
            while(queue.Count > 0)
            {
                GraphNode currentNode = queue.Dequeue();
                if (currentNode.Equals(searchNode))
                {
                    return true;
                }
                currentNode.Status = VisitStatus.Visiting;
                foreach(GraphNode adjacentNode in currentNode.AdjacencyList)
                {
                    if(adjacentNode.Status == VisitStatus.Unvisited)
                    {
                        queue.Enqueue(adjacentNode);
                    }
                }
                currentNode.Status = VisitStatus.Visited;
            }
            return false;
        }
    }
}
