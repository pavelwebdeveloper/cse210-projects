using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> _shapes = new List<Shape>();

        _shapes.Add(new Square("green", 2));
        _shapes.Add(new Rectangle("red", 3, 4));
        _shapes.Add(new Circle("blue", 5));

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
        
    }    
}