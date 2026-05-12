using System;
using Ourcompany;
using MyArray;
/*25. Implement a routine to given an array of N non-negative integers representing an elevation map where the width of each bar is 1,
compute how much water it is able to trap after raining.*/

public class ArrayQuestion25
{
    public static void Main(string[] args)
    {
        int[] elevations = {2, 1, 3, 0, 1, 3, 2, 0, 1, 2, 0, 1, 4, 1, 5, 0, 2, 1, 3, 0, 0, 2};
        int trapedWater = GetTrapedWater(elevations);
        Console.WriteLine(trapedWater);
    }

    private static int GetTrapedWater(int[] elevations)
    {
        // Get the max elevetion on left
        int[] maxElevetionLeft = new int[elevations.Length];
        GetElevationsOnLeft(elevations, maxElevetionLeft);

        // Get the max elevetion on right
        int[] maxElevetionRight = new int[elevations.Length];
        GetElevationsOnRight(elevations, maxElevetionRight);

        // Water calculation
        int result = 0;
        for (int i = 0; i < elevations.Length; i++)
        {
            int min = Math.Min(maxElevetionLeft[i], maxElevetionRight[i]);
            int trapedWater = min - elevations[i];
            if(trapedWater > 0)
            {
                result += trapedWater;
            }
        }

        return result;
    }

    private static void GetElevationsOnRight(int[] elevations, int[] maxElevetionRight)
    {
        int maxRight = 0;
        for (int i = elevations.Length - 2; i >= 0; i--)
        {
            if (elevations[i + 1] > maxRight)
            {
                maxRight = elevations[i + 1];
            }
            maxElevetionRight[i] = maxRight;
        }
    }
    private static void GetElevationsOnLeft(int[] elevations, int[] maxElevetionLeft)
    {
        int maxLeft = 0;
        for (int i = 1; i < elevations.Length; i++)
        {
            if (elevations[i - 1] > maxLeft)
            {
                maxLeft = elevations[i - 1];
            }
            maxElevetionLeft[i] = maxLeft;
        }
    }

}