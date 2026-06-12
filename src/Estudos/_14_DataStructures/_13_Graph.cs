using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
namespace DataStructures.implementation;

public class BuildGraph
{
    public static void Main(string[] args)
    {
        var graph = new Graph<string>();

        // ADD VERTEX
        graph.AddVertex("A");
        graph.AddVertex("B");
        graph.AddVertex("C");
        graph.AddVertex("D");
        graph.AddVertex("E");
        graph.AddVertex("F");

        // ADD EDGE
        graph.AddEdge("A", "C", 8);
        graph.AddEdge("A", "B", 10);
        graph.AddEdge("A", "D", 15);
        graph.AddEdge("B", "D", 7);
        graph.AddEdge("C", "D", 5);
        graph.AddEdge("C", "E", 10);
        graph.AddEdge("D", "E", 1);
        graph.AddEdge("D", "F", 4);
        graph.AddEdge("E", "F", 2);

        // DFS
        Console.Write("DFS:");
        graph.DFS("A");
        Console.WriteLine();

        // BFS
        Console.Write("BFS:");
        graph.BFS("A");
        Console.WriteLine();

        // ShortPath
        Console.Write("ShortPath:");
        graph.ShortPath("A", "F");
        Console.WriteLine();

        // Dijkstra
        Console.Write($"Dijkstra:");
        graph.Dijkstra("A", "F");
    }
}

public class Graph<T> where T : notnull
{
    // Class Nodes
    private class Node
    {
        public T Data { get; private set; }
        public List<Edge> AdjacentNodes { get; private set; }

        public Node(T data)
        {
            Data = data;
            AdjacentNodes = new List<Edge>();
        }
    }

    // Class Edge
    private class Edge
    {
        public Node Destination { get; set; }
        public int Weight { get; set; }

        public Edge(Node destination, int weight)
        {
            Destination = destination;
            Weight = weight;
        }
    }

    // Start Graph
    private Dictionary<T, Node> _graph;

    public Graph()
    {
        _graph = new Dictionary<T, Node>();
    }

    // add vertex
    public void AddVertex(T data)
    {
        if (!_graph.ContainsKey(data))
        {
            var node = new Node(data);
            _graph.Add(data, node);
        }
    }

    // add edge
    public void AddEdge(T source, T destination, int weight)
    {
        if(!_graph.ContainsKey(source) || !_graph.ContainsKey(destination))
        {
            throw new KeyNotFoundException("The key not found.");
        }

        if(!_graph[source].AdjacentNodes.Any(e => e.Destination == _graph[destination]))
        {
            _graph[source].AdjacentNodes.Add(new Edge(_graph[destination], weight));
        }
    }

    // Remove Vertex
    public bool RemoveVertex(T target)
    {

        if (!_graph.ContainsKey(target))
        {
            throw new KeyNotFoundException("The key not found.");
        }

        var NodeToRemove = _graph[target];
        
        foreach(var node in _graph.Values)
        {
            node.AdjacentNodes.RemoveAll(
                e => e.Destination == NodeToRemove
            );
        }

        return _graph.Remove(target);
    }

    // Remover Edge
    public bool RemoveEdge(T source, T destination)
    {
        if(!_graph.ContainsKey(source) || !_graph.ContainsKey(destination))
        {
            throw new KeyNotFoundException("The key not found.");
        }

        var sourceNode = _graph[source];
        var destinationNode = _graph[destination];

        var edgeToRemove = sourceNode.AdjacentNodes.FirstOrDefault(e => e.Destination == destinationNode);

        if (edgeToRemove == null)
        {
            return false;
        }

        sourceNode.AdjacentNodes.Remove(edgeToRemove);
        return true;
    }

    // DFS
    public void DFS(T vertex)
    {
        if (!_graph.ContainsKey(vertex))
        {
            throw new KeyNotFoundException("The key not found.");
        }
        
        var visited = new HashSet<Node>();
        var node = _graph[vertex];
        DFS(node, visited);
    }

    private void DFS(Node vertex, HashSet<Node> visited)
    {

        if (visited.Contains(vertex))
        {
            return;
        }

        // add at visited
        visited.Add(vertex);
        Console.Write($" -> {vertex.Data}");

        foreach(var edge in vertex.AdjacentNodes)
        {
            DFS(edge.Destination, visited);
        }

    }

    // BFS
    public void BFS(T vertex)
    {
        if (!_graph.ContainsKey(vertex))
        {
            throw new KeyNotFoundException("The key not found.");
        }

        var node = GetNode(vertex);
        BFS(node);
    }
    private void BFS(Node start)
    {
        var visited = new HashSet<Node>();
        var queue = new Queue<Node>();
        
        visited.Add(start);
        queue.Enqueue(start);

        while(queue.Count > 0)
        {
            var current = queue.Dequeue();
            Console.Write($" -> {current.Data}");
            foreach(var edge in current.AdjacentNodes)
            {
                if (!visited.Contains(edge.Destination))
                {
                    visited.Add(edge.Destination);
                    queue.Enqueue(edge.Destination);
                }
            }
        }
    }

    // ShortPath
    public void ShortPath (T start, T target)
    {
        if(!_graph.ContainsKey(start) || !_graph.ContainsKey(target))
        {
            throw new KeyNotFoundException("The key not found.");
        }
        
        var _start = GetNode(start);
        var _target = GetNode(target);

        ShortPath(_start, _target);
    }

    private void ShortPath(Node start, Node target)
    {
        if(start == target)
        {
            Console.Write($"-> {start.Data}");
            return;
        }

        var visited = new HashSet<Node>();
        var queue = new Queue<Node>();
        var parent = new Dictionary<Node, Node>();
        var stack = new Stack<Node>();
        

        visited.Add(start);
        queue.Enqueue(start);

        while(queue.Count > 0)
        {
            var current = queue.Dequeue();
            foreach(var edge in current.AdjacentNodes)
            {

                if (!visited.Contains(edge.Destination))
                {
                    visited.Add(edge.Destination);
                    queue.Enqueue(edge.Destination);
                    parent.Add(edge.Destination, current);
                }
            }

            if (parent.ContainsKey(target))
            {
                break;
            }
        }

        if (!parent.ContainsKey(target))
        {
            return;
        }

        var vertex = target;

        while (vertex != start)
        {
            stack.Push(vertex);
            vertex = parent[vertex];
        }

        stack.Push(vertex);

        while(stack.Count > 0)
        {
            Console.Write($" -> {stack.Pop().Data}");
        }
    }

    // Class Dijkstra
    private class DijkstraTabelaEntry
    {
        public int Weight { get; set; }
        public Node? Previous { get; set; }

        public DijkstraTabelaEntry(int weight, Node previous)
        {
            Weight = weight;
            Previous = previous;
        }
    }


    // Dijkstra
    public void Dijkstra(T start, T target)
    {
        var source = GetNode(start);
        var destination = GetNode(target);

        var visited = new HashSet<Node>();
        var dijkstraTable = new Dictionary<Node, DijkstraTabelaEntry>();

        foreach(var node in _graph.Values)
        {
            dijkstraTable[node] = new DijkstraTabelaEntry(int.MaxValue, null);
        }

        dijkstraTable[source].Weight = 0;
        var ToVisiti = new PriorityQueue<Node,int>();
        ToVisiti.Enqueue(source, 0);

        while(ToVisiti.Count > 0)
        {
            var current = ToVisiti.Dequeue();
            if (visited.Contains(current))
            {
                continue;
            }

            visited.Add(current);
            foreach(var edge in current.AdjacentNodes)
            {
                var candidateWeight =  edge.Weight;
                var weightFromTable = dijkstraTable[edge.Destination].Weight;

                if(candidateWeight < weightFromTable)
                {
                    dijkstraTable[edge.Destination].Weight = candidateWeight;
                    dijkstraTable[edge.Destination].Previous = current;
                }

                if (!visited.Contains(edge.Destination))
                {
                    ToVisiti.Enqueue(edge.Destination, candidateWeight);
                }
            }
        }

        if (!visited.Contains(destination))
        {
            Console.WriteLine($"Not found key");
            return;
        }

        var stack = new Stack<Node>();

        while(source != destination)
        {
            stack.Push(destination);
            destination = dijkstraTable[destination].Previous;
        }

        stack.Push(source);

        while(stack.Count > 0)
        {
            Console.Write($" --> {stack.Pop().Data}");
        }
    }

    private Node GetNode(T start)
    {
        return _graph[start];
    }
}