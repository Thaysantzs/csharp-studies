using System;
public class ParamsApp
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Sum: {Sum(1, 2, 3, 5, 6)}");
        Console.WriteLine($"Sum: {Sum(7, 3)}");
        Console.WriteLine($"Average: {Average(Sum(7, 3),  Sum(1, 2, 3, 5, 6))}");
        Console.WriteLine($"Average: {Average(5, 9, 6)}");
    }

    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach(int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    public static int Average(params int[] numbers)
    {
        int count = 0;
        int sum = 0;
        foreach(int num in numbers)
        {
            sum += num;
            count++;
        }
        
        return sum / count;
    } 
}