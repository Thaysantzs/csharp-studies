using System;
namespace BigO;

/*
    Question: Implement a method to receive an array as input and return an array
        with the sum of all elements from each index to the end of the array.
*/

public class BigO_app3
{
    public static void Main(string[] args)
    {
        int[] input = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        Console.Write("O(N2)    ");
        foreach (var item in SolveON2(input))
        {
            Console.Write($"--> {item} ");
        }

        Console.WriteLine();
        Console.Write("O(N)    ");
        foreach(var item in SolveON(input))
        {
            Console.Write($" --> {item} ");
        }

        Console.WriteLine();
        Console.Write("O(1)    ");
        foreach(var item in SolveON_2(input))
        {
            Console.Write($" --> {item} ");
        }
    }

    private static int[] SolveON_2(int[] input)
    {
        int[] output = new int[input.Length];
        output[input.Length - 1] = input[input.Length - 1];
        for (int i = input.Length - 1; i > 0; i--)
        {
            output[i - 1] = output[i] + input[i - 1];
        }

        return output;
    }

    private static int[] SolveON(int[] input)
    {
        int[] output = new int[input.Length];
        int Sum = input.Sum();
        output[0] = Sum;

        for (int i = 1; i < input.Length; i++)
        {
            output[i] = output[i - 1] - input[i -1];
        }

        return output;
    }

    private static int[] SolveON2(int[] input)
    {
        int[] output = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            int Sum = 0;
            for (int j = i; j < input.Length; j++)
            {
                Sum += j;
            }
            output[i] = Sum;
        }

        return output;
    }
}