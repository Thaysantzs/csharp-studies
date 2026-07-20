using System;

public class StrcutsApp
{
    public static void Main(string[] args)
    {
        Coords a = new Coords(5, 6);
        Console.WriteLine(a);
        Coords b = a;
        Console.WriteLine(b);
        a.X = 10;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

public struct Coords
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coords(int x , int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"{X}, {Y}"; 
}