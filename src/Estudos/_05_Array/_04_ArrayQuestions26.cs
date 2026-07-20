using System;
using Ourcompany;
using MyArray;
/*26. Implement a routine to randomize an array of integers*/

public class ArrayQuestion26
{
    public static void Main(string[] args)
    {
        int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        RamdomizeArray(array);
        CopyArray.PrintArray(array);
    }

    private static int[] RamdomizeArray(int[] array)
    {
        Random random = new Random();
        int aux = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            int rdn = random.Next(i, array.Length);
            aux = array[i];
            array[i] = array[rdn];
            array[rdn] = aux;
        }
        return array;
    }
}