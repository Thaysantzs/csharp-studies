using System;
using DataStructures.DoubleLinkedList;
namespace DataStructures.Stack;
public class MyStack
{
    private DoubleLinked List { get; set; }
    private const string STACK_EMPTY_MESSAGE = "The list is empty";
    private const string STACK_FULL_MESSAGE = "The list is full";

    public string Peek {
        get
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException(STACK_EMPTY_MESSAGE);
            }

            return List.Head;
        }
    }

    public MyStack(int capacity = int.MaxValue)
    {
        List = new DoubleLinked();
        Capacity = capacity;
    }

    public int Capacity { get; private set; }

    public bool IsEmpty {
        get
        {
            if(List.Head == null)
            {
                return true;
            }

            return false;        
        } 
    }

    public bool IsFull {
        get
        {
            return List.Count == Capacity;
        }
    }

    public int Length {
        get
        {
            return List.Count;
        }
    }
    
    public void Push(string data)
    {
        if (IsFull)
        {
            throw new InvalidOperationException(STACK_FULL_MESSAGE);
        }

        List.AddAtHead(data);
    }

    public string Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException(STACK_EMPTY_MESSAGE);    
        }

        string value = List.Head;
        List.DeleteAtHead();
        return value;
    }
}