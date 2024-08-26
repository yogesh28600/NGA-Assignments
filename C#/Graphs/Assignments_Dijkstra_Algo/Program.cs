﻿namespace Assignments_Dijkstra_Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            graph.add_node(node1);
            graph.add_node(node2);
            graph.add_node(node3);
            graph.add_node(node4);
            graph.add_node(node5);
            graph.add_node(node6);

            graph.add_edge(node1 , node2,4);
            graph.add_edge(node1, node3, 2);
            graph.add_edge(node2, node5, 3);
            graph.add_edge(node2, node4, 5);
            graph.add_edge(node3, node6, 8);
            graph.add_edge(node3, node4, 7);
            graph.add_edge(node4, node6, 1);
            graph.add_edge(node4, node5, 6);

            graph.Dijkstra(node1);


        }
    }
}
