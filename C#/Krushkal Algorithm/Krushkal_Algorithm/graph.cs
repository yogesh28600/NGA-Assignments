using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krushkal_Algorithm
{
    public class Node
    {
        public int value;
        public Node(int value)
        {
         this.value = value;   
        }
    }
    public class Graph
    {
       
        public class Edge
        {
            public Node source;
            public Node Destination;
            public int weight;
            public Edge(Node source, Node Destination, int weight)
            {
                this.source = source;
                this.Destination = Destination;
                this.weight = weight;
            }
        }
        private Dictionary<Node, List<Edge>> graph;
        private int count_edge = 0;
        
        public Graph()
        {
            graph = new Dictionary<Node, List<Edge>>();
        }

        public void add_node(Node node)
        {
           
            if(!graph.ContainsKey(node))
            {
                graph[node]= new List<Edge>();
            }
        }
        public void add_edge(Node source, Node destination,int weight)
        {
            if(graph.ContainsKey(source) && graph.ContainsKey(destination))
            {
                Edge edge = new Edge(source, destination, weight);
                graph[source].Add(edge);
                count_edge++;
            }
        }

        public void kruskal_algoritm()
        {
            List<Edge> edges = new List<Edge>();
            List<Node> nodes = new List<Node>();
            List<Edge> result = new List<Edge>();
            foreach(var edgelist in graph.Values)
            {
                foreach(var edge in edgelist)
                {
                    edges.Add(edge);
                }
            }
            edges.Sort((edge1, edge2) => edge1.weight.CompareTo(edge2.weight));
            foreach (var edge in edges)
            {
                if (nodes.Contains(edge.source) && nodes.Contains(edge.Destination))
                {
                    continue;
                }
                result.Add(edge);
                nodes.Add(edge.source);
                nodes.Add(edge.Destination);
            }


            //Print output
            Console.WriteLine("Minimum Spanning Tree:");
            foreach(var edge in result)
            {
                Console.WriteLine("("+edge.source.value+","+edge.Destination.value+")  :  "+" " +edge.weight);
            }

        }

    }
}
