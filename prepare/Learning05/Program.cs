using System;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 2.5);
        Rectangle rectangle1 = new Rectangle("green", 2.5, 3);
        Circle circle1 = new Circle("blue", 3);
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape item in shapes){
            Console.WriteLine($"The {item.GetColor()} shape has an area of {item.GetArea()} units.");
        }
    }
}