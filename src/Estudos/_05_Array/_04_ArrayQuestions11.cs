using System;
using Ourcompany;
using MyArray;
/*11. Implement a routine to reverse an integer array. Try it in-places*/

public class ArrayQuestion11
{
    public static void Main(string[] args)
    {
        int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        CopyArray.PrintArray(array, "Original");
        ArrayReverse(ref array);
        CopyArray.PrintArray(array, "Reversed");
    }

    public static void ArrayReverse(ref int[] array)
    {
        int[] reversed = new int[array.Length];
        int j = reversed.Length - 1;
        for (int i = 0; i < array.Length; i++)
        {
            reversed[j] = array[i];
            j--;
        }
        array = reversed;
    }
}