using System;
using System.Collections;
using System.IO.Compression;
namespace DataStructures.NewLinked;

public class NewLinkedApp
{
    public static void Main(string[] args)
    {
        var list = new DoublyLinkedList<string>();

        // Add elements in the list
        list.AddAtTail("Node 0");
        list.AddAtTail("Node 1"); // x
        list.AddAtTail("Node 2"); // x
        list.AddAtTail("Node 3");
        list.AddAtTail("Node 4"); // x
        list.AddAtTail("Node 6"); // x
        list.AddAtTail("Node 8"); // x

        foreach(string node in list)
        {
            Console.WriteLine(node);
        }

    }
}

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private class Node
    {
        public T Data { get; private set; }
        public Node? Next { get; set; }
        public Node? Previous { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }

        public override string ToString()
        {
            return $"{Data}";
        }
    }

    const string MESSAGE = "It's not possible to remove items from an empty list";
    private Node? _Head;
    private Node? _Tail;

    public int Count { get; private set; }

    public T? Head => _Head != null ? _Head.Data : default;
    public T? Tail => _Tail != null ? _Tail.Data : default;

    public DoublyLinkedList()
    {
        _Head = null;
        _Tail = null;
        Count = 0;
    }

    public void AddAtHead(T data)
    {
        var newNode = new Node(data);
        if(_Head == null)
        {
            _Head = newNode;
            _Tail = newNode;
        }
        else
        {
            _Head.Previous = newNode;
            newNode.Next = _Head;
            _Head = newNode;
        }
        Count++;
    }

    public void AddAtTail(T data)
    {
        var newNode = new Node(data);
        if(_Tail == null)
        {
            _Head = newNode;
            _Tail = newNode;
        }
        else
        {
            _Tail.Next = newNode;
            newNode.Previous = _Tail;
            _Tail = newNode;
        }
        Count++;
    }

    public void AddAt(T data, int index)
    {
        if(index < 0 || index > Count)
        {
            throw new IndexOutOfRangeException($"Invalid index: {index}. Valid range: 0 to {Count -1}");
        }

        if(index == 0)
        {
            AddAtHead(data);
        }else if(index == Count)
        {
            AddAtTail(data);
        }
        else
        {
            var newNode = new Node(data);
            Node runner = _Get(index);

            newNode.Previous = runner.Previous;
            newNode.Next = runner;
            runner.Previous!.Next = newNode;
            runner.Previous = newNode;
            Count++;
        }
    }

    public T Get(int index)
    {
        return _Get(index)!.Data!;
    }

    private Node _Get(int index)
    {
        if(index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException($"Invalid index: {index}. Valid range: 0 to {Count -1}");
        }

        Node? runner;
        
       if(index < Count / 2)
        {
            runner = _Head;
            for(int i = 0; i < index; i++)
            {
                runner = runner?.Next;
            }
        }
        else
        {
            runner = _Tail;
            for(int i = Count - 1; i > index; i--)
            {
                runner = runner?.Previous;
            }
        }

        return runner!;
    }

    public void RemoveHead()
    {
        if(_Head == null)
        {
            throw new InvalidOperationException(MESSAGE);
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

    public void RemoveTail()
    {
        if(_Tail == null)
        {
            throw new InvalidOperationException(MESSAGE);
        }

        if(Count == 1)
        {
            _Head = null;
            _Tail = null;
        }
        else
        {
            _Tail = _Tail.Previous;
            _Tail!.Next = null;
        }
        Count--;
    }

    public void RemoveAt(int index)
    {
        if(index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException($"Invalid index: {index}. Valid range: 0 to {Count -1}");
        }

        if(index == 0)
        {
            RemoveHead();
        }else if(index == Count - 1)
        {
            RemoveTail();
        }
        else
        {
            Node? runner = _Get(index);

            runner.Next!.Previous = runner.Previous;
            runner.Previous!.Next = runner.Next;
            Count--;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node? current = _Head;
        while(current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
} 