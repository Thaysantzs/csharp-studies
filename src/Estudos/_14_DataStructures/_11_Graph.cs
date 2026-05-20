using System;
namespace DataStructures.Graph;

public class GraphApp
{
    public static void Main(string[] args)
    {
        var _graph = new NewGraph();

        _graph.AddVertex("A");
        _graph.AddVertex("B");
        _graph.AddVertex("C");
        _graph.AddVertex("D");

        _graph.AddEdge("A", "B");
        _graph.AddEdge("A", "C");
        _graph.AddEdge("B", "D");

        _graph.Print();
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

    public void Print()
    {
        foreach(var element in _graph)
        {
            Console.Write($"{element.Key} -> [ ");
            foreach(var data in element.Value)
            {
                Console.Write($"{data.ToString()} ");
            }
            Console.WriteLine($"]");
        }
    }
}