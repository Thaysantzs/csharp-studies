using System;
using Ourcompany;

/*
 1 - Create a program to read 10 integer numbers and print all numbers
     after the last number is read
 2 - Change the program to read up to 10 numbers.
     The FLAG is the value 0
 */

public class WhyArray
{
    public static void Main(string[] args)
    {
        Solution1WithArray();
    }

    public static void Solution1WithArray()
    {
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Library.ReadInterge($"Number {i + 1}", " =");

            if (numbers[i] == 0)
            {
                break;
            }
        }


        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                break;
            }

            Console.WriteLine($"\nNumber {i + 1} = {numbers[i]}");
        }
    }
}