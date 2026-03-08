using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square(3, "red");
        Rectangle r1 = new Rectangle(7, "yelllow");
        Circle c1 = new Circle(6, "Blue");


        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.GetColor());
            Console.WriteLine("Area: " + shape.GetArea());
            
        }

    }
}
