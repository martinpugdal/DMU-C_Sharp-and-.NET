
using L3___Objektorientering;

List<Shape> shapes = [];

// random shapes
shapes.Add(new Rectangle(1, 1, 2, 3));
shapes.Add(new Circle(1, 1, 1));
shapes.Add(new Rectangle(1, 1, 1, 3));
shapes.Add(new Circle(1, 1, 2));
shapes.Add(new Rectangle(1, 1, 3, 8));
shapes.Add(new Circle(1, 1, 3));

// print areas
foreach (Shape shape in shapes)
{
    if (shape is Circle circle)
    {
        Console.WriteLine($"Radius = {circle.Radius}");
    }
    else if (shape is Rectangle rectangle)
    {
        Console.WriteLine("Length = " + rectangle.Length + ", Width = " + rectangle.Width);
    }
    Console.WriteLine(shape.X + " " + shape.Y);

    Console.WriteLine(shape.Area());
}