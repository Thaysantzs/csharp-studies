using System;
using Ourcompany;
using MyArray;
/*10. Implement a routine to check if an array of integer is palindrome*/

public class ArrayQuestion10
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 4, 7, 9, 0, 9, 7, 4 };
        Console.WriteLine(IsPalindrome(arr1));

        int[] arr2 = { 1, 2, 3, 4, 4, 3, 2, 1 };
        Console.WriteLine(IsPalindrome(arr2));

        int[] arr3 = { 5 };
        Console.WriteLine(IsPalindrome(arr3));

        int[] arr4 = { 1, 3, 5, 7, 8, 5, 3, 1 };
        Console.WriteLine(IsPalindrome(arr4));

        int[] arr5 = { 4, 7, 9, 0, 9, 7, 4, 5, };
        Console.WriteLine(IsPalindrome(arr5));

        Console.WriteLine($"Test 1 Pased: {IsPalindrome(arr1)}");
        Console.WriteLine($"Test 2 Pased: {IsPalindrome(arr2)}");
        Console.WriteLine($"Test 3 Pased: {IsPalindrome(arr3)}");
        Console.WriteLine($"Test 4 Pased: {IsPalindrome(arr4) == false}");
        Console.WriteLine($"Test 5 Pased: {IsPalindrome(arr5) == false}");
    }

    public static bool IsPalindrome(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            if (array[left] != array[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}