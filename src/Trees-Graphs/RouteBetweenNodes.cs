using System;
using System.Collections.Generic;
using System.Text;
using Trees_Graphs.Common;

namespace Trees_Graphs
{
    public class RouteBetweenNodes
    {
        public bool DoesRouteExistBetweenTwoNodes<T>(GraphNode<T> node1, GraphNode<T> node2)
        {
            Stack<GraphNode<T>> stack = new Stack<GraphNode<T>>();
            stack.Push(node1);
            return DepthFirstSearch(stack, node2);
        }

        private bool DepthFirstSearch<T>(Stack<GraphNode<T>> stack, GraphNode<T> searchNode)
        {
            while(stack.Count > 0)
            {
                GraphNode<T> currentNode = stack.Pop();
                if(currentNode.Equals(searchNode))
                {
                    return true;
                }
                currentNode.Status = VisitStatus.Visiting;
                foreach (GraphNode<T> adjacentNode in currentNode.AdjacencyList)
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

        private bool BreadthFirstSearch<T>(Queue<GraphNode<T>> queue, GraphNode<T> searchNode)
        {
            while(queue.Count > 0)
            {
                GraphNode<T> currentNode = queue.Dequeue();
                if (currentNode.Equals(searchNode))
                {
                    return true;
                }
                currentNode.Status = VisitStatus.Visiting;
                foreach(GraphNode<T> adjacentNode in currentNode.AdjacencyList)
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
