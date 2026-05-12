using System;
using Ourcompany;
using MyArray;
/* 2. Implement a routine to read an array of integers from the Console: int[] ReadIntArray(string: label, int: length)
    Use 'label[index] = ' for each element*/

public class ArrayQuestion02
{
    public static void Main(string[] args)
    {
        int[] array = CopyArray.ReadIntArray("Array", 10);
        Library.PrintingIntArray(array, "Array");
    }
}