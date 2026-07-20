using System;
using Ourcompany;
using MyArray;
/*20. Implement a routine to indicate if an array of integers has two values that sum to a provided value: bool HasSum(array, sum)*/

public class ArrayQuestion20
{
    public static void Main(string[] args)
    {
        int[] array = {5, 3, 0, 2, 8, -7, 6, 4, 5, 10};
        Console.WriteLine(HasSum(array, 8)); //True
        Console.WriteLine(HasSum(array, 5)); //True
        Console.WriteLine(HasSum(array, 1)); //True
        Console.WriteLine(HasSum(array, 18)); //True
        Console.WriteLine(HasSum(array, 6)); //True
        Console.WriteLine(HasSum(array, 0) == false); //False
        Console.WriteLine(HasSum(array, -6) == false); //False
        Console.WriteLine(HasSum(array, 20) == false); //False

    }

    private static bool HasSum(int[] array, int sum)
    {
        for (int i = 0; i < array.Length; i++){
            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[i] + array[j] == sum)
                {
                    return true;
                }
            }
        }

        return false;
    }
}