using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bellman_Ford_Algorithm
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

            if (!graph.ContainsKey(node))
            {
                graph[node] = new List<Edge>();
            }
        }
        public void add_edge(Node source, Node destination, int weight)
        {
            if (graph.ContainsKey(source) && graph.ContainsKey(destination))
            {
                Edge edge = new Edge(source, destination, weight);
                graph[source].Add(edge);
                count_edge++;
            }
        }


        public void bellman_ford_algorithm(Node start)
        {
  
         var distances = new Dictionary<Node, int>();
            foreach (var node in graph.Keys)
            {
                distances[node] = int.MaxValue;
            }
            distances[start] = 0;

            foreach (var node in graph.Keys)
            {
                foreach (var i in graph.Keys)
                {
                    foreach (var edge in graph[i])
                    {
                        var v = edge.Destination;
                        if (distances[i] != int.MaxValue && distances[i] + edge.weight < distances[v])
                        {
                            distances[v] = distances[i] + edge.weight;
                        }
                    }
                }
            }
            //Print output
            Console.WriteLine("Distances of each node from: " + start.value);
            foreach (var distance in distances)
            {
                Console.WriteLine(distance.Key.value + "----->"+ distance.Value);
            }
        }

    }
}
