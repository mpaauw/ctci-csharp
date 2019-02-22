using System;
using System.Collections.Generic;
using System.Text;

namespace Trees_Graphs.Common
{
    public class GraphNode<T>
    {
        public T Data { get; set; }

        public GraphNode<T>[] AdjacencyList { get; set; }

        public VisitStatus Status { get; set; }
    }
}
