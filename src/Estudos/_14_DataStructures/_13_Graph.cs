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

        // ADD EDGE
        graph.AddEdge("A", "B");
        graph.AddEdge("A", "C");
        graph.AddEdge("B", "D");
        graph.AddEdge("C", "D");
        graph.AddEdge("D", "E");

        // REMOVE VERTEX
        //graph.RemoveVertex("D");

        //REMOVE EDGE
        //graph.RemoveEdge("D", "B");
        //graph.RemoveEdge("D", "C");

        // DFS
        Console.Write("DFS: ");
        graph.DFS("A");
        Console.WriteLine();

        // BFS
        Console.Write("BFS: ");
        graph.BFS("A");
        Console.WriteLine();

        // ShortPath
        Console.Write("ShortPath: ");
        graph.ShortPath("A", "D");

    }
}

public class Graph<T> where T : notnull
{
    // Class Nodes
    private class Node
    {
        public T Data { get; private set; }
        public List<Node> AdjacentNodes { get; private set; }

        public Node(T data)
        {
            Data = data;
            AdjacentNodes = new List<Node>();
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
    public void AddEdge(T key, T vertex)
    {
        if(!_graph.ContainsKey(key) || !_graph.ContainsKey(vertex))
        {
            throw new KeyNotFoundException("The key not found.");
        }

        if (!_graph[key].AdjacentNodes.Contains(_graph[vertex]))
        {
            _graph[key].AdjacentNodes.Add(_graph[vertex]);
        }
    }

    // Remove Vertex
    public bool RemoveVertex(T target)
    {

        if (!_graph.ContainsKey(target))
        {
            throw new KeyNotFoundException("The key not found.");
        }

        var nodeToRemove = _graph[target];

        foreach(var item in _graph)
        {
            item.Value.AdjacentNodes.Remove(nodeToRemove);
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

        return _graph[source].AdjacentNodes.Remove(_graph[destination]);
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

        foreach(var neighbor in vertex.AdjacentNodes)
        {
            DFS(neighbor, visited);
        }

    }

    // BFS
    public void BFS(T vertex)
    {
        if (!_graph.ContainsKey(vertex))
        {
            throw new KeyNotFoundException("The key not found.");
        }

        var node = _graph[vertex];
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
            foreach(var neighbor in current.AdjacentNodes)
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
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
        
        var _start = _graph[start];
        var _target = _graph[target];

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
            foreach(var neighbor in current.AdjacentNodes)
            {

                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                    parent.Add(neighbor, current);
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
}