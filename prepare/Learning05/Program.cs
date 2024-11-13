using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sqShape = new Square("Blue", 5);
        shapes.Add(sqShape);

        Rectangle rcShape = new Rectangle("Yellow", 10, 20);
        shapes.Add(rcShape);
                
        Circle crShape = new Circle("Red", 10);
        shapes.Add(crShape);
        
        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}