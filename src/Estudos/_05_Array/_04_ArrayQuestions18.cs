using System;
using Ourcompany;
using MyArray;
/*18. Implement a routine to receive two arrays of integers (ascending order) and return a new array with the union*/

public class ArrayQuestion18
{
    public static void Main(string[] args)
    {
        int[] a = {1, 3, 5, 7, 13, 16, 18, 22, 25, 29};
        int[] b = {3, 6, 8, 15, 18, 19, 21, 23, 29, 35};
        int[] union = GetAscendingUnion(a, b);
        CopyArray.PrintArray(a, "Array a");
        CopyArray.PrintArray(b, "Array b");
        CopyArray.PrintArray(union, "Array union");
    }

    public static int[] GetAscendingUnion(int[] a, int[] b)
    {
        int[] union = new int[a.Length + b.Length];
        int ia = 0;
        int ib = 0;
        int iu = 0;

        while(ia < a.Length && ib < b.Length){
           
           if(a[ia] == b[ib])
            {
                union[iu] = a[ia];
                ia++;
                ib++; 
            }
            else if(a[ia] < b[ib])
            {
                union[iu] = a[ia];
                ia++;
            }
            else if (b[ib] < a[ia])
            {
                union[iu] = b[ib];
                ib++;
            }
            iu++;
        }
        while(ia < a.Length)
        {
            union[iu] = a[ia];
            ia++;
        }
        while(ib < b.Length)
        {
            union[iu] = b[ib];
            ib++;
        }

        int[] result = new int[iu];
        Array.Copy(union, 0, result, 0, iu);
        return result;
    }
}