using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("blue", 5);
        Rectangle rectangle = new Rectangle("green", 5, 10);
        Circle circle = new Circle("Green", 5);

        List<Shape> shapes = new List<Shape>() {square, rectangle, circle};

        foreach(Shape shape in shapes)
{
    Console.WriteLine($"Color: {shape.Color}, Area: {shape.GetArea()} ");
}
    }
}