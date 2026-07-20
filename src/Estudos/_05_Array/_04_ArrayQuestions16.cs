using System;
using Ourcompany;
using MyArray;
/*16. Implement a routine to receive two arrays of integers (ascending order) and return an array with the intersection*/

public class ArrayQuestion16
{
    public static void Main(string[] args)
    {
      int[] a = {3, 6, 8, 13, 17, 21, 40};
      int[] b = {0, 3, 5, 17, 60};
      int[] intersection = GetIntersection(a, b);

      CopyArray.PrintArray(a, "Array a");
      CopyArray.PrintArray(b, "Array b");
      CopyArray.PrintArray(intersection, "Array intersection");
    }

    public static int[] GetIntersection(int[] a, int[] b)
    {
        int[] intersection = new int[Math.Min(a.Length, b.Length)];
        int ii = 0;
        int ia = 0;
        int ib = 0;

        while(ia < a.Length && ib < b.Length)
        {
            if(a[ia] == b[ib])
            {
                intersection[ii] = a[ia];
                ii++;
                ia++;
                ib++;
            }else if(a[ia] < b[ib])
            {
                ia++;
            }else
            {
                ib++;
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