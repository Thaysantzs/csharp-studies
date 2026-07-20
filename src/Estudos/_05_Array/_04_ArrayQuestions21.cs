using System;
using Ourcompany;
using MyArray;
/*21. Implement a routine to receive two sorted arrays and return a new array with all elements and sorted as well*/

public class ArrayQuestion21
{
    public static void Main(string[] args)
    {
        int[] a = {2, 4, 5, 7, 8, 15, 16, 23};
        int[] b = {1, 3, 6, 6, 9, 11, 15, 17, 22, 23, 24, 25};
        int[] merge = ArrayMerge(a, b);

        CopyArray.PrintArray(merge, "merge");
    }

    private static int[] ArrayMerge(int[] a, int[] b)
    {
        int[] merge = new int[a.Length + b.Length];
        int ia = 0;
        int ib = 0;
        int im = 0;
        while(ia < a.Length && ib < b.Length)
        {
            if(a[ia] <= b[ib])
            {
                merge[im] = a[ia];
                ia++;
            }
            else
            {
                merge[im] = b[ib];
                ib++;
            }
            im++;
        }

        while(ia < a.Length)
        {
            merge[im] = a[ia];
            ia++;
            im++;
        }

        while(ib < b.Length)
        {
            merge[im] = b[ib];
            ib++;
            im++;
        }
        return merge;
    }
}