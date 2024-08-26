namespace Assignments_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Yogesh", Gender.Male, "987654321");
            Employee emp2 = new Employee("Kiran", Gender.Male, "987654322");
            Employee emp3 = new Employee("Avinash", Gender.Male, "987654323");
            Employee emp4 = new Employee("Mohan", Gender.Male, "987654324");
            Graph graph = new Graph();
            
            graph.add_vertex(emp1);
            graph.add_vertex(emp2);
            graph.add_vertex(emp3);
            graph.add_vertex(emp4);

            graph.add_edge(emp1,emp2);
            graph.add_edge(emp2,emp3);
            graph.add_edge(emp4,emp1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("BFS:( "+emp1.name +")   ");
            graph.BFS(emp1);
            Console.WriteLine();
            Console.Write("BFS:( " + emp2.name + ")   ");
            graph.BFS(emp2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
