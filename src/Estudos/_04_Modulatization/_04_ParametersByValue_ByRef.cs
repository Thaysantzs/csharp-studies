using System;
using Ourcompany;

class ParametersByValueByRef
{
    public static void Main(string[] args)
    {
        int number1 = Library.ReadInterge("Number 1", "=");
        int number2 = Library.ReadInterge("Number 2", "=");
        Console.WriteLine($"\nNumber_1 - {number1}    Number_2 - {number2}\n");

        SwapByValue(number1, number2);
        Console.WriteLine($"Number_1 - {number1}    Number_2 - {number2}");

        SwapByRef(ref number1, ref number2);
        Console.WriteLine($"Number_1 - {number1}    Number_2 - {number2}");

    }

    public static void SwapByValue(int a, int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }

    public static void SwapByRef(ref int a, ref int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }
}