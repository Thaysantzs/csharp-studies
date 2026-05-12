using System;
namespace MyArray;

public class CopyArray
{
    public static int[] Clone(int[] inputArray)
    {
        int[] CopyArray = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            CopyArray[i] = inputArray[i];
        }

        return CopyArray;
    }

    public static int[] ReadIntArray(string label, int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{label}[{i}] = ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }

    public static void PrintArray(int[] array, string? title = "Array", bool inline = true)
    {
        if (inline)
        {
            PrintArrayInline(array, title);
        }
        else
        {
            PrintArrayMultiline(array, title);
        }
    }

    private static void PrintArrayInline(int[] array, string? title)
    {
        if (title != null)
        {
            Console.Write($"{title}: ");
        }
        // Open brackets
        Console.Write("[");
        // All elements but the last one
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        // Last element and the close bracket
        Console.WriteLine($"{array[array.Length - 1]}]");
    }

    private static void PrintArrayMultiline(int[] array, string? title)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{title}[{i}] : {array[i]}");
        }
    }

    public static void FindMinAndMax(int[] array, string label = "array", string? size = "max")
    {
        if (size == "max")
        {
            FindMax(array, label);
        }
        else if (size == "min")
        {
            FindMin(array, label);
        }
    }


    private static void FindMax(int[] array, string label)
    {
        int maxNumber = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxNumber)
            {
                maxNumber = array[i];
            }
        }
        Console.Write($"The heighest numbers {label} is : {maxNumber}");
    }

    private static void FindMin(int[] array, string label)
    {
        int minNumber = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minNumber)
            {
                minNumber = array[i];
            }
        }
        Console.Write($"The smallest numbers {label} is : {minNumber}");
    }

    public static double ArrayAverage(int[] array)
    {
        int sum = ArraySum(array);

        return sum / (double)array.Length;
    }

    private static int ArraySum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }
}