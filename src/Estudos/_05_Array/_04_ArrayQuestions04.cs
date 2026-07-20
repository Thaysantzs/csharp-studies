using System;
using Ourcompany;
using MyArray;
/*4. Implement a routine to receive an integer array and return the min and max values as output parameters: FindMinAndMax(array, out min, out max)*/

public class ArrayQuestion04
{
    public static void Main(string[] args)
    {
        int[] array = CopyArray.ReadIntArray("My Array", 5);
        CopyArray.FindMinAndMax(array, "My Array");
    }
}