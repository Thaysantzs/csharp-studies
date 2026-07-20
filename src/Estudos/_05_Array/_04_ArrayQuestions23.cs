using System;
using Ourcompany;
using MyArray;
/*23. Implement a routine to move all zeros of an integer array to the left side. Can you do it in-place?*/

public class ArrayQuestion23
{
    public static void Main(string[] args)
    {
        int[] array = {0, 2, 3, 0, 5, 7, 0, 0, 0, 8, 0, 9};
        int[] zeroLeft = MoveZerosLeftInPlace(array);
        CopyArray.PrintArray(zeroLeft);

        int[] array2 = {0, 1, 0, 0, 2, 0, 0, 3, 0, 0, 4, 5, 0, 0, 0, 7, 0, 0};
        int[] zeroLeft2 = MoveZerosLeftInPlace(array2);
        CopyArray.PrintArray(zeroLeft2);

        int[] array3 = {0, 1, 2, 0, 0, 3, 0, 0, 0, 4, 5, 0, 6, 0, 7, 0, 8, 0, 0, 0};
        int[] zeroLeft3 = MoveZerosLeftInPlace(array3);
        CopyArray.PrintArray(zeroLeft3);

        int[] array4 = {1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 6};
        int[] zeroLeft4 = MoveZerosLeftInPlace(array4);
        CopyArray.PrintArray(zeroLeft4);

        int[] array5 = { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 0, 6, 7, 8};
        int[] zeroLeft5 = MoveZerosLeftInPlace(array5);
        CopyArray.PrintArray(zeroLeft5);
    }

    private static int[] MoveZerosLeftInPlace(int[] array)
    {
        int zero = array.Length - 1;
        int aux = 0;
        for (int i = zero; i >= 0; i--)
        {
            if(array[i] != 0)
            {
                aux = array[zero];
                array[zero] = array[i];
                array[i] = aux;
                zero--;
            }
        }
        return array;
    }
}