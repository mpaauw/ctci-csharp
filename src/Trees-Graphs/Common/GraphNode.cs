using System;
using System.Collections.Generic;
using System.Text;

namespace Trees_Graphs.Common
{
    public class GraphNode
    {
        public string Data { get; set; }

        public GraphNode[] AdjacencyList { get; set; }

        public VisitStatus Status { get; set; }
    }
}
