using System;
namespace DataStructures.HashTable;

public class MyHashTable
{
    public int TABLE_SIZE = 1000;
    private List<int>[] table; 
    public int Size { get; private set; }

    public MyHashTable()
    {
        table = new List<int>[TABLE_SIZE];
        Size = 0;
    }

    public void add(int value)
    {
        int index = GetHashCode(value);
        if(table[index] == null)
        {
            table[index] = new List<int>();
        }

        if (!table[index].Contains(value))
        {
            table[index].Add(value);
            Size++;
        }
    }

    private int GetHashCode(int value)
    {
        return value % TABLE_SIZE;
    }

    public void Remove(int value)
    {
        int index = GetHashCode(value);
        if(table[index] == null)
        {
            return;
        }
        if (table[index].Contains(value))
        {
            table[index].Remove(value);
            Size--;
        }
    }

    public bool Contains(int value)
    {
        int index = GetHashCode(value);
        if(table[index] == null)
        {
            return false;
        }
        return table[index].Contains(value);
    }
}