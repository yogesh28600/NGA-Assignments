using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignments_Graph.Graph;

namespace Assignments_Graph
{

    public class Graph
    {

        private Dictionary<Employee,List<Employee>> graph= new Dictionary<Employee, List<Employee>>();
        public void add_vertex(Employee vertex)
        {
            if(!graph.ContainsKey(vertex))
            {
                graph[vertex] = new List<Employee>();
                Console.WriteLine("Vertex added: " +vertex.name);
            }
        }
        public void add_edge(Employee vertex1,Employee vertex2)
        {
            if(graph.ContainsKey(vertex1) && graph.ContainsKey(vertex2))
            {
                graph[vertex1].Add(vertex2);
                Console.WriteLine("Edge is added between " + vertex1.name+" and "+vertex2.name);
            }
        }

        public void BFS(Employee vertex)
        {
            List<Employee> isVisited = new List<Employee>();
            Queue<Employee> queue = new Queue<Employee>();

            isVisited.Add(vertex);
            queue.Enqueue(vertex);

            while(queue.Count > 0)
            {
                Employee v = queue.Dequeue();
                Console.Write(v.name+" ->");
                foreach(Employee v2 in graph[v])
                {
                    if (! isVisited.Contains(v2))
                    {
                        isVisited.Add(v2);
                        queue.Enqueue(v2);
                    }
                }
            }
        }
    }
}
