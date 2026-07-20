using System;
using System.Linq.Expressions;
namespace DataStructures.Graph;

public class MyGraph
{
    public static void Main(string[] args)
    {
        var MyGraph = new Graph();

        MyGraph.AddVertex("A");
        MyGraph.AddVertex("B");
        MyGraph.AddEdge("A", "B");

        MyGraph.Print();
        MyGraph.DFS("A");
        Console.WriteLine();
        MyGraph.BFS("A");
    }
}

public class Graph
{
    // Node / Vertex
    private class Node
    {
        public string Data { get; private set; }
        public List<Node> AdjacentNodes { get; private set; }

        public Node(string data)
        {
            Data = data;
            AdjacentNodes = new List<Node>();
        }
    }

    // Graph

    private Dictionary<string, Node> _graph;

    public Graph()
    {
        _graph = new Dictionary<string, Node>();
    }

    // Add Vertex
    public void AddVertex(string data)
    {
        if (!_graph.ContainsKey(data))
        {
            var node = new Node(data);
            _graph.Add(data, node);
        }
    }

    // Add Edge
    public void AddEdge(string key, string vertex)
    {
        if (!_graph.ContainsKey(key) || !_graph.ContainsKey(vertex))
        {
            throw new KeyNotFoundException("The key not found.");
        }

        if (!_graph[key].AdjacentNodes.Contains(_graph[vertex]))
        {
            _graph[key].AdjacentNodes.Add(_graph[vertex]);
            _graph[vertex].AdjacentNodes.Add(_graph[key]);
        }
    }

    // DFS
    public void DFS(string vertex){
        var visitede = new HashSet<Node>();
        DFS(vertex, visitede);
    }

    private void DFS(string vertex, HashSet<Node> visitede)
    {
        if (visitede.Contains(_graph[vertex]))
        {
            return;
        }

        visitede.Add(_graph[vertex]);

        Console.Write($"{_graph[vertex].Data} ");

        foreach(var neighbor in _graph[vertex].AdjacentNodes)
        {
            DFS(neighbor.Data, visitede);
        }
    }

    // BFS
    public void BFS (string vertex)
    {
        var visited = new HashSet<Node>();
        var line = new Queue<Node>();
        var current = _graph[vertex];
        line.Enqueue(current);
        visited.Add(current);

        while(line.Count > 0)
        {
            current = line.Dequeue();

            Console.Write($"-> {current.Data} ");
            foreach(var neighbor in current.AdjacentNodes)
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    line.Enqueue(neighbor);
                }
            }
        }
    }


    // Print method
    public void Print()
    {
        foreach(var element in _graph)
        {
            Console.Write($"[{element.Key}] : ");
            foreach(var neighbor in _graph[element.Key].AdjacentNodes)
            {
                Console.Write($"{neighbor.Data} ");
            }
            Console.WriteLine();
        }
    }
}