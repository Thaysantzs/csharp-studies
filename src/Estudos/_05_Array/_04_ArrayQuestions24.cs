using System;
using Ourcompany;
using MyArray;
/*24. Implement a routine to return the longest sequence of duplicated elements of an array of integers containing only 0s and 1s*/

public class ArrayQuestion24
{
    public static void Main(string[] args)
    {
        int[] array = {1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1};
        Console.WriteLine(GetLongestSequence(array));     
    }

    private static int GetLongestSequence(int[] array)
    {
        int longest = 1;
        int longestLocal = 1;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if(array[i] == array[i + 1])
            {
                longestLocal++;
                if(longestLocal > longest)
                {
                    longest = longestLocal;
                }
            }
            else
            {
                longestLocal = 1;
            }
        }
        return longest;
    }
}