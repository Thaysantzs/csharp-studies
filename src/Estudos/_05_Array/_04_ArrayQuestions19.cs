using System;
using Ourcompany;
using MyArray;
/*19. Implement a routine to indicate if an array is in ascendent order*/

public class ArrayQuestion19
{
    public static void Main(string[] args)
    {
        int[] a = {1, 2 , 3, 7, 9,};
        int[] b = {1, 2 , 3, 7, 9, 4};
        int[] c = {1, 2 , 3, 7, 7, 9};
        int[] d = {1, 2 , 3, 7, 5, 9};

        Console.WriteLine(isAscendentOrder(a) == true);
        Console.WriteLine(isAscendentOrder(b) == false);
        Console.WriteLine(isAscendentOrder(c) == false);
        Console.WriteLine(isAscendentOrder(d) == false);
    }

    private static bool isAscendentOrder(int[] array)
    {
        // for (int i = 0; i < array.Length - 1; i++)
        // {
        //     if(array[i] >= array[i + 1])
        //     {
        //         return false;
        //     }
        // }

        for (int i = 1; i < array.Length; i++)
        {
            if(array[i] <= array[i - 1])
            {
                return false;
            }
        }

        return true;
    }
}