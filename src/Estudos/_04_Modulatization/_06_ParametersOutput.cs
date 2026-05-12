using System;
using Ourcompany;

public class ParameterOutput
{
    public static void Main(string[] args)
    {
        int dividend = Library.ReadInterge("Dividend", " -");
        int divisor = Library.ReadInterge("Divisor", " -");

        Library.IntDivision(dividend, divisor, out int quocient, out int remainder);
        Console.WriteLine($"{dividend} / {divisor} = {quocient}     remainder = {remainder}");
    }
}