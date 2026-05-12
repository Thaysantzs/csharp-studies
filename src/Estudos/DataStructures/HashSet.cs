using System;
using DataStructures.NewLinked;
namespace DataStructures.HashSet;

public class HashSetCustom<T>
{
    private readonly DoublyLinkedList<T>[] _buckets;
    private readonly IEqualityComparer<T> _compare;
    public int Count { get; private set;}

    public HashSetCustom(int capacity)
    {
        if(capacity <= 0)
        {
            throw new ArgumentException("Capacity must be greater than zero.");
        }
        _buckets = new DoublyLinkedList<T>[capacity];
        _compare = EqualityComparer<T>.Default;
        Count = 0;
    }

    public bool Add(T value)
    {
        int index = GetIndex(value);

        if(_buckets[index] == null)
        {
            _buckets[index] =  new DoublyLinkedList<T>();
        }

        foreach(var element in _buckets[index])
        {
            if(_compare.Equals(element, value))
            {
                return false;
            }
        }

        _buckets[index].AddAtTail(value);
        Count++;
        return true;
    }

    private int GetIndex(T value)
    {
        int hash = _compare.GetHashCode(value!);
        return (hash & 0x7FFFFFFF) % _buckets.Length;
    }

    public bool Contains(T value)
    {
        int index = GetIndex(value);
        if(_buckets[index] == null)
        {
            return false;
        }

        foreach(var element in _buckets[index])
        {
            if (_compare.Equals(element, value))
            {
                return true;
            }
        }

        return false;
    }

    public bool Remove(T value)
    {
        int index = GetIndex(value);
        if(_buckets[index] == null)
        {
            return false;
        }

        int i = 0;
        foreach(var element in _buckets[index])
        {
            if (_compare.Equals(element, value))
            {
                _buckets[index].RemoveAt(i);
                Count--;
                return true;
            }
            i++;
        }

        return false;
    }

    public void Clear()
    {
        for(int i = 0; i < _buckets.Length; i++)
        {
            _buckets[i] = null!;
        }
        
        Count = 0;
    }
}