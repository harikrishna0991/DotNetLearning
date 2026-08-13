// ============================================
// Module 2 - Task 2.3
// Encapsulation & SOLID Basics
// Open/Closed Principle
// ============================================

Console.WriteLine("======================================");
Console.WriteLine("      SHAPE SOLID PRINCIPLE");
Console.WriteLine("======================================");

// Existing shapes + new Pentagon
List<IShape> shapes = new List<IShape>
{
    new Circle(5),
    new Rectangle(10, 6),
    new Triangle(8, 5, 5, 6, 7),
    new Pentagon(5, 4)
};


// The processing code does not need to know
// which specific shape it is handling.
foreach (IShape shape in shapes)
{
    Console.WriteLine();
    Console.WriteLine($"Shape     : {shape.Name}");
    Console.WriteLine($"Area      : {shape.CalculateArea():F2}");
    Console.WriteLine($"Perimeter : {shape.CalculatePerimeter():F2}");
}

Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine("       SOLID EXERCISE COMPLETED");
Console.WriteLine("======================================");


// ============================================
// IShape Interface
// ============================================

interface IShape
{
    string Name { get; }

    double CalculateArea();

    double CalculatePerimeter();
}


// ============================================
// Circle
// ============================================

class Circle : IShape
{
    public string Name => "Circle";

    public double Radius { get; }


    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException(
                "Radius must be greater than zero."
            );
        }

        Radius = radius;
    }


    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }


    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}


// ============================================
// Rectangle
// ============================================

class Rectangle : IShape
{
    public string Name => "Rectangle";

    public double Width { get; }

    public double Height { get; }


    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new ArgumentException(
                "Width and height must be greater than zero."
            );
        }

        Width = width;
        Height = height;
    }


    public double CalculateArea()
    {
        return Width * Height;
    }


    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}


// ============================================
// Triangle
// ============================================

class Triangle : IShape
{
    public string Name => "Triangle";

    public double Base { get; }

    public double Height { get; }

    public double SideA { get; }

    public double SideB { get; }

    public double SideC { get; }


    public Triangle(
        double baseLength,
        double height,
        double sideA,
        double sideB,
        double sideC)
    {
        if (baseLength <= 0 ||
            height <= 0 ||
            sideA <= 0 ||
            sideB <= 0 ||
            sideC <= 0)
        {
            throw new ArgumentException(
                "Triangle dimensions must be greater than zero."
            );
        }

        Base = baseLength;
        Height = height;
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }


    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }


    public double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
}


// ============================================
// NEW SHAPE — Pentagon
// ============================================

class Pentagon : IShape
{
    public string Name => "Pentagon";

    public double SideLength { get; }

    public double Apothem { get; }


    public Pentagon(double sideLength, double apothem)
    {
        if (sideLength <= 0 || apothem <= 0)
        {
            throw new ArgumentException(
                "Side length and apothem must be greater than zero."
            );
        }

        SideLength = sideLength;
        Apothem = apothem;
    }


    public double CalculateArea()
    {
        return (5 * SideLength * Apothem) / 2;
    }


    public double CalculatePerimeter()
    {
        return 5 * SideLength;
    }
}
