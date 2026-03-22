using System;
using System.Collections.Generic;
using Shape;

class Program
{
    static void Main(string[] args)
    {
        List<Shape.Shape> shapes = new List<Shape.Shape>();

        Square s1 = new Square("red",3 );
        
        Rectangle s2 = new Rectangle("yellow",7,7);
        
        Circle s3 = new Circle("Blue",5);

        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);


        
        
       

        foreach (Shape.Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine("Color: " + s.GetColor());
            Console.WriteLine("Area: " + s.GetArea());
            
        }

       
    }
}

