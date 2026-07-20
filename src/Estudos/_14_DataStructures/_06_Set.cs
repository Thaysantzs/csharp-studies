using System;
namespace DataStructures.Set;

public class MySet
{
    private readonly bool[] values;
    public int Peek { get; private set; }

    public MySet(int capacity)
    {
        values = new bool[capacity];
    }

    public int Size { get; set; }

    public void Add(int value)
    {
        if(value < 0 || value >= values.Length)
        {
            throw new InvalidOperationException($"This is a invalid value {value}.");
        }

        if (!values[value])
        {
            Peek = value;
            Size++;
            values[value] = true;
        }
    }

    public void Delete(int value)
    {
        if(value < 0 || value >= values.Length)
        {
            throw new InvalidOperationException($"This is a invalid value {value}.");
        }

        if (values[value])
        {
            Size--;
            values[value] = false;
        }
    }

    public bool Contains(int value)
    {
        return values[value];
    }   
}