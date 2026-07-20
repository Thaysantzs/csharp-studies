using System;
using DataStructures.NewLinked;
namespace DataStructures.NewStack;

public class NewStack<T>
{
    private readonly DoublyLinkedList<T> _list;
    public int Capacity { get; private set; }
    public int Length => _list.Count;

    public T? Peek => IsEmpty ? throw new InvalidOperationException("Stack is empty") : _list.Head;

    public NewStack(int capacity = int.MaxValue)
    {
        _list = new DoublyLinkedList<T>();
        Capacity = capacity;
    }

    public bool IsEmpty => _list.Count == 0;
    public bool IsFull => Capacity == _list.Count;

    public void Push(T value)
    {
        if (IsFull)
        {
            throw new InvalidOperationException("Stack is full");
        }
        _list.AddAtHead(value);
    }

    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T? value = _list.Head;
        _list.RemoveHead();
        return value!;
    }
}