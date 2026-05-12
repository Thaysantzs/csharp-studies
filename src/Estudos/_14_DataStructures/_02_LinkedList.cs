using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Diagnostics;
namespace DataStructures.LinkedList;

public class LinkedListApp
{
    public static void Main(string[] args)
    {
        ForeachDemo();
        //PerfomanceConsideration();
    }

    private static void PerfomanceConsideration()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        var list = new LinkedList();
        Random random = new Random();
        for (int i = 0; i < 100000; i++)
        {
        list.AddAt(random.Next(1000000).ToString(), random.Next(0, (int)(list.Count + 1)));
        //list.AddAtTail(random.Next(1000000).ToString());
        if (i % 1000 == 0)
            Console.Write(".");
        }
        Console.WriteLine($"\nList Count: {list.Count}");

        stopwatch.Stop();
        Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");
    }

    private static void ForeachDemo()
    {
        LinkedList linkedList = new LinkedList();
        linkedList.AddTail("Node A");//0
        linkedList.AddTail("Node B");//1
        linkedList.AddTail("Node D");//3
        linkedList.AddTail("Node F");//5
        linkedList.AddTail("Node G");//6
        linkedList.AddTail("Node I");//8
        linkedList.AddAt("Node C", 2); //2
        linkedList.AddAt("Node H", 6);//7
        linkedList.AddAt("Node E", 4);//4
        linkedList.AddTail("Node k");//10
        linkedList.AddAt("Node J", 9);//9
        Console.WriteLine(linkedList.Get(9));
        Console.WriteLine(linkedList.Get(10));
        linkedList.AddAt("Node L", 11);//11


        // linkedList.DeleteAtHead();
        //linkedList.DeleteAtTail();
        linkedList.DeleteAt(7);


        Node? current = linkedList.Head;
        
        while(current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }

        Console.WriteLine("ForEach");

        foreach(Node node in linkedList)
        {
            Console.WriteLine(node);
        }
        foreach(Node node in linkedList)
        {
        Console.WriteLine($"Node Data: {node.Data}");
        }
    }
}

public class Node
{
    public string? Data { get; set; }
    public Node? Next { get; set; }

    public Node(string data)
    {
        Data = data;
        Next = null;
    }

    public override string ToString()
    {
        return $"[{Data}]";
    }
}

public class LinkedList : IEnumerable
{
    public Node? Head { get; private set; }

    public Node? Tail { get; private set; }

    public int Count { get; private set; }

    public LinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public void AddAtHead(string data)
    {
        Node newNode = new Node(data);

        if(Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }

        Count++;
    }

    public void AddTail(string data)
    {
        if(Head == null)
        {
            AddAtHead(data);
        }
        else
        {
            Node newNode = new Node(data);
            Count++;
            Tail!.Next = newNode;
            Tail = newNode;
        }
    }

    public void AddAt(string data, int index)
    {
        if(index < 0 || index > Count)
        {
            string msg = $"Invalid index: {index}. Valid range: 0 to {Count -1}";
            throw new IndexOutOfRangeException(msg);
        } 
        else if(index == 0)
        {
            AddAtHead(data);
        }
        else if(index == Count)
        {
            AddTail(data);
        }
        else
        {
            Node? newNode = new Node(data);
            Node? runner = Head;

            for(int i = 0; i < index - 1; i++)
            {
                runner =  runner?.Next;
            }

            newNode.Next = runner?.Next;
            runner!.Next = newNode;
            Count++;
        }
    }

    public Node? Get(int index)
    {
        if(index < 0 || index >= Count)
        {
            string msg = $"Invalid index: {index}. Valid range: 0 to {Count -1}";
            throw new IndexOutOfRangeException(msg);
        } 
      
        Node? runner = Head;
        for(int i = 0; i < index; i++)
        {
            runner = runner?.Next;
        }
        return runner;
    }

    public void DeleteAtHead()
    {
        if(Head == null)
        {
            string msg = $"There isn't items in the list";
            throw new Exception(msg);
        }

        Head = Head.Next;
        Count--;
        if(Count == 0)
        {
            Tail = null;
        }
    }

    public void DeleteAtTail()
    {
        if(Head == null)
        {
            string msg = $"There isn't items in the list";
            throw new Exception(msg);
        }
        
        if(Count == 1)
        {
            DeleteAtHead();
        }
        else
        {
            Node? secondLast = Get(Count -2);
            Tail = secondLast;
            Tail!.Next = null;
            Count--;
        }
    }

    public void DeleteAt(int index)
    {
       if(Count == 0 || index < 0 || index >= Count )
        {
            string msg = $"Invalid index: {index}. Valid range: 0 to {Count -1}";
            throw new IndexOutOfRangeException(msg);
        }else if(index == 0)
        {
            DeleteAtHead();
        }else if(index == Count -1)
        {
            DeleteAtTail();
        }
        else
        {
            Node? runner = Head;
            for(int i = 0; i < index - 1; i++)
            {
                runner = runner?.Next;
            }

            runner!.Next = runner.Next?.Next;
            Count--;
        }
    }

    public IEnumerator GetEnumerator()
    {
        Node? current = Head;
        while(current != null)
        {
            yield return current;
            current = current.Next;
        }
    }
}