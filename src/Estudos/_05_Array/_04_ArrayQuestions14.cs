using System;
using Ourcompany;
using MyArray;
/*14. Implement a routine to return a new array with only unique values from an array of integers*/

public class ArrayQuestion14
{
    public static void Main(string[] args)
    {
        int[] array = { 3, 5, 8, 9, 3, 5, 1, 2, 5, 5, 5, 6, 8, 0, 4 };
        CopyArray.PrintArray(array, "Array 1: ");
        int[] uniqueArray = GetUnique(array);
        CopyArray.PrintArray(uniqueArray, "unique Array: ");

    }

    public static int[] GetUnique(int[] array)
    {
        int[] unique = new int[array.Length];
        int uniqueIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bool found = false;

            for (int j = 0; j < unique.Length; j++)
            {
                if (array[i] == unique[j])
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                unique[uniqueIndex] = array[i];
                uniqueIndex++;
            }
        }

        int[] result = new int[uniqueIndex];
        Array.Copy(result, 0, unique, 0, uniqueIndex);

        return result;
    }
}