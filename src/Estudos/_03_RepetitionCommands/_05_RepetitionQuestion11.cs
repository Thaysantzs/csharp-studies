
/*
 * 11. Read a integer number and calculate its Factorial. f(n) = n.(n-1).(n-2)(n-3)...1
    e.g
    f(0) = 1 (Exception)
    f(1) = 1
    f(2) = 2 x 1
    f(4) = 4 x 3 x 2 x 1 = 48
    f(5) = 5 x 4 x 3 x 2 x 1 = 120
    f(6) = 6 x 5 x 4 x 3 x 2 x 1 = 720
*/

using System;

class RepetitionQuestion11
{
    public static void Main(string[] args)
    {
        Console.Write("Enter with a interge number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;

        if (number == 0 || number == 1)
        {
            Console.WriteLine($"F({number}) is = 1");
        }
        else
        {
            for (int i = number; i > 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"F({number}) is = {factorial}");
        }
    }
}