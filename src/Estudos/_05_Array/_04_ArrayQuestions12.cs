using System;
using Ourcompany;
using MyArray;
/*12. Implement a routine to return an array with all elements that are duplicated from an array of integer*/

public class ArrayQuestion12
{
    public static void Main(string[] args)
    {
        int[] array = { -1, 5, 6, 12, 8, 5, 12, 7, 10, 12, 6, -1 };
        CopyArray.PrintArray(array, "Array 1");
        int[] duplicate = GetDuplicate(array);
        CopyArray.PrintArray(duplicate, "duplicate 1");


        int[] array2 = {0, 15, 4, 0, 8, 7, 4, 8, 15, 4, 0, 7};
        CopyArray.PrintArray(array2, "Array 2");
        int[] duplicate2 = GetDuplicate(array2);
        CopyArray.PrintArray(duplicate2, "duplicate 2");
    }

    public static int[] GetDuplicate(int[] array)
    {
        int iDuplicate = 0;
        int[] duplicated = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    duplicated[iDuplicate] = array[i];
                    iDuplicate++;
                    break;
                }
            }
        }

        int[] dupDistincti = new int[iDuplicate];
        Array.Copy(duplicated, 0, dupDistincti, 0, iDuplicate);

        return dupDistincti.Distinct().ToArray();
    }
}