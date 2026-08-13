// ============================================
// Module 2 - Task 2.2
// Inheritance & Polymorphism
// ============================================

Console.WriteLine("======================================");
Console.WriteLine("         SHAPE CALCULATOR");
Console.WriteLine("======================================");

// Store different shape objects in the same
// collection using the IShape interface.
List<IShape> shapes = new List<IShape>
{
    new Circle(5),
    new Rectangle(10, 6),
    new Triangle(8, 5, 5, 6, 7)
};


// Polymorphism:
// The same method calls work for different
// types of shapes.
foreach (IShape shape in shapes)
{
    Console.WriteLine();
    Console.WriteLine($"Shape     : {shape.Name}");
    Console.WriteLine($"Area      : {shape.CalculateArea():F2}");
    Console.WriteLine($"Perimeter : {shape.CalculatePerimeter():F2}");
}

Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine("       CALCULATION COMPLETED");
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
