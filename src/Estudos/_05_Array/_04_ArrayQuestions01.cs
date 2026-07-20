using System;
using MyArray;
using Ourcompany;

/*1. Implement a routine to clone an array of integers: int[] Clone(int[])*/
public class ArrayQuestion01
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] cloneArray = CopyArray.Clone(numbers);

        numbers[0] = 9;
        numbers[8] = 1;

        Library.PrintingIntArray(numbers, "numbers", true);
        Library.PrintingIntArray(cloneArray, "cloneArray", true);
    }
}