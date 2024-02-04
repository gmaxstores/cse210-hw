using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("yellow", 3);
        //Console.WriteLine(square.GetColor());
        //Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("blue", 4, 5);
        //Console.WriteLine(rectangle.GetColor());
        //Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("pink", 2);
        //Console.WriteLine(circle.GetColor());
        //Console.WriteLine(circle.GetArea());
        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}