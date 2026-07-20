using System;
using Ourcompany;
using MyArray;
/*15. Implement a routine to receive two arrays of integers and return an array with the intersection*/

public class ArrayQuestion15
{
    public static void Main(string[] args)
    {
        int[] a = { 3, 9, 5, 2, 8, 0 };
        int[] b = { 0, 3, 4, 6, 7, 9, 8, 1 };
        int[] intersection = ArrayIntersection(a, b);

        CopyArray.PrintArray(a, "Array a");
        CopyArray.PrintArray(b, "Array b");
        CopyArray.PrintArray(intersection, "Array intersection");
    }

    public static int[] ArrayIntersection(int[] a, int[] b)
    {
        int[] intersection = new int[Math.Min(a.Length, b.Length)];
        int ii = 0;

        for (int ia = 0; ia < a.Length; ia++)
        {
            for (int ib = 0; ib < b.Length; ib++)
            {
                if (a[ia] == b[ib])
                {
                    intersection[ii] = a[ia];
                    ii++;
                    break;
                }
            }
        }

        int[] result = new int[ii];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = intersection[i];
        }

        return result;
    }
}