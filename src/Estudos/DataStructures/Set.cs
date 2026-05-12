using System;
using DataStructures.NewLinked;
namespace DataStructures.NewSet;

public class NewSet<T>
{
    private readonly DoublyLinkedList<T> _list;
    private  readonly IEqualityComparer<T> _comparer;
    public int Capacity { get;}
    public int Count => _list.Count;

    public NewSet(int capacity = int.MaxValue)
    {
        _list = new DoublyLinkedList<T>();
        _comparer = EqualityComparer<T>.Default;
        Capacity = capacity;
    }

    public bool Add(T value)
    {
       if(Count == Capacity)
        {
            throw new InvalidOperationException("Set is full.");
        }

        if (Contains(value))
        {
            return false;
        }
        _list.AddAtHead(value);
        return true;
    }

    public void Remove(T value)
    {
        int index = 0;

        foreach(var item in _list)
        {
            if(_comparer.Equals(item, value))
            {
                _list.RemoveAt(index);
                return;
            }
            index++;
        }

        throw new KeyNotFoundException("Value not found.");
    }

    public bool Contains(T value)
    {
        foreach(var element in _list)
        {
            if (_comparer.Equals(element, value))
            {
                return true;
            }
        }
        return false;
    }

}