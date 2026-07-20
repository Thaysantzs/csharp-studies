using System;
class ModularizationIntro2
{
    public static void Main(string[] args)
    {
        int n1 = ReadInterger("Number 1", "=");
        int n2 = ReadInterger("Number 2", "=");
        int n3 = ReadInterger("Number 3", "=");

        double avg = Average(n1, n2, n3);
        Console.WriteLine($"The average of {n1}, {n2}, {n3} = {avg}");

        Console.WriteLine(Average(7, 3, 15));
        Console.WriteLine(Average(1, 9, 45));
    }

    public static int ReadInterger(string prompt, string signal)
    {
        Console.Write($"{prompt} {signal} ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static double Average(int n1, int n2, int n3)
    {
        int sum = (n1 + n2 + n3) / 3;
        return sum;
    }
}   