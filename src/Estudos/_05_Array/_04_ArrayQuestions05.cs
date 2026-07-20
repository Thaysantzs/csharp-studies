using System;
using Ourcompany;
using MyArray;
/*5. Implement a routine to calculate the average of an array of integer: decimal ArrayAverage(array)*/

public class ArrayQuestion05
{
    public static void Main(string[] args)
    {
        int[] numbers = CopyArray.ReadIntArray("Numbers", 5);
        double average = CopyArray.ArrayAverage(numbers);
        Console.Write(average);
    }
}