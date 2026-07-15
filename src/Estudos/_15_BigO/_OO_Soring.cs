using System;
using System.Diagnostics;
using DataStructures.Heap;
namespace SortingBig0;

public class SortingApp
{
    const int LENGTH = 100000000;
    const int MIN = 0;
    const int MAX = 100000000;
    public static void Main(string[] args)
    {
         Stopwatch stopwatch = new Stopwatch();

        // BubbleSort

        var inputBubbleSort = GeneratedSortedArray(1000000, MIN, 10000);

        stopwatch.Restart();
        BubbleSorting(inputBubbleSort);
        stopwatch.Stop();
        Console.WriteLine($"Bubble Sorting: {stopwatch.Elapsed}");

        // SelectionSort 

        var inputSelectionSort = GeneratedSortedArray(1000000, MIN, 10000);

        stopwatch.Restart();
        SelectionSorting(inputSelectionSort);
        stopwatch.Stop();
        Console.WriteLine($"Selection Sorting: {stopwatch.Elapsed}");

        // InsertionSort

        var inputInsertionSort = GeneratedSortedArray(1000000, MIN, 10000);

        stopwatch.Restart();
        InsertionSorting(inputInsertionSort);
        stopwatch.Stop();
        Console.WriteLine($"Insertion Sorting: {stopwatch.Elapsed}");

        // QuickSort

        var inputQuickSort = GeneratedSortedArray(LENGTH, MIN, MAX);

        stopwatch.Restart();
        QuickSort(inputQuickSort);
        stopwatch.Stop();
        Console.WriteLine($"Quick Sort: {stopwatch.Elapsed}");

        // MergeSort
        
        var inputMergeSort = GeneratedSortedArray(LENGTH, MIN, MAX);

        stopwatch.Restart();;
        MergeSort(inputMergeSort);
        stopwatch.Stop();
        Console.WriteLine($"Merge sort: {stopwatch.Elapsed}");

        // HeapSort

        var inputHeapSort = GeneratedSortedArray(LENGTH, MIN, MAX);

        stopwatch.Restart();;
        HeapSort(inputHeapSort);
        stopwatch.Stop();
        Console.WriteLine($"Heap sort: {stopwatch.Elapsed}");
    }
    // HeapSort
    private static void HeapSort(int[] input)
    {
        for(int i = (input.Length / 2 ) - 1; i >= 0; i--)
        {
            Heapify(input, input.Length, i);
        }

        for (int i = input.Length - 1; i >   0; i--)
        {
            Swap(0, i, input);
            Heapify(input, i, 0);
        }
    }

    // Heapfy
    private static void Heapify(int[] input, int heapSize, int root)
    {
        var left = (root * 2 ) + 1;
        var right = (root * 2 ) + 2;

        var largest = root;

        if(left < heapSize && input[left] > input[largest])
        {
            largest = left;
        }

        if(right < heapSize && input[right] > input[largest])
        {
            largest = right;
        }

        if(root != largest)
        {
            Swap(root, largest, input);
            Heapify(input, heapSize, largest);
        }
    }

    // Merge Sort
    private static void MergeSort(int[] input)
    {
        int[] aux = new int [input.Length];
        MergeSort(input, aux, 0, input.Length - 1);
    }

    private static void MergeSort(int[] input, int[] aux, int left, int right)
    {
        int middle = (left + right) / 2;

        if(left < right)
        {
            MergeSort(input, aux,  left, middle);
            MergeSort(input, aux, middle + 1 , right);
            Merge(input, aux, left, middle, right);
        }
    }

    private static void Merge(int[] input, int[] aux,  int left, int middle, int right)
    {
        int i = left;
        int j = middle + 1;
        int k = left;


        while(i <= middle && j <= right)
        {
            if(input[i] <= input[j])
            {
                aux[k] = input[i];
                i++;
            } 
            else
            {
                aux[k] = input[j];
                j++;
            }

            k++;
        }

        while(i <= middle)
        {
            aux[k] = input[i];
            i++;
            k++;
        }

        while(j <= right)
        {
            aux[k] = input[j];
            j++;
            k++;
        }

        for(int c = left; c <= right; c++)
        {
            input[c] = aux[c];
        }
    }


    // Quick
    private static void QuickSort(int[] input)
    {
        Random random = new Random();
        QuickSort(input, 0, input.Length - 1, random);
    }

    private static void QuickSort(int[] input, int left, int right, Random random)
    {
        if(left < right)
        {
            int pivot = Partition(input, left, right, random);
            QuickSort(input, left, pivot - 1, random);
            QuickSort(input, pivot + 1, right, random);
        }
    }

    private static int Partition(int[] input, int left, int right, Random random)
    {
       Swap(random.Next(left, right + 1), right, input); 
       int pivot = input[right];

       int j = left - 1; 

       for(int i = left; i <= right -1; i++)
        {
            if(input[i] < pivot)
            {
                j++;
               Swap(j, i, input);
            }
        }

        Swap(j + 1, right, input);

        return j + 1;
    }

    private static void Swap(int j, int i, int[] input)
    {
        var aux = input[j];
        input[j] = input[i];
        input[i] = aux;
    }

    // Insertion Sorting
    private static void InsertionSorting(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            var current = array[i];
            var j = i - 1;
            while(j >= 0)
            { 
                if(current < array[j])
                {
                    array[j + 1] = array[j];
                    array[j] = current;
                }
                else
                {
                    break;
                }
                j--;
            }
        }
    }
        // Selection Sorting
    private static void SelectionSorting(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            for (int j = i; j < array.Length; j++)
            {
                if(array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            swapper(i, minIndex, array);
        }
    }

    private static void PrintArray(int[] input)
    {
        foreach(var item in input)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
    // Bubble Sorting
    private static void BubbleSorting(int[] input)
    {
        var pointer = input.Length - 1;
        while(pointer >= 0)
        {
            for (int i = 0; i < pointer; i++)
            {
                if(input[i] > input[i + 1])
                {
                    swapper(i, i + 1, input);
                }
            }
            pointer--;
        }
    }

    private static void swapper(int i, int v, int[] array)
    {
       var aux = array[i];
       array[i] = array[v];
       array[v] = aux;
    }

    private static int[] GeneratedSortedArray(int LENGTH, int MIN, int MAX)
    {
        Random random = new Random();
        var array = new int[LENGTH];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(MIN, MAX);
        }
        return array;
    }
}