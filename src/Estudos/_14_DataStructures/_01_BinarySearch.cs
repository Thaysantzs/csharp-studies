using System;

namespace BinarySearch;

public class BinaryApp
{
    public static void Main(string[] args)
    {
        // -->  Index  0   1   2   3   4   5   6   7   8   9  10  11  12  13  14  15
        int[] array = [3, 10, 17, 22, 30, 35, 41, 53, 61, 63, 71, 85, 89, 91, 95, 99];

        Console.WriteLine(BinarySearch(array, 71));
        Console.WriteLine(BinarySearch(array, 41));
        Console.WriteLine(BinarySearch(array, 99));
        Console.WriteLine(BinarySearch(array, 3));

        Console.WriteLine(BinarySearch(array, 2));
        Console.WriteLine(BinarySearch(array, 55));
    }

    private static int BinarySearch(int[] array, int target)
    {
        int Left = 0;
        int Right = array.Length - 1;
        while(Left <= Right)
        {
            int mid = Left + (Right - Left) / 2;
            if(target == array[mid])
            {
                return mid;
            }else if(target < array[mid])
            {
                Right = mid - 1;
            }
            else
            {
                Left = mid + 1;
            }
        }

        return -1;
    }
}