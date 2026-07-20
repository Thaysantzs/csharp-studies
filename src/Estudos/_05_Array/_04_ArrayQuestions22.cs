using System;
using Ourcompany;
using MyArray;
/*22. Implement a routine to rotate an array n positions to the left: RotateLeft(array, offset)
    Can you do it in-place?*/

public class ArrayQuestion22
{
    public static void Main(string[] args)
    {
        int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};  //{4, 5, 6, 7, 8, 9, 0, 1, 2, 3}
        int[] arrayRotate = RotateLeft(array, 4);
        CopyArray.PrintArray(arrayRotate);
    }

    private static int[] RotateLeft(int[] array, int n)
    {
        ReverseArray(array, 0, array.Length - 1);
        ReverseArray(array, array.Length - n, array.Length - 1);
        ReverseArray(array, 0, array.Length - n - 1);
        return array;
    }

    private static int[] ReverseArray(int[] array, int left, int right)
    {
        for (int i = left; i < right; i++)
        {
            int aux = array[left];
            array[left] = array[right];
            array[right] = aux;
            left++;
            right--;
        }
        return array;
    }
}