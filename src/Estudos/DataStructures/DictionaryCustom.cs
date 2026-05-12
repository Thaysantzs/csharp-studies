using System;
using DataStructures.NewLinked;
namespace DataStructures.Dictionary;

public class DictionaryCustom<TKey, TValue>
{
    private readonly DoublyLinkedList<KeyValuePair<TKey, TValue>>[] _buckets;
    private readonly IEqualityComparer<TKey> _comparer;
    public int Count { get; private set; }
    public TValue this[TKey key]
    {
        get => Get(key);

        set
        {
            int index = GetIndex(key);

            if(_buckets[index] == null)
            {
                _buckets[index] = new DoublyLinkedList<KeyValuePair<TKey, TValue>>();
            }

            int i = 0;
            foreach(var element in _buckets[index])
            {
                if(_comparer.Equals(element.Key, key))
                {
                    _buckets[index].RemoveAt(i);
                    _buckets[index].AddAtTail(new KeyValuePair<TKey, TValue>(key, value));
                    return;
                }
                i++;
            }
            _buckets[index].AddAtTail(new KeyValuePair<TKey, TValue>(key, value));
            Count++;
        }
    }

    public DictionaryCustom(int capacity = 16)
    {
        if(capacity <= 0)
        {
            throw new ArgumentException("Capacity must be greater than zero.");
        }
        _buckets = new DoublyLinkedList<KeyValuePair<TKey, TValue>>[capacity];
        _comparer = EqualityComparer<TKey>.Default;
        Count = 0;
    }

    public bool Add(TKey key, TValue value)
    {
        int index = GetIndex(key);
        if(_buckets[index] == null)
        {
            _buckets[index] = new DoublyLinkedList<KeyValuePair<TKey, TValue>>();
        }

        foreach(var element in _buckets[index])
        {
            if(_comparer.Equals(element.Key, key))
            {
                return false;
            }
        }

        _buckets[index].AddAtHead(new KeyValuePair<TKey, TValue>(key, value));
        Count++;
        return true;
    }

    private int GetIndex(TKey? key)
    {
        if(key == null)
        {
            throw new ArgumentNullException(nameof(key));
        }
        int hash = _comparer.GetHashCode(key);
        return (hash & 0x7FFFFFFF) % _buckets.Length;
    }

    public bool Remove(TKey key)
    {
        int index = GetIndex(key);
        int i = 0;
    
        if(_buckets[index] == null)
        {
            return false;
        }

        foreach(var element in _buckets[index])
        {
            if(_comparer.Equals(element.Key, key))
            {
                _buckets[index].RemoveAt(i);
                Count--;
                return true;
            }
            i++;
        }

        return false;
    }

    public TValue Get(TKey key)
    {
        var index = GetIndex(key);

        if(_buckets[index] == null)
        {
            throw new KeyNotFoundException();
        }

        foreach(var element in _buckets[index])
        {
            if(_comparer.Equals(element.Key, key))
            {
                return element.Value;
            }
        }

        throw new KeyNotFoundException("Value not found");
    }

    public bool Contains(TKey key)
    {
        var index = GetIndex(key);

        if(_buckets[index] == null)
        {
            return false;
        }

        foreach(var element in _buckets[index])
        {
            if(_comparer.Equals(element.Key, key))
            {
                return true;
            }
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