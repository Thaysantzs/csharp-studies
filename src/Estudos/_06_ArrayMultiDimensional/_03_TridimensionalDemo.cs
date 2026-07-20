using System;

public class _03_TridimenionalDemo
{
    public static void Main(string[] args)
    {
        string[] month = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "Octorber", "Nocvember", "December"};
        int[] preciptationPerMonth = {5, 3, 7, 9, 3, 4, 6, 1, 8, 3, 2, 5};

        // Printing percipitation per Month
        Console.WriteLine("Perciptation");
        for (int i = 0; i < month.Length; i++)
        {
            Console.WriteLine($"    {month[i]}: {preciptationPerMonth[i]}");
        }
        Console.WriteLine();

        string[] states = { "California", "Florida", "Nevada", "Texas" };
        int[,] perciptation ={

            {11, 13, 16, 15, 10, 10, 15, 18, 10, 15, 10, 12},
            {19, 21, 25, 22, 31, 35, 50, 38, 20, 45, 25, 24},
            {10, 11, 12, 12, 15, 20, 11, 12, 15, 17, 15, 18},
            {11, 11, 13, 11, 21, 13, 10, 15, 14, 13, 15, 27},

        };

        for (int i = 0; i < states.Length; i++)
        {
            Console.WriteLine($"{states[i]}:");
            for (int j = 0; j < month.Length; j++)
            {
                Console.WriteLine($"  {month[j]}: {perciptation[i, j]}");
            }
            Console.WriteLine();
        }
    }
}