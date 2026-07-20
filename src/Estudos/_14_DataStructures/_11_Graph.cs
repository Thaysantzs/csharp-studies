using System;
namespace DataStructures.Graph;

/*  
    
______Graph ->________
          
        A         
      /   \       
     B     C     
    / \     \  
   D   E     F

______Graph ->________ 

*/

public class GraphApp
{
    public static void Main(string[] args)
    {
        var _graph = new NewGraph();

        _graph.AddVertex("A");
        _graph.AddVertex("B");
        _graph.AddVertex("C");
        _graph.AddVertex("D");
        _graph.AddVertex("E");
        _graph.AddVertex("F");

        _graph.AddEdge("A", "B");
        _graph.AddEdge("A", "C");
        _graph.AddEdge("B", "D");
        _graph.AddEdge("B", "E");
        _graph.AddEdge("C", "F");
        _graph.AddEdge("C", "F");

        // _graph.Print();

        _graph.DFS("A");
        Console.WriteLine();

        _graph.BFS("A");
        Console.WriteLine();

        _graph.ShortestPath("A", "D");
    }
}
public class NewGraph
{
    private Dictionary<string, List<string>> _graph;

    public NewGraph()
    {
        _graph = new Dictionary<string, List<string>>();
    }

    public void AddVertex(string vertex)
    {
        if (!_graph.ContainsKey(vertex))
        {
            var _list =  new List<string>();
            _graph.Add(vertex, _list);
        }
    }

    public void AddEdge(string vertex1, string vertex2)
    {
        if (!_graph.ContainsKey(vertex1) || !_graph.ContainsKey(vertex2))
        {
            throw new KeyNotFoundException("The key not found.");
        }

        if (_graph[vertex1].Contains(vertex2))
        {
            return;
        }

        _graph[vertex1].Add(vertex2);
        _graph[vertex2].Add(vertex1);
    }
    // Depth First Search
    public void DFS(string vertex)
    {
        var visited = new HashSet<string>();
        DFS(vertex, visited);
    }
    
    // Depth First Search
    private void DFS(string vertex, HashSet<string> visited)
    {
        if (visited.Contains(vertex))
        {
            return;
        }

        visited.Add(vertex);

        Console.Write($"{vertex} ");

        foreach(var neighbor in _graph[vertex])
        {
            DFS(neighbor, visited);
        }
    }

    // Breadth First Search
    public void BFS(string vertex)
    {
        var visited = new HashSet<string>();
        var line = new Queue<string>();
        line.Enqueue(vertex);
        visited.Add(vertex);

        while(line.Count > 0)
        {
            vertex = line.Dequeue();
            
            Console.Write($"-> {vertex} ");
            foreach(var neighbor in _graph[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    line.Enqueue(neighbor);
                }
            }
        }
    }

    // ShortTestPath
    public void ShortestPath(string start, string target)
    {
        var parent = new Dictionary<string, string>();
        var visited = new HashSet<string>();
        var line = new Queue<string>();
        line.Enqueue(start);
        visited.Add(start);

        while(line.Count > 0)
        {
            start = line.Dequeue();

            foreach(var neighbor in _graph[start])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    line.Enqueue(neighbor);
                    parent.Add(neighbor, start);
                }
            }
        }

        Revertshort(parent, target);
    }

    private void Revertshort(Dictionary<string, string> parent, string target)
    {
        if(!parent.ContainsKey(target))
        {
          Console.Write($"--> {target}");
          return;  
        }

        Revertshort(parent, parent[target]);
        Console.Write($" --> {target}");
    }

    public void Print()
    {
        foreach(var element in _graph)
        {
            Console.Write($"{element.Key} -> [ ");
            foreach(var data in element.Value)
            {
                Console.Write($"{data} ");
            }
            Console.WriteLine($"]");
        }
    }
}