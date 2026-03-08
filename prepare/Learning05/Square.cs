using System.Drawing;


public class Square : Shape
{
    private static string color;
    private double _side;
   public Square(string coor, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}