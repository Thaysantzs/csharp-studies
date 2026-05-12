/*
- Console Class
  - https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0
- Input/Read
- Output/Write
- Casting
  - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
- Convertion
  - https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=net-7.0
- String interpolation
  - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
 */

using System;

class IO
{
    public static void Main(string[] args)
    {
        // Console.Write("Name: ");
        // string? userName = Console.ReadLine();
        // Console.Write("Olá ");
        // Console.WriteLine(userName);

        // int i = 45675557;
        // long l = long.MaxValue;
        // i = (int)l;

        // Console.Write("Type your age: ");
        // string? ageAsString = Console.ReadLine();
        // int age = Convert.ToInt16(ageAsString);
        // Console.WriteLine("Your age is: " + age);

        Console.Write("Name: ");
        string? name = Console.ReadLine();

        Console.Write("Age: ");
        int age = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Hello " + name + " your age is " + age);
        Console.ReadKey();
    }
}