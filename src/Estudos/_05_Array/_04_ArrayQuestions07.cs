using System;
using Ourcompany;
using MyArray;
/*7. Implement a routine to fill an integer array with an specific value: Fill(array, start, end, value)*/

public class ArrayQuestion07
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        CopyArray.PrintArray(array, "Original");
        Fill(array, 3, 9, 3);
        CopyArray.PrintArray(array, "After Fill");
    }

    public static void Fill(int[] array, int start, int end, int value)
    {
        if(start >= 0 && end >= 0 && start <= end && start < array.Length && end < array.Length)
        {
            for (int i = start; i <= end; i++)
            {
                array[i] = value;
            }
        }
    }
}