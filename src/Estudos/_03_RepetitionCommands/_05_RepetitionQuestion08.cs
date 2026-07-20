
/*
 * 08. Print the Fibonacci sequence while the term is smaller than 5000. Fibonacci = 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
*/

using System;

class RepetitionQuestion08
{
    public static void Main(string[] args)
    {
        int fibonacci = 0;
        int aux = 1;
        int aux2 = 0;


        while (fibonacci < 5000)
        {
            Console.Write($"{fibonacci}, ");
            aux2 = fibonacci;
            fibonacci += aux;
            aux = aux2;
        }
    }
}
