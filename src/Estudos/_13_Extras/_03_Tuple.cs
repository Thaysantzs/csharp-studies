using System;
using System.Security.Cryptography;
using OurCompany.LearnCoding.OOP.Inheritance3;

public class Tuple
{
    public static void Main(string[] args)
    {
        // Tuple

        var tuple = (1, "Hello", 3.12);
        Console.WriteLine(tuple);
        Console.WriteLine(tuple.Item1);
        Console.WriteLine(tuple.Item2);
        Console.WriteLine(tuple.Item3);
        tuple.Item1 = 10;
        tuple.Item2 = "See you";
        tuple.Item3 = 2.3465;
        Console.WriteLine(tuple);
        Console.WriteLine(tuple.Item1);
        Console.WriteLine(tuple.Item2);
        Console.WriteLine(tuple.Item3);


        // Named Tuple
        var person = (Name: "Thiago", Age: 21, City: "Brasilia");
        Console.WriteLine(person);
        Console.WriteLine($"Name - {person.Name}; Age - {person.Age}; City - {person.City}");

        // Deconstructing Tuples
        var (min , max) = FindMindMax(8, 3, 5, 1, 9, 2, 0);
        Console.WriteLine($"Min: {min}, Max: {max}");
    }

    private static (int, int) FindMindMax(params int[] numbers)
    {
        return (numbers.Min(), numbers.Max());
    }
}