using System;
using Ourcompany;
using MyArray;
/*8. Implement a routine to generate an integer array with randon numbers from a provided interval: int[] GenerateRandomArray(length, minValue, maxValue)*/

public class ArrayQuestion08
{
    public static void Main(string[] args)
    {
        int size = Library.ReadInterge("Array Size ");
        int minValue = Library.ReadInterge("Minimum size ");
        int maxValue = Library.ReadInterge("Maximum size ");
        int[] numbers = GenerateRandomArray(size, minValue, maxValue);

        CopyArray.PrintArray(numbers, "RANDOM-ARRAY", true);
    }

    private static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        int[] array = new int[size];
        Random rdn = new Random();

        if(minValue > maxValue)
        {
            int aux = minValue;
            minValue = maxValue;
            maxValue = aux;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rdn.Next(minValue, maxValue + 1);
        }

        return array;
    }
}