 using System;

 namespace OurCompany.LearnCoding.OOP.Inheritance2;

 public class ShapeApp
{
    public static void Main(string[] args)
    {
        Triangle t1 = new Triangle(
            "Yellow", "Pink", 4,
            new Point(15,20),
            new Point(5,10),
            new Point(10,10)

        );
        Console.WriteLine($"Triangle: {t1.BackgroundColor}; {t1.BorderColor}; {t1.BorderWidth}");

        Square s1 = new Square(
            "Blue", "Black", 5,
            new Point(8,10),
            new Point(18,10)
        );
        Console.WriteLine($"Square: {s1.BackgroundColor}; {s1.BorderColor}; {s1.BorderWidth}");

        Rectangle r1 = new Rectangle(
            "Red", "purple", 3,
            new Point(3,8),
            new Point(13, 9),
            new Point(4,12),
            new Point(7, 22)
        );
        Console.WriteLine($"Rectangle: {r1.BackgroundColor}; {r1.BorderColor}; {r1.BorderWidth}");

        Circle c1 = new Circle(
            "Green", "Orange", 5,
            new Point(12,12), 5
        );
        Console.WriteLine($"Triangle: {c1.BackgroundColor}; {c1.BorderColor}; {c1.BorderWidth}");
    }
}

public class Shape
{
    public string? BackgroundColor { set; get; }
    public string? BorderColor { set; get; }
    public int BorderWidth { set; get; }

    public Shape(string backgroundColor, string borderColor, int borderWidth)
    {
        BackgroundColor = backgroundColor;
        BorderColor = borderColor;
        BorderWidth = borderWidth;
    }
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y; 
    }
}

public class Triangle : Shape
{
    public Point Point1 { set; get; }
    public Point Point2 { set; get; }
    public Point Point3 { set; get; }
    public Triangle(string backgroundColor, string borderColor, int borderWidth, Point point1, Point point2, Point point3) : base(backgroundColor, borderColor, borderWidth)
    {
        BackgroundColor = backgroundColor;
        BorderColor = borderColor;
        BorderWidth = borderWidth;
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
    }
}


public class Square : Shape
{
    public Point Point1 { set; get; }
    public Point Point2 { set; get; }
    public Square(string backgroundColor, string borderColor, int borderWidth, Point point1, Point point2) : base(backgroundColor, borderColor, borderWidth)
    {
        Point1 = point1;
        Point2 = point2;
    }
}


public class Rectangle : Shape
{
    public Point Point1 { get; set; }
    public Point Point2 { get; set; }
    public Point Point3 { get; set; }
    public Point Point4 { get; set; }

    public Rectangle(string backgroundColor, string borderColor, int borderWidth, Point point1, Point point2, Point point3, Point point4) : base(backgroundColor, borderColor, borderWidth)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
        Point4 = point4;

    }
}


public class Circle : Shape
{
    public Point Center { get; set; }
    public int Radius { set; get; }

    public Circle(string backgroundColor, string borderColor, int borderWidth, Point center, int radius) : base(backgroundColor, borderColor, borderWidth)
    {
        Center = center;
        Radius = radius;
    }
} 