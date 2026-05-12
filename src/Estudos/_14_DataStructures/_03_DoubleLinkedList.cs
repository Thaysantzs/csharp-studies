using System;
namespace DataStructures.DoubleLinkedList;
public class DoubleLinkedListApp
{
    public static void Main(string[] args)
    {
        DoubleLinked list = new DoubleLinked();

        list.AddAtTail("Node 0"); // remove
        list.AddAtTail("Node 1");
        list.AddAtTail("Node 2");
        list.AddAtTail("Node 3");// remove
        list.AddAt("Sem titulo", 2);
        list.DeleteAt(3);
        list.DeleteAt(2);
        list.DeleteAt(1);
        Console.WriteLine(list.Get(0));
    }
}

public class Node
{
    public string? Data { get; set; }
    public Node? Next { get; set; }
    public Node? Previous { get; set; }

    public Node(string data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}

public class DoubleLinked
{
    private Node? _Head { get; set; }
    private Node? _Tail { get; set; }
    public int Count { get; private set; }

    public string Head {
        get
        {
            if(_Head == null)
            {
                return null!;
            }
            return _Head!.Data!;
        }
        set
        {
            _Tail!.Data = value;
        } 
    }

    public string Tail {
        get
        {
            if(_Tail == null)
            {
                return null!;
            }
            return _Tail!.Data!;
        }
        set
        {
            _Tail!.Data = value;    
        }
    }

    public DoubleLinked()
    {
        _Head = null;
        _Tail = null;
        Count = 0;
    }

    // Add node at Head
    public void AddAtHead(string data)
    {
        var newNode = new Node(data);
        if(_Head == null)
        {
            _Head = newNode;
            _Tail = newNode;
        }
        else
        {
            newNode.Next = _Head;
            _Head.Previous = newNode;
            _Head = newNode;
        }
        Count++;
    }

    // Add node at Tail
    public void AddAtTail(string data)
    {
        if(_Head == null)
        {
            AddAtHead(data);
        }
        else
        {
            var newNode = new Node(data);
            _Tail!.Next = newNode;
            newNode.Previous = _Tail;
            _Tail = newNode;
            Count++;
        }
    }

    public string Get(int index)
    {
        return _Get(index)!.Data!;
    }

    // Get element of list
    private Node? _Get(int index)
    {
        if(index < 0 || index > Count - 1)
        {
            string msg = $"Invalid index: {index}. Valid range: 0 to {Count -1}";
            throw new IndexOutOfRangeException(msg);
        }else if(index == 0)
        {
            return _Head;
        }else if(index == Count - 1)
        {
            return _Tail;
        }
        else
        {
            var runner = _Head;
            for(int i = 0; i < index; i++)
            {
                runner = runner?.Next;
            }
            
            return runner;
        }
    }

    // Add node at everwhere
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
        }else if(index == Count)
        {
            AddAtTail(data);
        }
        else
        {
            Node? newNode = new Node(data);
            Node? runner = _Get(index);

            runner!.Previous!.Next = newNode;
            newNode.Next = runner;
            newNode.Previous = runner.Previous;
            runner.Previous = newNode;
            Count++;
        }
    }

    public void DeleteAtHead()
    {
        if(_Head == null)
        {
            string msg = $"There isn't items at list";
            throw new Exception(msg);
        }

        if(Count == 1)
        {
            _Head = null;
            _Tail = null;
        }
        else
        {
            _Head = _Head.Next;
            _Head!.Previous = null;
        }
        Count--;
    }

    public void DeleteAtTail()
    {
        if(_Head == null)
        {
            string msg = $"There isn't items at list";
            throw new Exception(msg);
        }

        if(Count == 1)
        {
            DeleteAtHead();
        }
        else
        {
            var newNode = _Tail!.Previous;
            _Tail.Previous = null;
            newNode!.Next = null;
            _Tail = newNode;
            Count--;
        }
    }

    public void DeleteAt(int index)
    {
        if(index < 0 || index >= Count)
        {
            string msg = $"Invalid index: {index}. Valid range: 0 to {Count -1}";
            throw new IndexOutOfRangeException(msg);
        }
        else if(index == 0)
        {
            DeleteAtHead();
        }
        else if(index == Count -1)
        {
            DeleteAtTail();
        }
        else
        {
            var runner = _Get(index);
            var newNode = runner!.Previous;

            runner.Next!.Previous = newNode;
            newNode!.Next = runner.Next;
            runner.Next = null;
            runner.Previous = null;
            Count--;
        }
    }
}