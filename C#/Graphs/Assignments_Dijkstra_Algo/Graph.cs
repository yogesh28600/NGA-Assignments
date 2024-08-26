using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Dijkstra_Algo
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
        private Dictionary<Node, List<(Node,int)>> graph;
        private int number_of_nodes {get;set;}
        public Graph()
        {
            graph = new Dictionary<Node, List<(Node,int)>>();
        }
        public void add_node(Node node)
        {
            if (!graph.ContainsKey(node))
            {
                graph[node] = new List<(Node,int)>();
                number_of_nodes++;
            }
        }
        public void add_edge(Node node1,Node node2,int weight) 
        {
            if(graph.ContainsKey(node1) && graph.ContainsKey(node2)) 
            {
                graph[node1].Add((node2,weight));
                graph[node2].Add((node1,weight));
            }
        }

        public void Dijkstra(Node start)
        {
            Dictionary<Node,int> distances = new Dictionary<Node, int>();
            SortedSet<(int,Node)> queue = new SortedSet<(int, Node)>(Comparer<(int, Node)>.Create((x, y) => x.Item1.CompareTo(y.Item1)));
            var previous = new Dictionary<Node, Node>();

            foreach (var node in graph.Keys)
            {
                distances[node] = int.MaxValue;
                previous[node] = null;
            }

            distances[start] = 0;
            queue.Add((0, start));

            while (queue.Count > 0)
            {
                var (currentDist, currentNode) = queue.Min;
                queue.Remove(queue.Min);

                if (currentDist > distances[currentNode]) continue;

                foreach (var (neighbor, weight) in graph[currentNode])
                {
                    var newDist = currentDist + weight;
                    if (newDist < distances[neighbor])
                    {
                        distances[neighbor] = newDist;
                        previous[neighbor] = currentNode;
                        queue.Add((newDist, neighbor));
                    }
                }
            }
            foreach (var node in distances.Keys)
            {
                Console.WriteLine($"Distance from {start.value} to {node.value} is {distances[node]}");
            }
        }
        public void find_shortest_path(Node source)
        {
            int[,] distances = new int[number_of_nodes, number_of_nodes];
            bool[] isTravered = new bool[number_of_nodes];
            distances[source.value, source.value] = 0;
            isTravered[source.value] = true;
            for (int i = 1; i <= number_of_nodes; i++)
            {
                for (int j = 1; j <= number_of_nodes; j++)
                {
                    
                }
            }
        }
    }
}
