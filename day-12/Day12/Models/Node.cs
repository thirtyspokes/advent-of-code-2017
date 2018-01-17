using System;
using System.Collections.Generic;

namespace Day12.Models
{
    public class Node
    {
        public int ID { get; }

        public HashSet<Node> Connections { get; }

        public Node(int id)
        {
            ID = id;
            Connections = new HashSet<Node>();
        }

        public void Connect(Node node)
        {
            Connections.Add(node);
        }
    }
}