using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> differentShapes = new List<Shape>();

        Circle circle = new Circle("Orange", 2.50);
        differentShapes.Add(circle);

        Rectangle rectangle = new Rectangle("Maroon", 5.0, 6.7);
        differentShapes.Add(rectangle);

        Square square = new Square("Violet", 9.50);
        differentShapes.Add(square);

        foreach (Shape s in differentShapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"This the area {area:F2} of {color} shape.");
        }

    }
}