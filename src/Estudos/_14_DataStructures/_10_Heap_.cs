using System;
namespace DataStructures.Heap;
public class HeapApp
{
    public static void Main(string[] args)
    {
        int[] Data = new int[16] {50, 25, 75, 12, 35, 65, 90, 5, 47, 85, 100, 4, 6, 40, 49, 89};

        var heap = new MyHeap(Data);
        heap.add(79);
        heap.Print();
    }
}

public class MyHeap
{
    private List<int> Data;
    public MyHeap(int[] data)
    {
        if(data == null)
        {
            Data = new List<int>();
        }
        else
        {
            Data = data.ToList();
            Heapify();
        }
    }

    private void Heapify()
    {
        for(int i = Data.Count - 1; i >= 0; i--)
        {
            Heapify(i);
        }
    }

    private void Heapify(int index)
    {
        var childrenIndexes = GetChildrenIndexes(index);
        int greaterIndex = index;

        if(childrenIndexes.Left < Data.Count && Data[childrenIndexes.Left] > Data[greaterIndex])
        {
            greaterIndex = childrenIndexes.Left;
        }

        if(childrenIndexes.Right < Data.Count && Data[childrenIndexes.Right] > Data[greaterIndex])
        {
            greaterIndex = childrenIndexes.Right;
        }

        if(index != greaterIndex) // We found a greater chield value
        {
            Swap(index, greaterIndex);
            Heapify(greaterIndex);
        }
    }

    private void Swap(int Left, int Right)
    {
        int aux = Data[Left];
        Data[Left] = Data[Right];
        Data[Right] = aux;
    }

    private (int Left, int Right) GetChildrenIndexes (int index) // Get index chield
    {
        return(index * 2 + 1, index * 2 + 2);
    }

    public void add(int value)
    {
        Data.Add(79);
        int index = Data.Count - 1;
        int parent = GetParentIndex(index);

        while(Data[index] > Data[parent])
        {
            Swap(parent, index);
            index = parent;
            parent = GetParentIndex(parent);
        }
    }

    /* --> Recusive version
    private void add(int index, int parent)
    {
        if(Data[index] < Data[parent])
        {
            return;
        }

        Swap(parent, index);
        index = parent;
        parent = GetParentIndex(parent);
        add(index, parent);
    }
    */

    private int GetParentIndex(int index) // Get index parent
    {
        return (index - 1) / 2;
    }

    public int Pop()
    {
        if(Data.Count == 0)
        {
            throw new Exception("The heap is empty");
        }

        int max = Data[0];
        Data[0] = Data[Data.Count - 1];
        Data.RemoveAt(Data.Count - 1);
        Heapify(0);
        return max;
    }
    public void Print()
    {
        foreach(var element in Data)
        {
            Console.Write($"{element}, ");
        }
    }
}